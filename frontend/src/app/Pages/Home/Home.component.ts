import { Component, OnInit } from '@angular/core';
import { QuanLyService } from 'src/app/Services/QuanLy.service';
import {Khoa} from 'src/app/Models/Khoa'
@Component({
  selector: 'app-Home',
  templateUrl: './Home.component.html',
  styleUrls: ['./Home.component.css']
})
export class HomeComponent implements OnInit {
  KhoaList: Khoa[]=[];
  constructor(private service: QuanLyService) {}

  ngOnInit(): void {
    this.service.getKhoa().subscribe({
      next:(list)=>{
        this.KhoaList=list;
        list.forEach(item=>{
          console.log(item)
        })
      }
    })
  }

}
