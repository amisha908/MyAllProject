import { Component, OnInit } from '@angular/core';
import { GenreService } from '../services/genre.service';
import { Genre } from '../models/genre.model';

@Component({
  selector: 'app-genres-list',
  templateUrl: './genres-list.component.html',
  styleUrls: ['./genres-list.component.css']
})
export class GenresListComponent implements OnInit {

  genres?: Genre[];
  // genres?: any;

  
  constructor(private genreService: GenreService) {

  }
  ngOnInit(): void {
    this.genreService.getAllGenres()
    .subscribe({
      next: (response) => {
        // console.log(response);
        this.genres = response;
        console.log(this.genres);
      }
    });
  }
}
