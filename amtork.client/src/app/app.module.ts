import { provideHttpClient } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavbarComponent } from './navbar/navbar.component';
import { HomeComponent } from './home/home.component';
import { KingdomListComponent } from './kingdoms/kingdom-list/kingdom-list.component';
import { KingdomDetailComponent } from './kingdoms/kingdom-detail/kingdom-detail.component';
import { LandDataComponent } from './lands/land-data/land-data.component';
import { FooterComponent } from './footer/footer.component';
import { LandEditComponent } from './lands/land-edit/land-edit.component';
import { KingdomEditComponent } from './kingdoms/kingdom-edit/kingdom-edit.component';
import { KingdomCreateComponent } from './kingdoms/kingdom-create/kingdom-create.component';
import { LandCreateComponent } from './lands/land-create/land-create.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent,
    HomeComponent,
    KingdomListComponent,
    KingdomDetailComponent,
    LandDataComponent,
    FooterComponent,
    LandEditComponent,
    KingdomEditComponent,
    KingdomCreateComponent,
    LandCreateComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    ReactiveFormsModule
  ],
  providers: [
    provideHttpClient()
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
