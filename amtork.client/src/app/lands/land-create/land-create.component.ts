import { Component } from '@angular/core';
import { emptyLand, Land } from '../../models/land';
import { FormBuilder, FormGroup } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { LandsService } from '../../services/lands.service';

@Component({
  selector: 'app-land-create',
  standalone: false,
  templateUrl: './land-create.component.html',
  styleUrl: './land-create.component.css'
})
export class LandCreateComponent {
  land:Land = emptyLand;
  landCreateFormGroup:FormGroup;
  finishRedirect:string[] = [];

  constructor(public _route:ActivatedRoute, private _router:Router, private _land:LandsService, private _fb:FormBuilder)
  {
    this.landCreateFormGroup = this._fb.group({
      landName: [''],
      landDescription: [''],
      landLocation: ['']
    });

    this._route.paramMap.subscribe(pM => {
			if (this.land == null) this.land = emptyLand;
			this.finishRedirect = ['kingdoms', pM.get("kingdomName")!];
		})
  }

	onSubmit()
	{
		if (this.land == null || !this.landCreateFormGroup.valid)
			return;

		const updatedLand : Land = {...this.land, ...this.landCreateFormGroup.value };

    console.log(updatedLand);

		this._land.createLand(updatedLand);
		// this._router.navigate(this.finishRedirect);
	}
}
