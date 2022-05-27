import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavComponent } from './components/nav/nav.component';
import { ButtonComponent } from './components/button/button.component';
import { InputComponent } from './components/input/input.component';
import { DecksComponent } from './components/decks/decks.component';
import { DeckComponent } from './components/deck/deck.component';
import { ActionComponent } from './components/action/action.component';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { LoginComponent } from './components/login/login.component';
import { RegisterComponent } from './components/register/register.component';
import { SummaryComponent } from './components/summary/summary.component';
import { ProfileComponent } from './components/profile/profile.component';
import { SharingComponent } from './components/sharing/sharing.component';
import { TimelineComponent } from './components/timeline/timeline.component';
import { CardsComponent } from './components/cards/cards.component';
import { CardComponent } from './components/card/card.component';

@NgModule({
  declarations: [
    AppComponent,
    NavComponent,
    ButtonComponent,
    InputComponent,
    DecksComponent,
    DeckComponent,
    ActionComponent,
    LoginComponent,
    RegisterComponent,
    SummaryComponent,
    ProfileComponent,
    SharingComponent,
    TimelineComponent,
    CardsComponent,
    CardComponent
  ],
  imports: [
    BrowserModule,  
    AppRoutingModule,
    HttpClientModule,
    FontAwesomeModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
