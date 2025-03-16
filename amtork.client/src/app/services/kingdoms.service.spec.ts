import { TestBed } from '@angular/core/testing';

import { KingdomsService } from './kingdoms.service';

describe('KingdomsService', () => {
  let service: KingdomsService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(KingdomsService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
