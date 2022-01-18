import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CarroNavbarComponent } from './carro-navbar.component';

describe('CarroNavbarComponent', () => {
  let component: CarroNavbarComponent;
  let fixture: ComponentFixture<CarroNavbarComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CarroNavbarComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CarroNavbarComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
