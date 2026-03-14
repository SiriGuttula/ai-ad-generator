import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AdGeneratorComponent } from './ad-generator.component';

describe('AdGeneratorComponent', () => {
  let component: AdGeneratorComponent;
  let fixture: ComponentFixture<AdGeneratorComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [AdGeneratorComponent]
    });
    fixture = TestBed.createComponent(AdGeneratorComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
