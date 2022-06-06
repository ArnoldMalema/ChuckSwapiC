import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ChuckNorrisQueryComponent } from './chuck-norris-query.component';

describe('ChuckNorrisQueryComponent', () => {
  let component: ChuckNorrisQueryComponent;
  let fixture: ComponentFixture<ChuckNorrisQueryComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ChuckNorrisQueryComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ChuckNorrisQueryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
