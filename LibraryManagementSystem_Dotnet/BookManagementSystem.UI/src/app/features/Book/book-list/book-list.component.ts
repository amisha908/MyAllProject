import { Component, OnInit } from '@angular/core';
import { BookService } from '../services/book.service';
import { Observable, filter } from 'rxjs';
import { Book } from '../models/book.model';
import { CookieService } from 'ngx-cookie-service';
import { jwtDecode } from "jwt-decode";
import { Inject } from '@angular/core';


@Component({
  selector: 'app-book-list',
  templateUrl: './book-list.component.html',
  styleUrls: ['./book-list.component.css']
})
export class BookListComponent implements OnInit {

  // books$? : Observable<Book[]>; 
  userId: string = '';
  books: Book[] = [];
  filteredBooks?: Book[];
  searchInput: string = '';

  constructor(private bookService: BookService,
    @Inject('cookieService') private cookieService: any){
  }
  

  ngOnInit(): void {
    //get all books from the API
    // this.books$ = this.bookService.getAllBooks();
    let token = this.cookieService.get('Authorization');
    // console.log(token)
    token = token.slice(6,token.length);
    var payload = JSON.parse(window.atob(token.split('.')[1]));
    this.userId = payload.UserID;
    // console.log(payload.UserID)
      // if (token) {
      //   var decodedToken = jwtDecode(token);
      //   // console.log(decodedToken);
      //   // this.userId = decodedToken.
      // }
    this.bookService.getAllBooks()
    .subscribe({
      next: (response) => {
        this.books = response;
        // console.log(this.books);
        // this.books.forEach(b => {
        //   console.log(b.lentByUserId);
        // });
        // console.log("\n ######");
        // console.log(this.userId);
        this.filteredBooks = this.books.filter(book => book.lentByUserId == this.userId)
        // console.log(this.filteredBooks);
      }
    });
  }

  search() {
    if (this.searchInput.trim() === '') {
      // If searchInput is empty, display all books
      this.filteredBooks = this.books.filter(book => book.lentByUserId == this.userId);
    } else {
      // Filter books based on searchInput
      this.filteredBooks = this.books.filter(book => book.lentByUserId == this.userId).filter(book =>
        book.name.toLowerCase().includes(this.searchInput.toLowerCase()) ||
        book.author.toLowerCase().includes(this.searchInput.toLowerCase())
      );
    }
  }

}
