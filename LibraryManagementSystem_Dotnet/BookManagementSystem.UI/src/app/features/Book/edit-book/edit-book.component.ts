import { Component, OnDestroy, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Observable, Subscription } from 'rxjs';
import { BookService } from '../services/book.service';
import { Book } from '../models/book.model';
import { GenreService } from '../../Genres/services/genre.service';
import { Genre } from '../../Genres/models/genre.model';
import { UpdateBook } from '../models/update-book.model';
import { ImageService } from 'src/app/shared/components/image-selector/image.service';
import { RouterModule } from '@angular/router';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-edit-book',
  templateUrl: './edit-book.component.html',
  styleUrls: ['./edit-book.component.css'],
})
export class EditBookComponent implements OnInit, OnDestroy {
  id: string | null = null;
  model?: Book;
  genres$?: Observable<Genre[]>;
  selectedGenres?: string[];
  isImageSelectorVisible: boolean = false;

  routeSubscription?: Subscription;
  updateBookSubscription?: Subscription;
  getBookSubscription?: Subscription;
  deleteBookSubscription?: Subscription;
  imageSelectSubscription?: Subscription;

  constructor(
    private route: ActivatedRoute,
    private bookService: BookService,
    private genreService: GenreService,
    private router: Router,
    private imageService: ImageService
  ) {}

  ngOnInit(): void {
    this.genres$ = this.genreService.getAllGenres();

    this.routeSubscription = this.route.paramMap.subscribe({
      next: (params) => {
        this.id = params.get('id');

        //get books from the API
        if (this.id) {
          this.getBookSubscription = this.bookService
            .getBookById(this.id)
            .subscribe({
              next: (response) => {
                this.model = response;
                this.selectedGenres = response.genres.map((x) => x.id);
              },
            });
        }
        this.imageSelectSubscription = this.imageService
          .onSelectImage()
          .subscribe({
            next: (response) => {
              if (this.model) {
                this.model.featuredImageUrl = response.url;
                this.isImageSelectorVisible = false;
              }
            },
          });
      },
    });
  }

  onFormSubmit(): void {
    //convert this model to request object
    if (this.model && this.id) {
      var updateBook: UpdateBook = {
        author: this.model.author,
        description: this.model.description,
        featuredImageUrl: this.model.featuredImageUrl,
        isAvailable: this.model.isAvailable,
        name: this.model.name,
        urlHandle: this.model.urlHandle,
        genres: this.selectedGenres ?? [],
      };

      this.updateBookSubscription = this.bookService
        .updateBook(this.id, updateBook)
        .subscribe({
          next: (response) => {
            this.router.navigateByUrl('/admin/books');
          },
        });
    }
  }

  onDelete(): void {
    if (this.id) {
      // call service and delete blogpost
      this.deleteBookSubscription = this.bookService
        .deleteBook(this.id)
        .subscribe({
          next: (response) => {
            this.router.navigateByUrl('/admin/books');
          },
        });
    }
  }

  openImageSelector(): void {
    this.isImageSelectorVisible = true;
  }

  closeImageSelector(): void {
    this.isImageSelectorVisible = false;
  }

  ngOnDestroy(): void {
    this.routeSubscription?.unsubscribe();
    this.updateBookSubscription?.unsubscribe();
    this.getBookSubscription?.unsubscribe();
    this.deleteBookSubscription?.unsubscribe();
    this.imageSelectSubscription?.unsubscribe();
  }
}
