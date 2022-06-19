import { Component, OnInit, Input } from '@angular/core';
import { Card } from 'src/app/Card';

@Component({
  selector: 'app-card',
  templateUrl: './card.component.html',
  styleUrls: ['./card.component.css']
})
export class CardComponent implements OnInit {
  @Input() id: string;
  @Input() createdDate: string;
  @Input() updatedDate: string;
  @Input() sides: string[];

  constructor() { }

  ngOnInit(): void { }

}
