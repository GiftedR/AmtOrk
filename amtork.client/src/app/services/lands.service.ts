import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';
import { emptyLand, Land } from '../models/land';

@Injectable({
  providedIn: 'root'
})
export class LandsService {
  lands$:BehaviorSubject<Land[]> = new BehaviorSubject<Land[]>([]);
  land$:BehaviorSubject<Land> = new BehaviorSubject<Land>(emptyLand);
  
  constructor(private _http:HttpClient) { }

}
