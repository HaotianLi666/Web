//Modules
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { MDBBootstrapModule } from 'angular-bootstrap-md';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { AppRoutingModule } from './app.routing';
//Components
import { AppComponent } from './app.component';
import { NavMenuComponent } from './components/nav-menu/nav-menu.component';
import { HomeComponent } from './components/home/home.component';
import { FooterComponent } from './components/footer/footer.component';
import { RegisterComponent } from './components/register/register.component';
import { DashboardComponent } from './components/dashboard/dashboard.component'
import { AlertComponent } from './components/alert';
import { LoginComponent } from './components/login/login.component';
import { MyplantsComponent } from './components/myplants/myplants.component';
import { AddPlantsComponent } from './components/myplants/add-plants/add-plants.component';
import { ButtonComponent } from './components/myplants/button/button.component';
//Services
import { RepositoryService } from './services/repository.service';


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
    AddPlantsComponent,
    ButtonComponent

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
      { path: 'add-plants', component: AddPlantsComponent},
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
