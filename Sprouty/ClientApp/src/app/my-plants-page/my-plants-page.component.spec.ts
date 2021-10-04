import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MyPlantsPageComponent } from './my-plants-page.component';

describe('MyPlantsPageComponent', () => {
  let component: MyPlantsPageComponent;
  let fixture: ComponentFixture<MyPlantsPageComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MyPlantsPageComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MyPlantsPageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
