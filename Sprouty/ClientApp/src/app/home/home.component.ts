import { Component, OnInit } from '@angular/core';
import { User } from '../models';
import { AuthenticationService } from '../services/index';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html'

})
export class HomeComponent implements OnInit {
  currentUser: User;

  constructor(private authService: AuthenticationService) {
    this.currentUser = this.authService.currentUserValue;
  }

  ngOnInit() { }
}
