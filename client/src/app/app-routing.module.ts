import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { DetailsComponent } from './details/details.component';

const routes: Routes = [
  { path: '', component: HomeComponent, title: 'Home page' },
  { path: 'details/:id', component: DetailsComponent, title: 'Home details ' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
