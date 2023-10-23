import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Khoa } from '../Models/Khoa';

@Injectable({
  providedIn: 'root'
})
export class QuanLyService {

  constructor(private httpClient: HttpClient) { }

  getKhoa(){
    return this.httpClient.get<Khoa[]>("http://localhost:5231/Home/Get");
  }
}
