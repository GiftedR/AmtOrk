import { Component, OnInit } from '@angular/core';
import { BehaviorSubject } from 'rxjs';
import { Kingdom } from '../../models/kingdom';
import { KingdomsService } from '../../services/kingdoms.service';

@Component({
  selector: 'app-kingdom-list-edit',
  standalone: false,
  templateUrl: './kingdom-list-edit.component.html',
  styleUrl: './kingdom-list-edit.component.css'
})
export class KingdomListEditComponent implements OnInit {

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

  deleteKingdon(kingdom:Kingdom)
  {
    this._kingdom.deleteKingdom(kingdom.id);

    let originalkingdoms:Kingdom[] = this.kingdoms$.getValue();
    let changedkingdoms:Kingdom[] = [];

    originalkingdoms.forEach((kingdomItem) => {
      if (kingdomItem.id != kingdom.id)
      {
        changedkingdoms.push(kingdomItem);
      }
    });

    this._kingdom.kingdoms$.next(changedkingdoms);
  }
}
