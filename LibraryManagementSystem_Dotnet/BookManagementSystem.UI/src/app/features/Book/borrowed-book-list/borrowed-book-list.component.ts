import { Component, Inject, OnInit } from '@angular/core';
import { Book } from '../models/book.model';
import { BookService } from '../services/book.service';
import { CookieService } from 'ngx-cookie-service';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-borrowed-book-list',
  templateUrl: './borrowed-book-list.component.html',
  styleUrls: ['./borrowed-book-list.component.css']
})
export class BorrowedBookListComponent implements OnInit {

  userId: string = '';
  books?: Book[];
  filteredBooks?: Book[];

  constructor(private bookService: BookService,
    @Inject('cookieService') private cookieService: any){
  }

  ngOnInit(): void {
    //get all books from the API

    let token = this.cookieService.get('Authorization');

    token = token.slice(6,token.length);
    var payload = JSON.parse(window.atob(token.split('.')[1]));
    this.userId = payload.UserID;

    this.bookService.getAllBooks()
    .subscribe({
      next: (response) => {
        this.books = response;
        this.filteredBooks = this.books.filter(book => book.currentlyBorrowedByUserId == this.userId)
      }
    });
  }

  onClick(id: string) {
    this.bookService.borrowBook(id)
    .subscribe({
      next: (response) => {
        localStorage.setItem('tokensAvailable', response.toString());
        Swal.fire('Book Returned Successfully').then(()=>{location.reload()});
      }
    }
    );
  }

}
