import { Component, OnInit } from '@angular/core';
import { QuanLyService } from 'src/app/Services/QuanLy.service';
import {SinhVien} from 'src/app/Models/SinhVien'
@Component({
  selector: 'app-Home',
  templateUrl: './Home.component.html',
  styleUrls: ['./Home.component.css']
})
export class HomeComponent implements OnInit {
  SinhVienList: SinhVien[]=[];
  constructor(private service: QuanLyService) {}

  ngOnInit(): void {
    this.service.getSinhVien().subscribe({
      next:(list)=>{
        this.SinhVienList=list;
        list.forEach(item=>{
          console.log(item)
        })
      }
    })
  }

}
