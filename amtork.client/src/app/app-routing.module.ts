import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { KingdomListComponent } from './kingdoms/kingdom-list/kingdom-list.component';
import { KingdomDetailComponent } from './kingdoms/kingdom-detail/kingdom-detail.component';

const routes: Routes = [
  { path:'', pathMatch:'full', component: HomeComponent },
  { path:'kingdoms', component: KingdomListComponent },
  { path:'kingdoms/:name', component: KingdomDetailComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule {
}
