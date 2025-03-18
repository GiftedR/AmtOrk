import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, NavigationEnd, Router } from '@angular/router';
import { emptyLand, Land } from '../../models/land';
import { LandsService } from '../../services/lands.service';
import { FormGroup, FormControl, FormBuilder } from '@angular/forms';

@Component({
	selector: 'app-land-edit',
	standalone: false,
	templateUrl: './land-edit.component.html',
	styleUrl: './land-edit.component.css'
})
export class LandEditComponent implements OnInit {
	land:Land = emptyLand;
	landEditFormGroup:FormGroup;

	finishRedirect:string[] = [];

	constructor(public _route:ActivatedRoute, private _router:Router, private _land:LandsService, private _fb:FormBuilder)
	{
		this._router.events.subscribe(routerevent => { if (routerevent instanceof NavigationEnd) this.getLandData(); })
			this.landEditFormGroup = this._fb.group({
				landName: [''],
				landDescription: [''],
				landLocation: ['']
			});
	}	
	
	ngOnInit(): void {
		this.initForm();
	}

	initForm() {
	}

	getLandData() {
		this._route.paramMap.subscribe(pM => {
			if (this.land == null) this.land = emptyLand;
			this.land.landSlug = pM.get('land')!;
			this.finishRedirect = ['kingdoms', pM.get("kingdomName")!, pM.get("land")!];
			this._land.getLandBySlugName(this.land.landSlug);
		})
		

		this._land.land$.subscribe((land:Land) => {
			this.land = land;
			if (land != null){
				this.landEditFormGroup.patchValue({
					landName: land.landName,
					landDescription: land.landDescription,
					landLocation: land.landLocation
				})
			}
		})
	}

	onSubmit()
	{
		if (this.land == null || !this.landEditFormGroup.valid)
			return;

		const updatedLand : Land = {...this.land, ...this.landEditFormGroup.value };

		this._land.updateLand(updatedLand.id, updatedLand);
		this._router.navigate(this.finishRedirect);
	}
}
