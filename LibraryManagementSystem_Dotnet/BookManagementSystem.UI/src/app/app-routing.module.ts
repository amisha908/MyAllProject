import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { GenresListComponent } from './features/Genres/genres-list/genres-list.component';
import { AddGenreComponent } from './features/Genres/add-genre/add-genre.component';
import { EditGenreComponent } from './features/Genres/edit-genre/edit-genre.component';
import { BookListComponent } from './features/Book/book-list/book-list.component';
import { AddBookComponent } from './features/Book/add-book/add-book.component';
import { EditBookComponent } from './features/Book/edit-book/edit-book.component';
import { HomeComponent } from './features/public/home/home.component';
import { BookDetailsComponent } from './features/public/book-details/book-details.component';
import { LoginComponent } from './features/auth/login/login.component';
import { authGuard } from './features/auth/guards/auth.guard';
import { BorrowedBookListComponent } from './features/Book/borrowed-book-list/borrowed-book-list.component';

const routes: Routes = [
  {
    path: '',
    component: HomeComponent,
  },
  {
    path: 'login',
    component: LoginComponent,
  },
  {
    path: 'book/:url',
    component: BookDetailsComponent,
  },
  {
    path: 'admin/genres',
    component: GenresListComponent,
    canActivate: [authGuard]
  },
  {
    path: 'admin/genres/add',
    component: AddGenreComponent,
    canActivate: [authGuard]
  },
  {
    path: 'admin/genres/:id',
    component: EditGenreComponent,
    canActivate: [authGuard]
  },
  {
    path: 'admin/books',
    component: BookListComponent,
    canActivate: [authGuard]
  },
  {
    path: 'admin/borrowedBooks',
    component: BorrowedBookListComponent,
  },
  {
    path: 'admin/books/add',
    component: AddBookComponent,
    canActivate: [authGuard]
  },
  {
    path: 'admin/books/:id',
    component: EditBookComponent,
    canActivate: [authGuard]
  },
];

@NgModule({
  imports: [
    RouterModule.forRoot(routes),
  
  ],
  exports: [RouterModule],
})
export class AppRoutingModule {}
