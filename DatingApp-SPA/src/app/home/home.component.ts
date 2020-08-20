import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent implements OnInit {
  toRegister = false;

  constructor(private http: HttpClient) { }

  // tslint:disable-next-line: typedef
  ngOnInit() {
  }

  // tslint:disable-next-line: typedef
  registerToggle()
  {
    this.toRegister = true;
  }

  // tslint:disable-next-line: typedef
  cancelRegMode(toRegister: boolean){
    this.toRegister = toRegister;
  }
}
