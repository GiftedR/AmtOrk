import { Component, OnInit } from '@angular/core';
import { BehaviorSubject } from 'rxjs';
import { Kingdom } from '../../models/kingdom';
import { KingdomsService } from '../../services/kingdoms.service';

@Component({
  selector: 'app-kingdom-detail',
  standalone: false,
  templateUrl: './kingdom-detail.component.html',
  styleUrl: './kingdom-detail.component.css'
})
export class KingdomDetailComponent implements OnInit {
  kingdom$:BehaviorSubject<Kingdom>;

  constructor(private _kingdom:KingdomsService)
  {
    this.kingdom$ = this._kingdom.kingdom$;
  }

  ngOnInit(): void {
    
  }
}
