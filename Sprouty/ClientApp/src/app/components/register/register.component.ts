import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { 
    AlertService, 
    RepositoryService, 
    AuthenticationService 
} from '../../services';
import { environment as env } from '../../../environments/environment';

@Component({ templateUrl: 'register.component.html' })
export class RegisterComponent implements OnInit {
    registerForm: FormGroup;
    loading = false;
    submitted = false;

    constructor(
        private formBuilder: FormBuilder,
        private router: Router,
        private authenticationService: AuthenticationService,
        private repository: RepositoryService,
        private alertService: AlertService
    ) {
        // redirect to home if already logged in
        if (this.authenticationService.currentUserValue) {
            this.router.navigate(['/']);
        }
    }

    ngOnInit() {
        this.registerForm = this.formBuilder.group({
            emailAddress: [ '', Validators.required ],
            userId:       [ '', Validators.required ],
            password:     [ '', [ 
                Validators.required, 
                Validators.minLength(8) 
            ]]
        });
    }

    // convenience getter for easy access to form fields
    get f() { 
        return this.registerForm.controls; 
    }

    onSubmit() {
        this.submitted = true;

        // reset alerts on submit
        this.alertService.clear();

        // stop here if form is invalid
        if (this.registerForm.invalid) {
            return;
        }
        
        this.loading = true;

        // register the user in the database
        this.repository.post(env.urls['register'], this.registerForm.value).subscribe(response => {
                this.alertService.success('Registration successful', true);
                this.router.navigate(['/login']);
            },
            error => {
                this.alertService.error(error);
                this.loading = false;
        });
    }
}
