import { Injectable } from '@angular/core';
import { AddGenreRequest } from '../models/add-genre-request.model';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { Genre } from '../models/genre.model';
import { environment } from 'src/environments/environment.development';
import { UpdateGenreRequest } from '../models/update-genre-request.model';
import { CookieService } from 'ngx-cookie-service';

@Injectable({
  providedIn: 'root'
})
export class GenreService {

  constructor(private http: HttpClient,
    private cookieService: CookieService) { }

  addGenre(model: AddGenreRequest): Observable<void> {
    return this.http.post<void>(`${environment.apiBaseUrl}/api/Genres?addAuth=true`, model);
  }

  getAllGenres(): Observable<Genre[]>{
    return this.http.get<Genre[]>(`${environment.apiBaseUrl}/api/Genres`);
  }

  getGenreById(id: string): Observable<Genre>{
    return this.http.get<Genre>(`${environment.apiBaseUrl}/api/Genres/${id}`);
  }

  updateGenre(id: string, updateGenreRequest: UpdateGenreRequest): Observable<Genre>{
    return this.http.put<Genre>(`${environment.apiBaseUrl}/api/Genres/${id}?addAuth=true`,updateGenreRequest);
  }

  deleteGenre(id: string) : Observable<Genre> {
    return this.http.delete<Genre>(`${environment.apiBaseUrl}/api/Genres/${id}?addAuth=true`)
  }
}
