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

  constructor(private cardService: CardService, private route: ActivatedRoute) { 
    this.route.params.subscribe( params => this.deckId = params['deckId'] );
  }

  ngOnInit(): void {
    console.log("Logging now.");
    console.log(this.deckId);
  }

}
