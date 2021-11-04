import { Routes, RouterModule } from '@angular/router';

import { HomeComponent } from './components/home';
import { LoginComponent } from './components/login';
import { RegisterComponent } from './components/register';
import { DashboardComponent } from './components/dashboard'
import { AuthGuard } from './helpers';
import { MyplantsComponent } from './components/myplants/myplants.component';


const routes: Routes = [
    { 
		path: '',
		component: HomeComponent		
	},
    { 
		path: 'login',
		component: LoginComponent
	},
    { 
		path: 'register',
		component: RegisterComponent
	},
	{
		path: 'dashboard',
		component: DashboardComponent
		//canActivate: [AuthGuard]
	},
	{
		path: 'myplants',
		component: MyplantsComponent
	},
    { 
		path: '**', 
		redirectTo: '' 
	}
];

export const AppRoutingModule = RouterModule.forRoot(routes);