import { Component, OnDestroy, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Subscription } from 'rxjs';
import { GenreService } from '../services/genre.service';
import { Genre } from '../models/genre.model';
import { UpdateGenreRequest } from '../models/update-genre-request.model';

@Component({
  selector: 'app-edit-genre',
  templateUrl: './edit-genre.component.html',
  styleUrls: ['./edit-genre.component.css']
})
export class EditGenreComponent implements OnInit, OnDestroy {

  id: string | null = null;
  paramsSubscription? : Subscription;
  genre?: Genre;
  editGenreSubscription? : Subscription;

  constructor(private route: ActivatedRoute, private genreService: GenreService, private router: Router){

  }
  

  ngOnInit(): void {
    this.paramsSubscription = this.route.paramMap.subscribe({
      next: (params) => {
        this.id = params.get('id');

        if(this.id){
          //get the data from the api for this genre id
          this.genreService.getGenreById(this.id)
          .subscribe({
            next: (response) => {
              this.genre = response;
            }
          });
        }

      }
    });
  }


  onFormSubmit(): void {
    // console.log(this.genre);
    const updateGenreRequest: UpdateGenreRequest = {
      name: this.genre?.name ?? '',
      urlHandle: this.genre?.urlHandle ?? ''
    };

    //pass this object to service
    if(this.id){
      this.editGenreSubscription =  this.genreService.updateGenre(this.id, updateGenreRequest)
      .subscribe({
        next: (response) => {
          this.router.navigateByUrl('/admin/genres');
        }
      })
    }
  }

  onDelete(): void {
    if (this.id) {
      this.genreService.deleteGenre(this.id)
      .subscribe({
        next: (response) => {
          this.router.navigateByUrl('/admin/genres');
        }
      })
    }
  }

  ngOnDestroy(): void {
    this.paramsSubscription?.unsubscribe();
    this.editGenreSubscription?.unsubscribe();
  }

}
