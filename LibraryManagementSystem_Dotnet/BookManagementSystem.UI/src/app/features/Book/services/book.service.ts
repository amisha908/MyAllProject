import { Injectable } from '@angular/core';
import { AddBook } from '../models/add-book.model';
import { Observable } from 'rxjs';
import { Book } from '../models/book.model';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment.development';
import { UpdateBook } from '../models/update-book.model';

@Injectable({
  providedIn: 'root',
})
export class BookService {
  constructor(private http: HttpClient) {}

  createBook(data: AddBook): Observable<Book> {
    return this.http.post<Book>(`${environment.apiBaseUrl}/api/books?addAuth=true`, data);
  }

  getAllBooks(): Observable<Book[]> {
    return this.http.get<Book[]>(`${environment.apiBaseUrl}/api/books`);
  }

  getBookById(id: string): Observable<Book> {
    return this.http.get<Book>(`${environment.apiBaseUrl}/api/books/${id}`);
  }

  getBookByUrlHandle(urlHandle: string): Observable<Book> {
    return this.http.get<Book>(`${environment.apiBaseUrl}/api/books/${urlHandle}`);
  }

  updateBook(id: string, updatedBook: UpdateBook): Observable<Book>{
    return this.http.put<Book>(`${environment.apiBaseUrl}/api/books/${id}?addAuth=true`,updatedBook);
  }

  deleteBook(id: string): Observable<Book> {
    return this.http.delete<Book>(`${environment.apiBaseUrl}/api/books/${id}?addAuth=true`);
  }

  borrowBook(id: string): Observable<any> {
    return this.http.post<any>(`${environment.apiBaseUrl}/api/books/BorrowBook/${id}?addAuth=true`, {});
  }

}
