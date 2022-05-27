import { Component, OnInit } from '@angular/core';
import { DeckService } from '../../services/deck.service';
import { Deck } from '../../Deck';

import { faEllipsis } from '@fortawesome/free-solid-svg-icons';

@Component({
  selector: 'app-decks',
  templateUrl: './decks.component.html',
  styleUrls: ['./decks.component.css']
})
export class DecksComponent implements OnInit {
  decks: Deck[] = [];
  faEllipsis = faEllipsis;
  
  constructor(private deckService: DeckService) { }

  ngOnInit(): void {
    this.deckService.getDecks().subscribe(decks => this.decks = decks);
  }
}