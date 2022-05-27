import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-input',
  templateUrl: './input.component.html',
  styleUrls: ['./input.component.css']
})
export class InputComponent implements OnInit {
  @Input() type: InputType;
  @Input() name: string;
  @Input() label: string;

  constructor() { }

  ngOnInit(): void {
  }

}

export enum InputType {
  Text = 'text',
}