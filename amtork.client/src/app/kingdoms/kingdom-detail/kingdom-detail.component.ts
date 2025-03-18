import { Component, OnInit } from '@angular/core';
import { BehaviorSubject } from 'rxjs';
import { Kingdom } from '../../models/kingdom';
import { KingdomsService } from '../../services/kingdoms.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-kingdom-detail',
  standalone: false,
  templateUrl: './kingdom-detail.component.html',
  styleUrl: './kingdom-detail.component.css'
})
export class KingdomDetailComponent implements OnInit {
  kingdom$:BehaviorSubject<Kingdom>;
  isLoaded = false;

  constructor(private _kingdom:KingdomsService, private _route:ActivatedRoute)
  {
    this.kingdom$ = this._kingdom.kingdom$;
  }

  ngOnInit(): void {
    this._route.paramMap.subscribe(data => {
      this._kingdom.getKingdomBySlugName(data.get('kingdomName')!);
      this.isLoaded = true;
    });
  }
}
