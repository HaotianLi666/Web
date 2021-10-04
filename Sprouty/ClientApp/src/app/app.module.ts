import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { MDBBootstrapModule } from 'angular-bootstrap-md';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { MDBBootstrapModule } from 'angular-bootstrap-md';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';





//Hello!
=======
import { FooterComponent } from './footer/footer.component';
import { RegisterComponent } from './register/register.component';
import { MyplantsComponent } from './myplants/myplants.component';
import { SigninComponent } from './signin/signin.component';
import { DashboardComponent } from './dashboard/dashboard.component';


@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,

    FooterComponent,
    RegisterComponent,
    MyplantsComponent,
    SigninComponent,
    DashboardComponent

  ],
  imports: [
    MDBBootstrapModule.forRoot(),
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    MDBBootstrapModule.forRoot(),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },

      { path: 'register', component: RegisterComponent },
      { path: 'signin', component: SigninComponent },
      { path: 'myplants', component: MyplantsComponent },
      { path: 'dashboard', component: DashboardComponent },

    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
