import { Component, OnDestroy, OnInit } from '@angular/core';
import { AddBook } from '../models/add-book.model';
import { BookService } from '../services/book.service';
import { Router } from '@angular/router';
import { GenreService } from '../../Genres/services/genre.service';
import { Observable, Subscription } from 'rxjs';
import { Genre } from '../../Genres/models/genre.model';
import { ImageService } from 'src/app/shared/components/image-selector/image.service';
import {NgForm} from '@angular/forms';
@Component({
  selector: 'app-add-book',
  templateUrl: './add-book.component.html',
  styleUrls: ['./add-book.component.css'],
})
export class AddBookComponent implements OnInit, OnDestroy {
  model: AddBook;
  isImageSelectorVisible: boolean = false;
  genres$?: Observable<Genre[]>;

  imageSelectorSubscription?: Subscription;

  constructor(
    private bookService: BookService,
    private router: Router,
    private genreService: GenreService,
    private imageService: ImageService
  ) {
    this.model = {
      name: '',
      description: '',
      urlHandle: '',
      featuredImageUrl: '',
      author: '',
      isAvailable: true,
      genres: []
      // rating: 0,
    };
  }

  ngOnInit(): void {
    this.genres$ = this.genreService.getAllGenres();

    this.imageSelectorSubscription = this.imageService
      .onSelectImage()
      .subscribe({
        next: (response) => {
          this.model.featuredImageUrl = response.url;
          this.closeImageSelector();
        },
      });
  }

  onFormSubmit(form: NgForm): void {
    // console.log(this.model);
    this.bookService.createBook(this.model).subscribe({
      next: (response) => {
        this.router.navigateByUrl('/admin/books');
      },
    });
  }

  openImageSelector(): void {
    this.isImageSelectorVisible = true;
  }

  closeImageSelector(): void {
    this.isImageSelectorVisible = false;
  }
  ngOnDestroy(): void {
    this.imageSelectorSubscription?.unsubscribe();
  }
}
