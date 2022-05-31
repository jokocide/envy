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
  cards: Card[] = [];

  constructor(
    private cardService: CardService, 
    private activatedRoute: ActivatedRoute,
    ) { }

  ngOnInit(): void {
    this.activatedRoute.params.subscribe(params => {
      this.cardService.getCards(params['deckId']).subscribe(cards => {
        this.cards = cards;
      }, error => {
        if (error.error.status === 404) {
          this.cards = [];
        } else {
          console.log(error.error);
        }
      });
    })
  }

}
