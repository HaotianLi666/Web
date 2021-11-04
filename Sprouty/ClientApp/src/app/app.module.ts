import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { MDBBootstrapModule } from 'angular-bootstrap-md';
import { HttpClientModule } from '@angular/common/http';
import { RepositoryService } from './services/repository.service';
import { AppComponent } from './app.component';
import { NavMenuComponent } from './components/nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { FooterComponent } from './footer/footer.component';
import { RegisterComponent } from './register/register.component';
import { MyplantsComponent } from './myplants/myplants.component';
import { SigninComponent } from './signin/signin.component';
import { DashboardComponent } from './dashboard/dashboard.component'
import { AlertComponent } from './components/alert';
import { LoginComponent } from './login';
import { AppRoutingModule } from './app.routing';
import { RouterModule } from '@angular/router';


@NgModule({
  declarations: [
    DashboardComponent,
    AppComponent,
    HomeComponent,
    NavMenuComponent,
    FooterComponent,
    AlertComponent,
    LoginComponent,
    RegisterComponent,
    FooterComponent,
    RegisterComponent,
    MyplantsComponent,
    SigninComponent,
    DashboardComponent

  ],
  imports: [
    ReactiveFormsModule,
    AppRoutingModule,
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
  providers: [
    RepositoryService
  ],
  bootstrap: [
    AppComponent
  ]
})
export class AppModule { }
