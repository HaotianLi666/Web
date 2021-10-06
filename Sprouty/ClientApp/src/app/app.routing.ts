import { Routes, RouterModule } from '@angular/router';

import { HomeComponent } from './home';
import { LoginComponent } from './login';
import { RegisterComponent } from './register';
import { DashboardComponent } from './dashboard';
import { AuthGuard } from './helpers';

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
		component: DashboardComponent,
		canActivate: [AuthGuard]
	},
    { 
		path: '**', 
		redirectTo: '' 
	}
];

export const AppRoutingModule = RouterModule.forRoot(routes);