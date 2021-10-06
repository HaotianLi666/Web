import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { MDBBootstrapModule } from 'angular-bootstrap-md';
import { RepositoryService } from './services/repository.service';
import { AppComponent } from './app.component';
import { NavMenuComponent } from './components/nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { FooterComponent } from './footer/footer.component';
import { BackgroundComponent } from './background/background.component';
import { AlertComponent } from './components/alert';
import { AppRoutingModule } from './app.routing';
import { LoginComponent } from './login';
import { RegisterComponent } from './register';
import { DashboardComponent } from './dashboard';

@NgModule({
  declarations: [
    DashboardComponent,
    AppComponent,
    HomeComponent,
    NavMenuComponent,
    CounterComponent,
    FetchDataComponent,
    FooterComponent,
    BackgroundComponent,
    AlertComponent,
    LoginComponent,
    RegisterComponent,
  ],
  imports: [
    ReactiveFormsModule,
    AppRoutingModule,
    MDBBootstrapModule.forRoot(),
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
  ],
  providers: [
    RepositoryService
  ],
  bootstrap: [
    AppComponent
  ]
})
export class AppModule { }
