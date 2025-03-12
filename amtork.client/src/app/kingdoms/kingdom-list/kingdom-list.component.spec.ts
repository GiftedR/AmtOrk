import { ComponentFixture, TestBed } from '@angular/core/testing';

import { KingdomListComponent } from './kingdom-list.component';

describe('KingdomListComponent', () => {
  let component: KingdomListComponent;
  let fixture: ComponentFixture<KingdomListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [KingdomListComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(KingdomListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
