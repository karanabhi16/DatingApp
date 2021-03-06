import { Component, OnInit } from '@angular/core';
import { AuthService } from './_services/auth.service';
import {JwtHelperService} from '@auth0/angular-jwt';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit{
  title = 'Dating App';
  jwtHelper = new JwtHelperService();

  constructor(private authService: AuthService) {}

  // tslint:disable-next-line: typedef
  ngOnInit() {
    const token = localStorage.getItem('token');
    if (token)
    {
      this.authService.tokenDecode = this.jwtHelper.decodeToken(token);
    }
  }
}
