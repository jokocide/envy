import { Component, OnInit } from '@angular/core';
import { DeckService } from '../../services/deck.service';
import { Deck } from '../../Deck';

@Component({
  selector: 'app-decks',
  templateUrl: './decks.component.html',
  styleUrls: ['./decks.component.css']
})
export class DecksComponent implements OnInit {
  decks: Deck[] = [];
  buttonTextControl: boolean = true
  visibleControl: boolean = true;
  visibleClasses: string = "decks-container-common decks-container";
  hiddenClasses: string = "decks-container-common decks-container-hidden";
  
  constructor(private deckService: DeckService) { }

  ngOnInit(): void {
    this.deckService.getDecks().subscribe(decks => this.decks = decks);
  }

  handleMoreButtonClick() {
    this.visibleControl = !this.visibleControl;
    this.buttonTextControl = !this.buttonTextControl;
  }
}