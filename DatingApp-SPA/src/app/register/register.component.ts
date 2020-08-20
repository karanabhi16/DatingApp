import { Component, OnInit, EventEmitter, Output } from '@angular/core';
import { AuthService } from '../_services/auth.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.scss']
})
export class RegisterComponent implements OnInit {

  @Output() cancelReg = new EventEmitter();
  model: any = {};

  constructor(private authService: AuthService) { }

  // tslint:disable-next-line: typedef
  ngOnInit() {
  }

  // tslint:disable-next-line: typedef
  register()
  {
    this.authService.register(this.model).subscribe(() => {
      console.log('Registration Successful.');
    }, error => {
      console.log(error);
    });
  }
  // tslint:disable-next-line: typedef
  cancel(){
    this.cancelReg.emit(false);
    console.log('cancelled');
  }

}
