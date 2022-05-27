import { Component, OnInit, Input } from '@angular/core';
import { Deck } from 'src/app/Deck';

@Component({
  selector: 'app-deck',
  templateUrl: './deck.component.html',
  styleUrls: ['./deck.component.css']
})
export class DeckComponent implements OnInit {
  @Input() deck: Deck;

  constructor() { }

  ngOnInit(): void {
  }

}
