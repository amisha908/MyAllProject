import { Component, OnDestroy } from '@angular/core';
import { AddGenreRequest } from '../models/add-genre-request.model';
import { GenreService } from '../services/genre.service';
import { Subscription } from 'rxjs';
import { Router } from '@angular/router';

@Component({
  selector: 'app-add-genre',
  templateUrl: './add-genre.component.html',
  styleUrls: ['./add-genre.component.css']
})
export class AddGenreComponent implements OnDestroy {

  model: AddGenreRequest;
  private addGenreSubscription?: Subscription;

  constructor(private genreService: GenreService, private router: Router){
    this.model = {
      name: '',
      urlHandle: ''
    };
  }
  
  onFormSubmit(){
    this.addGenreSubscription = this.genreService.addGenre(this.model)
    .subscribe({
      next: (response) => {
        this.router.navigateByUrl('/admin/genres');
      }
    })
  }

  ngOnDestroy(): void {
    this.addGenreSubscription?.unsubscribe();
  }

}
