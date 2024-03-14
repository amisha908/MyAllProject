import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { AddProducts } from '../Models/product.model';
import { Products } from '../Models/product.model';
import { Observable, catchError, of } from 'rxjs';


@Injectable({
  providedIn: 'root'
})
export class ProductService {
  baseApiUrl = "https://localhost:7100";
  constructor(private http: HttpClient) { }
  getAllProducts(): Observable<Products[]>
  {
    return this.http.get<Products[]>(this.baseApiUrl + '/api/Product');

  }
  addProduct(product: AddProducts): Observable<any> {
    console.log(product);
    return this.http.post(this.baseApiUrl+"/api/Product", product);
}
editProduct(product: Products): Observable<any> {
  const url = `${this.baseApiUrl}/api/Product/${product.id}`;
  return this.http.put(url, product);
}

deleteProduct(productId: string): Observable<any> {
  const url = `${this.baseApiUrl}/api/Product/${productId}`;
  return this.http.delete(url);
}
getProductById(productId: string): Observable<Products> {
  const url = `${this.baseApiUrl}/api/Product/${productId}`;
  return this.http.get<Products>(url);
}
getAverageRating(productId: string): Observable<any> {
  const url = `${this.baseApiUrl}/api/Ratings/GetRating/${productId}`;
  return this.http.get(url).pipe(
    catchError(() => of(0)) // Return 0 in case of errors
  );
}
}
