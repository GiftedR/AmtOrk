import { ComponentFixture, TestBed } from '@angular/core/testing';

import { LandEditComponent } from './land-edit.component';

describe('LandEditComponent', () => {
  let component: LandEditComponent;
  let fixture: ComponentFixture<LandEditComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [LandEditComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(LandEditComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
