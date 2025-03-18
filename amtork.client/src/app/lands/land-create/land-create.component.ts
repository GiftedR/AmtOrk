import { Component, OnInit } from '@angular/core';
import { emptyLand, Land } from '../../models/land';
import { FormBuilder, FormGroup } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { LandsService } from '../../services/lands.service';
import { emptyKingdom, Kingdom } from '../../models/kingdom';
import { KingdomsService } from '../../services/kingdoms.service';

@Component({
  selector: 'app-land-create',
  standalone: false,
  templateUrl: './land-create.component.html',
  styleUrl: './land-create.component.css'
})
export class LandCreateComponent implements OnInit {
  land:Land = emptyLand;
  landKingdom:Kingdom | undefined;
  _kingdomSlug:string | undefined;

  landCreateFormGroup:FormGroup;
  finishRedirect:string[] = [];

  constructor(public _route:ActivatedRoute, private _router:Router, private _land:LandsService, private _fb:FormBuilder, private _kingdom:KingdomsService)
  {
    this.landCreateFormGroup = this._fb.group({
      landName: [''],
      landDescription: [''],
      landLocation: ['']
    });

    this._route.paramMap.subscribe(pM => {
			if (this.land == null) this.land = emptyLand;
      this._kingdomSlug = pM.get("kingdomName")!;
			this.finishRedirect = ['kingdoms', this._kingdomSlug];
		})

    this._kingdom.kingdom$.subscribe(kingdom => {
      this.landKingdom = kingdom;
    })
  }

  ngOnInit(): void {
    if (this._kingdomSlug != undefined)
    {
      this._kingdom.getKingdomBySlugName(this._kingdomSlug);
    }
  }

	onSubmit()
	{
		if (this.land == null || !this.landCreateFormGroup.valid)
			return;

		const createdLand : Land = {...this.land, ...this.landCreateFormGroup.value };

    console.log(createdLand);

    if (this.landKingdom != undefined)
    {
      createdLand.kingdomId = this.landKingdom.id;
    }

		this._land.createLand(createdLand);
		this._router.navigate(['../'], {relativeTo:this._route});
	}
}
