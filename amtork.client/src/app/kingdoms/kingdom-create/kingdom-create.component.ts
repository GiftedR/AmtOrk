import { Component, OnInit } from '@angular/core';
import { emptyKingdom, Kingdom } from '../../models/kingdom';
import { FormBuilder, FormGroup } from '@angular/forms';
import { KingdomsService } from '../../services/kingdoms.service';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-kingdom-create',
  standalone: false,
  templateUrl: './kingdom-create.component.html',
  styleUrl: './kingdom-create.component.css'
})
export class KingdomCreateComponent implements OnInit{
  creatingKingdom:Kingdom = emptyKingdom;
  kingdomCreateFormGroup:FormGroup;
  
  constructor(private _fb:FormBuilder, private _kingdom:KingdomsService, private _router:Router, private _route:ActivatedRoute)
  {
    this.kingdomCreateFormGroup = this._fb.group({
      kingdomIconPath: [''],
      kingdomName: ['']
    });
  }
  ngOnInit(): void {
    this.kingdomCreateFormGroup.patchValue({
      kingdomIconPath: this.creatingKingdom.kingdomIconPath,
      kingdomName: this.creatingKingdom.kingdomName
    });
  }

  onSubmit(){
		if (this.creatingKingdom == null || !this.kingdomCreateFormGroup.valid)
			return;

		const createdKingdom : Kingdom = {...this.creatingKingdom, ...this.kingdomCreateFormGroup.value };

		this._kingdom.createKingdom(createdKingdom);
    this._kingdom.getAllKingdoms();
		this._router.navigate(['../'], {relativeTo:this._route});
  }
}
