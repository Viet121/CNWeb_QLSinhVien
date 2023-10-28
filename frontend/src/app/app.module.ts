import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './Pages/Home/Home.component';
import {HttpClientModule} from '@angular/common/http';
import { AdminStudentComponent } from './Pages/Admin/admin-student/admin-student.component'

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    AdminStudentComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
