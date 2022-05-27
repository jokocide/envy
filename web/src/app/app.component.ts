import { Component } from '@angular/core';
import { InputType } from './components/input/input.component';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title: string = 'web';
  inputType = InputType.Text;
}
