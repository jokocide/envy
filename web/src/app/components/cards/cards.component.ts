import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from "@angular/router";
import { CardService } from 'src/app/services/card.service';
import { Card } from '../../Card';

@Component({
  selector: 'app-cards',
  templateUrl: './cards.component.html',
  styleUrls: ['./cards.component.css']
})
export class CardsComponent implements OnInit {
  deckId: string;
  cards: Card[];

  constructor(private cardService: CardService, private activatedRoute: ActivatedRoute) { 
    this.activatedRoute.paramMap.subscribe( params => {

      // Deck ID will not (should not) be null, so use non-null assertion.
      this.deckId = params.get('deckId')!;
    } );
  }

  ngOnInit(): void {
    this.cardService.getCards(this.deckId).subscribe(cards => this.cards = cards);
  }

}
