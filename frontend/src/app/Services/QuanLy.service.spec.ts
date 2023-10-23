/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { QuanLyService } from './QuanLy.service';

describe('Service: QuanLy', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [QuanLyService]
    });
  });

  it('should ...', inject([QuanLyService], (service: QuanLyService) => {
    expect(service).toBeTruthy();
  }));
});
