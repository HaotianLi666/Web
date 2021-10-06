import { Component, OnInit } from '@angular/core';
import { User } from '../models';
import { AuthenticationService } from '../services/index';

@Component({
  selector: 'app-dash',
  templateUrl: './dashboard.component.html'

})
export class DashboardComponent implements OnInit {
  currentUser: User;

  constructor(private authService: AuthenticationService) {
    this.currentUser = this.authService.currentUserValue;
  }

  ngOnInit() { }
}
