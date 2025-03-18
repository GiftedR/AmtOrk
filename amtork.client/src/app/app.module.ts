import { provideHttpClient } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavbarComponent } from './navbar/navbar.component';
import { HomeComponent } from './home/home.component';
import { KingdomListComponent } from './kingdoms/kingdom-list/kingdom-list.component';
import { KingdomDetailComponent } from './kingdoms/kingdom-detail/kingdom-detail.component';
import { LandListComponent } from './lands/land-list/land-list.component';
import { LandDataComponent } from './lands/land-data/land-data.component';
import { FooterComponent } from './footer/footer.component';

@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent,
    HomeComponent,
    KingdomListComponent,
    KingdomDetailComponent,
    LandListComponent,
    LandDataComponent,
    FooterComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [
    provideHttpClient()
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
