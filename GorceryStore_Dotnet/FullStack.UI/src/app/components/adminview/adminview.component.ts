import { Component, OnInit } from '@angular/core';
import { AppComponent } from 'src/app/app.component';
import { ProductService } from 'src/app/services/product.service';
import { Products } from 'src/app/Models/product.model';
import { Router } from '@angular/router';

@Component({
  selector: 'app-adminview',
  templateUrl: './adminview.component.html',
  styleUrls: ['./adminview.component.css']
})
export class AdminviewComponent {
  products: Products[] = [];
  showSuccessAlert1: boolean = false;
  constructor(private appComponent: AppComponent,
    private router: Router,
    private productService: ProductService) {
    this.appComponent.showNavBar = false;
  }ngOnInit(): void {
    this.getProducts();
  }

  getProducts(): void {
    this.productService.getAllProducts().subscribe(
      (products: Products[]) => {
        this.products = products;
      },
      (error) => {
        console.log('Error:', error);
      }
    );
  }

  editProduct(productId: string) {
    this.router.navigate(['Edit-Product', productId])
  }
  
  deleteProduct(productId: string) {
    this.productService.deleteProduct(productId).subscribe(
      response => {
        // Product deleted successfully, handle the response or update the product list
        console.log("Product deleted")
        this.showSuccessAlert1 = true;
    
        setTimeout(() => {
        this.showSuccessAlert1 = false;
        }, 3000);
      },
      error => {
        // Handle the error if the product could not be deleted
        console.log(productId)
        console.log("Product not deleted",error)
      }
    );
  }
}