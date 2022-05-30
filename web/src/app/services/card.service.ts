import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Card } from '../Card';

@Injectable({
  providedIn: 'root'
})
export class CardService {
  private apiUrl = 'http://localhost:5050/api/Cards/from/'

  constructor(private http: HttpClient) { }

  getCards(deckId: string): Observable<Card[]> {
    let fullUrl = (this.apiUrl + deckId);
    return this.http.get<Card[]>(fullUrl);
  }
}
