import { ComponentFixture, TestBed } from '@angular/core/testing';

import { StarWarsQueryComponent } from './star-wars-query.component';

describe('StarWarsQueryComponent', () => {
  let component: StarWarsQueryComponent;
  let fixture: ComponentFixture<StarWarsQueryComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ StarWarsQueryComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(StarWarsQueryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
