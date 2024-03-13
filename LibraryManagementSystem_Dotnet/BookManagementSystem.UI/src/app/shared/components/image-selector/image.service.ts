import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { BookImage } from '../../models/book-image.model';
import { environment } from 'src/environments/environment.development';
import { BehaviorSubject, Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class ImageService {
  selectedImage: BehaviorSubject<BookImage> = new BehaviorSubject<BookImage>({
    id: '',
    fileExtension: '',
    fileName: '',
    title: '',
    url: '',
  });

  constructor(private http: HttpClient) {}

  getAllImages(): Observable<BookImage[]> {
    return this.http.get<BookImage[]>(`${environment.apiBaseUrl}/api/images`);
  }

  uploadImage(
    file: File,
    fileName: string,
    title: string
  ): Observable<BookImage> {
    const formData = new FormData();
    formData.append('file', file);
    formData.append('fileName', fileName);
    formData.append('title', title);

    return this.http.post<BookImage>(
      `${environment.apiBaseUrl}/api/images`,
      formData
    );
  }

  selectImage(image: BookImage): void {
    this.selectedImage.next(image);
  }

  onSelectImage(): Observable<BookImage> {
    return this.selectedImage.asObservable();
  }
}
