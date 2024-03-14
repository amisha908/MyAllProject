import { Component } from '@angular/core';
import { AddProducts } from 'src/app/Models/product.model';
import { ProductService } from 'src/app/services/product.service';
import { HttpClient } from '@angular/common/http';
import { MatSnackBar } from '@angular/material/snack-bar';
import { AppComponent } from 'src/app/app.component';

@Component({
  selector: 'app-add-product',
  templateUrl: './add-product.component.html',
  styleUrls: ['./add-product.component.css']
})
export class AddProductComponent {
  product: AddProducts = {
    productName: '',
    description: '',
    category: '',
    availableQuantity: 0,
    image: '',
    price: 0,
    discount: 0,
    specification: '',
    
    
  };

  constructor(private http: HttpClient,
    private productService: ProductService,
    private appComponent: AppComponent,
    private snackBar: MatSnackBar,) {
      this.appComponent.showNavBar = false;
  }

  onFileSelected(event: any) {
    const file: File = event.target.files[0];
  
    // Perform any necessary image validation here
    if (file.type !== 'image/jpeg') {
      // Show an error message or take appropriate action for unsupported file format
      console.error('Only JPG files are supported.');
      this.openSnackBar('Only JPG files are supported.', 'Error!!!');
      return;
    }
  
    // Create a FormData object to send the file
    const formData = new FormData();
    formData.append('image', file);
    console.log(formData);
  
    // Make an HTTP request to the backend to save the image file
    this.http.post<any>('https://localhost:7100/api/Image/upload-image', formData)
      .subscribe(
        (response: any) => {
          if (response && response.imageUrl) {
            // Store the image URL in the product object
            this.product.image = response.imageUrl;
            this.openSnackBar('Image saved successfully', 'Success!!!');
            console.log('Image saved successfully:', response.imageUrl);
          } else {
            console.error('Invalid response:', response);
            this.openSnackBar('Invalid response', 'Error!!!');
          }
        },
        (error: any) => {
          console.error('Error saving image:', error);
          this.openSnackBar('Error saving image', 'Error!!!');
        }
      );
  }
  

  addProduct() {
    
    this.productService.addProduct(this.product).subscribe(
      response => {
        // Product added successfully, handle the response or navigate to another page
        this.openSnackBar('Product added successfully','Success!!!');
        console.log('Product added:', response);
      },
      error => {
        // Handle the error if the product could not be added
        this.openSnackBar('Error adding product','Error!!!');
        console.log('Error adding product:', error);
      }
    );
  
  }
  openSnackBar(message: string, action: string) {
    this.snackBar.open(message, action, {
      duration: 2000 // Adjust the duration as per your preference
    });
  }
}
