import { Injectable } from '@angular/core';
import { AmtgardEvent, emptyEvent } from '../models/amtgardEvent';
import { BehaviorSubject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class EventsService {
  events$:BehaviorSubject<AmtgardEvent[]> = new BehaviorSubject<AmtgardEvent[]>([]);
  event$:BehaviorSubject<AmtgardEvent> = new BehaviorSubject<AmtgardEvent>(emptyEvent);

  constructor() { }
}
