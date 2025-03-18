import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { KingdomListComponent } from './kingdoms/kingdom-list/kingdom-list.component';
import { KingdomDetailComponent } from './kingdoms/kingdom-detail/kingdom-detail.component';
import { LandDataComponent } from './lands/land-data/land-data.component';
import { KingdomEditComponent } from './kingdoms/kingdom-edit/kingdom-edit.component';
import { LandEditComponent } from './lands/land-edit/land-edit.component';
import { KingdomCreateComponent } from './kingdoms/kingdom-create/kingdom-create.component';
import { LandCreateComponent } from './lands/land-create/land-create.component';
import { KingdomListEditComponent } from './kingdoms/kingdom-list-edit/kingdom-list-edit.component';

const routes: Routes = [
  { path:'', pathMatch:'full', component: HomeComponent },
  { path:'kingdoms', component: KingdomListComponent },
  { path:'kingdoms/create', component: KingdomCreateComponent },
  { path:'kingdoms/edit', component: KingdomListEditComponent },
  { path:'kingdoms/:kingdomName', component: KingdomDetailComponent },
  { path:'kingdoms/:kingdomName/create', component:LandCreateComponent },
  { path:'kingdoms/:kingdomName/edit', component: KingdomEditComponent },
  { path:'kingdoms/:kingdomName/:land', component: LandDataComponent },
  { path:'kingdoms/:kingdomName/:land/edit', component: LandEditComponent },
  { path:'kingdoms/:kingdomName/:land/create', redirectTo: 'kingdoms/:kingdomName/:land/edit' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule {
}
