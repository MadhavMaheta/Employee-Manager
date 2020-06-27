import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { LoginComponent } from './login/login.component';
import { EmployeeComponent } from './employees/employee/employee.component';
import { EmployeesComponent } from './employees/employees.component';
import { RegisterComponent } from './register/register.component';

const routes: Routes = [
  {    
    path: '',    
    redirectTo: 'login',    
    pathMatch: 'full',    
  },    
  {    
    path: 'login',    
    component: LoginComponent,    
    data: {    
      title: 'Login Page'    
    }    
  },    
  {    
    path: 'Dashboard',    
    component: EmployeesComponent,    
    data: {    
      title: 'Dashboard Page'    
    }    
  },         
  {    
    path: 'AddUser',    
    component: RegisterComponent,    
    data: {    
      title: 'Add User Page'    
    }    
  },
 
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
