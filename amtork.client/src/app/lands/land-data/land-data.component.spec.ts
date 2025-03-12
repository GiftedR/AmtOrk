import { ComponentFixture, TestBed } from '@angular/core/testing';

import { LandDataComponent } from './land-data.component';

describe('LandDataComponent', () => {
  let component: LandDataComponent;
  let fixture: ComponentFixture<LandDataComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [LandDataComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(LandDataComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
