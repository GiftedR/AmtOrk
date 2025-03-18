import { ComponentFixture, TestBed } from '@angular/core/testing';

import { KingdomListEditComponent } from './kingdom-list-edit.component';

describe('KingdomListEditComponent', () => {
  let component: KingdomListEditComponent;
  let fixture: ComponentFixture<KingdomListEditComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [KingdomListEditComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(KingdomListEditComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
