import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { MDBBootstrapModule } from 'angular-bootstrap-md';
import { HttpClientModule } from '@angular/common/http';
import { RepositoryService } from './services/repository.service';
import { AppComponent } from './app.component';
import { NavMenuComponent } from './components/nav-menu/nav-menu.component';
import { HomeComponent } from './components/home/home.component';
import { FooterComponent } from './components/footer/footer.component';
import { RegisterComponent } from './components/register/register.component';
import { DashboardComponent } from './components/dashboard/dashboard.component'
import { AlertComponent } from './components/alert';
import { LoginComponent } from './components/login';
import { AppRoutingModule } from './app.routing';
import { RouterModule } from '@angular/router';
import { MyplantsComponent } from './components/myplants/myplants.component';
import { AddPlantsComponent } from './components/myplants/add-plants/add-plants.component';


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
    DashboardComponent,
    MyplantsComponent,
    AddPlantsComponent

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
      { path: 'login', component: LoginComponent },
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
