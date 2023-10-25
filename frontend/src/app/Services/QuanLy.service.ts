import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { SinhVien } from '../Models/SinhVien';

@Injectable({
  providedIn: 'root'
})
export class QuanLyService {

  constructor(private httpClient: HttpClient) { }

  getSinhVien(){
    return this.httpClient.get<SinhVien[]>("http://localhost:5183/Home/action");
  }
}
