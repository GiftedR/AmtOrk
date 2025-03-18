import { Component, OnInit } from '@angular/core';
import { BehaviorSubject } from 'rxjs';
import { Kingdom } from '../../models/kingdom';
import { KingdomsService } from '../../services/kingdoms.service';

@Component({
  selector: 'app-kingdom-list',
  standalone: false,
  templateUrl: './kingdom-list.component.html',
  styleUrl: './kingdom-list.component.css'
})
export class KingdomListComponent implements OnInit {

  kingdoms$:BehaviorSubject<Kingdom[]>;

  isLoaded = false;

  constructor(private _kingdom:KingdomsService) {
    this.kingdoms$ = _kingdom.kingdoms$;

    this.kingdoms$.subscribe((kingdoms) => {
      this.isLoaded = kingdoms.length > 0;
    });
  }

  ngOnInit(): void {
    this._kingdom.getAllKingdoms();
  }
}
