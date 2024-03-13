import { Component, OnInit } from '@angular/core';
import { BookService } from '../../Book/services/book.service';
import { Observable } from 'rxjs';
import { Book } from '../../Book/models/book.model';


@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css'],
})
export class HomeComponent implements OnInit {
  books$?: Observable<Book[]>;
  books: Book[] = [];
  searchInput: string = '';
  filteredBooks?: Book[];

  constructor(private bookService: BookService) {}
  ngOnInit(): void {
    this.books$ = this.bookService.getAllBooks();
    this.bookService.getAllBooks()
    .subscribe({
      next: (response) => {
        this.books = response;
        this.filteredBooks = this.books;
      }
    });
  }

  search() {
    if (this.searchInput.trim() === '') {
      // If searchInput is empty, display all books
      this.filteredBooks = this.books;
    } else {
      // Filter books based on searchInput
      this.filteredBooks = this.books.filter(book =>
        book.name.toLowerCase().includes(this.searchInput.toLowerCase()) ||
        book.author.toLowerCase().includes(this.searchInput.toLowerCase())
      );
    }
  
  }
}
