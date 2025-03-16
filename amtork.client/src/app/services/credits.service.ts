import { Injectable } from '@angular/core';
import { Credit, emptyCredit } from '../models/credit';
import { BehaviorSubject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class CreditsService {
  credits$:BehaviorSubject<Credit[]> = new BehaviorSubject<Credit[]>([]);
  credit$:BehaviorSubject<Credit> = new BehaviorSubject<Credit>(emptyCredit);

  constructor() { }
}
