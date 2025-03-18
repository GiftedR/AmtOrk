import { ComponentFixture, TestBed } from '@angular/core/testing';

import { KingdomEditComponent } from './kingdom-edit.component';

describe('KingdomEditComponent', () => {
  let component: KingdomEditComponent;
  let fixture: ComponentFixture<KingdomEditComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [KingdomEditComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(KingdomEditComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
