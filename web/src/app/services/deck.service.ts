import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Deck } from '../Deck';

@Injectable({
  providedIn: 'root'
})
export class DeckService {
  private apiUrl = 'http://localhost:5050/api/Decks'

  constructor(private http: HttpClient) { }

  getDecks(): Observable<Deck[]> {
    return this.http.get<Deck[]>(this.apiUrl);
  }
}
