import { Component, OnInit } from '@angular/core';
import { faTrashCan, 
  faHardDrive, 
  faSquareCheck, 
  faShareFromSquare, 
  faCircleXmark,
  faRectangleXmark } from '@fortawesome/free-regular-svg-icons';

@Component({
  selector: 'app-action',
  templateUrl: './action.component.html',
  styleUrls: ['./action.component.css']
})
export class ActionComponent implements OnInit {
  faTrashCan = faTrashCan;
  faHardDrive = faHardDrive;
  faSquareCheck = faSquareCheck;
  faShareFromSquare = faShareFromSquare;
  faCircleXmark = faCircleXmark;
  faRectangleXmark = faRectangleXmark;
  selectedCount = 2;

  constructor() { }

  ngOnInit(): void {
  }

}