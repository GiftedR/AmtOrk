import { Injectable } from '@angular/core';
import { emptyKingdom, Kingdom } from '../models/kingdom';
import { BehaviorSubject } from 'rxjs';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class KingdomsService {
  kingdoms$:BehaviorSubject<Kingdom[]> = new BehaviorSubject<Kingdom[]>([]);
  kingdom$:BehaviorSubject<Kingdom> = new BehaviorSubject<Kingdom>(emptyKingdom);

  constructor(private _http:HttpClient) { }

  getAllKingdoms() {
    this._http.get<Kingdom[]>(`/api/kingdoms`).subscribe((kingdoms:Kingdom[]) => {
      this.kingdoms$.next(kingdoms);
    });
  }

  getKingdomById(id:number) {
    this._http.get<Kingdom>(`/api/kingdoms/${id}`).subscribe((kingdom:Kingdom) => {
      this.kingdom$.next(kingdom);
    });
  }

  getKingdomBySlugName(slug:string) {
    this._http.get<Kingdom>(`/api/kingdoms/name/${slug}`).subscribe((kingdom:Kingdom) => {
      this.kingdom$.next(kingdom);
    });
  }
  
    updateKingdom(id:number, kingdom:Kingdom) {
      this._http.put<Kingdom>(`/api/Kingdoms/${id}`, kingdom).subscribe((newkingdom:Kingdom) => {
        this.kingdom$.next(kingdom);
      });
    }
    
    createKingdom(kingdom:Kingdom) {
      this._http.post<Kingdom>(`/api/Kingdoms/`, kingdom).subscribe((kingdom:Kingdom) => {
        this.kingdom$.next(kingdom);
      });
    }
  
    deleteKingdom(id:number){
      this._http.delete<Kingdom>(`/api/Kingdoms/${id}`).subscribe((kingdom:Kingdom) => {
        this.kingdom$.next(kingdom);
      })
    }
}
