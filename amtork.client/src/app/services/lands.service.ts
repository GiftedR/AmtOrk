import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable, tap } from 'rxjs';
import { emptyLand, Land } from '../models/land';

@Injectable({
  providedIn: 'root'
})
export class LandsService {
  lands$:BehaviorSubject<Land[]> = new BehaviorSubject<Land[]>([]);
  land$:BehaviorSubject<Land> = new BehaviorSubject<Land>(emptyLand);

  constructor(private _http:HttpClient) { }

  getAllLands()
  {
    this._http.get<Land[]>(`/api/lands`).subscribe((land:Land[]) => {
      this.lands$.next(land);
    });
  }

  getLandById(id:number) {
    this._http.get<Land>(`/api/lands/${id}`).subscribe((land:Land) => {
      this.land$.next(land);
    });
  }

  getLandBySlugName(slug:string) {
    this._http.get<Land>(`/api/Lands/name/${slug}`).subscribe((land:Land) => {
      this.land$.next(land);
    });
  }

  updateLand(id:number, land:Land) {
    this._http.put<Land>(`/api/Lands/${id}`, land).subscribe((newland:Land) => {
      this.land$.next(land);
    });
  }
  
  createLand(land:Land) {
    this._http.post<Land>(`/api/Lands/`, land).subscribe((land:Land) => {
      this.land$.next(land);
    });
  }

  deleteLand(id:number){
    this._http.delete<Land>(`/api/Lands/${id}`).subscribe((land:Land) => {
      this.land$.next(land);
    })
  }
}
