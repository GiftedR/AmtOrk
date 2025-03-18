import { Component, OnInit } from '@angular/core';
import { BehaviorSubject } from 'rxjs';
import { Land } from '../../models/land';
import { LandsService } from '../../services/lands.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-land-data',
  standalone: false,
  templateUrl: './land-data.component.html',
  styleUrl: './land-data.component.css'
})
export class LandDataComponent implements OnInit {
  land$:BehaviorSubject<Land>;
  isLoaded = false;

  constructor(private _land:LandsService, public _route:ActivatedRoute)
  {
    this.land$ = this._land.land$
  }

  ngOnInit(): void {
    this.isLoaded = false;
    this._route.paramMap.subscribe(data => {
      this._land.getLandBySlugName(data.get('land')!);
      console.log(this.land$)
      this.isLoaded = true;
    });
  }
}
