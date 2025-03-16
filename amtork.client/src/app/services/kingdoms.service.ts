import { Injectable } from '@angular/core';
import { emptyKingdom, Kingdom } from '../models/kingdom';
import { BehaviorSubject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class KingdomsService {
  kingdoms$:BehaviorSubject<Kingdom[]> = new BehaviorSubject<Kingdom[]>([]);
  kingdom$:BehaviorSubject<Kingdom> = new BehaviorSubject<Kingdom>(emptyKingdom);

  constructor() { }
}
