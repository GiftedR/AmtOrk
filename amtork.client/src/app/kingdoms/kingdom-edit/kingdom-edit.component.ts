import { Component, OnInit } from '@angular/core';
import { BehaviorSubject } from 'rxjs';
import { emptyKingdom, Kingdom } from '../../models/kingdom';
import { KingdomsService } from '../../services/kingdoms.service';
import { FormBuilder, FormControl, FormGroup } from '@angular/forms';
import { Land } from '../../models/land';
import { ActivatedRoute, Router } from '@angular/router';
import { LandsService } from '../../services/lands.service';

@Component({
  selector: 'app-kingdom-edit',
  standalone: false,
  templateUrl: './kingdom-edit.component.html',
  styleUrl: './kingdom-edit.component.css'
})
export class KingdomEditComponent implements OnInit {
  kingdomEditFormGroup:FormGroup;

  editingKingdom:Kingdom = emptyKingdom;

  _kingdomSlug:string | undefined;

  constructor(private _kingdom:KingdomsService, private _fb:FormBuilder, private _route:ActivatedRoute, private _land:LandsService, private _router:Router){
    this._kingdom.kingdom$.subscribe(king => {
      this.editingKingdom = king;
    })
    this.kingdomEditFormGroup = this._fb.group({
      kingdomIconPath: [''],
      kingdomName: ['']
    });

    this._route.paramMap.subscribe(data => {
      const kingslug:string | null = data.get('kingdomName');

      if (kingslug != null)
        {
          this._kingdomSlug = kingslug;
          this._kingdom.getKingdomBySlugName(kingslug);
      }
    });
  }

  ngOnInit(): void {
    this.kingdomEditFormGroup.patchValue({
      kingdomIconPath: this.editingKingdom.kingdomIconPath,
      kingdomName: this.editingKingdom.kingdomName
    })
  }

  deleteLand(land:Land){
    this._land.deleteLand(land.id);
    if (this._kingdomSlug != undefined)
    {
      this._kingdom.getKingdomBySlugName(this._kingdomSlug);
    }
  }

  onSubmit(){
		if (this.editingKingdom == null || !this.kingdomEditFormGroup.valid)
			return;

		const updatedKingdom : Kingdom = {...this.editingKingdom, ...this.kingdomEditFormGroup.value };

		this._kingdom.updateKingdom(updatedKingdom.id, updatedKingdom);
		this._router.navigate(['../'], {relativeTo:this._route});
  }
}
