import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Products } from 'src/app/Models/product.model';
import { ProductService } from 'src/app/services/product.service';
import { AppComponent } from 'src/app/app.component';
import { SharedService } from 'src/app/services/shared.service';
import { CartItem } from 'src/app/Models/CartItem';
import { UserServiceService } from 'src/app/services/user-service.service';
import { Ratings } from 'src/app/Models/Ratings';
@Component({
  selector: 'app-product-user-view',
  templateUrl: './product-user-view.component.html',
  styleUrls: ['./product-user-view.component.css']
})
export class ProductUserViewComponent implements OnInit{
  productId!: string;
  product!: Products;
  productQuantity: number = 1;
  selectedRating: number=0 ;
  showSuccessAlert1: boolean = false;
  showFailureAlert1: boolean = false;
  showSuccessAlert2: boolean = false;
  showFailureAlert2: boolean = false;
  cartItem: CartItem = {
    productId: '',
   userID:'',
   productQuantity: 1,
  };
  ratings: Ratings={
    rating: 0,
    productId: ''
  };

  constructor(private route: ActivatedRoute, private productService: ProductService,
    private appcomponent: AppComponent,
    private shareservice:SharedService,
    private userservice: UserServiceService) {
      this.appcomponent.showNavBar=false;
      
    
    }
    
    

  ngOnInit() {
    this.route.params.subscribe(params => {
      this.productId = params['id'];
      this.getProductDetails();

      
    });
  }

  getProductDetails() {
    this.productService.getProductById(this.productId).subscribe(
      response => {
        this.product = response;
        console.log(response)
      },
      error => {
        // Handle the error if the product details cannot be retrieved
      }
    );
  }
  addToCart()
  {
    console.log(this.shareservice.getUserIDvalue());
    
this.cartItem.userID=this.shareservice.getUserIDvalue();

this.cartItem.productId=this.product.id;

this.cartItem.productQuantity=this.productQuantity;
this.userservice.addToCart(this.cartItem).subscribe(
  (response: any) => {
    // Handle the response here
    console.log("product added",response);
    this.showSuccessAlert1 = true;
    
    setTimeout(() => {
      this.showSuccessAlert1 = false;
    }, 3000);

  },
  (error: any) => {
    // Handle the error here
    console.error(error);
    this.showFailureAlert1 = true;
    
    setTimeout(() => {
      this.showFailureAlert1 = false;
    }, 3000);
  }
);
}
selectRating(rating: number) {
  this.selectedRating = rating;
}
submitRating()
{
  this.ratings.rating=this.selectedRating
  this.ratings.productId=this.productId
  this.userservice.addRating(this.ratings).subscribe(
    (response: any) => {
      // Handle the response here
      console.log("Rating added",response);
      this.showSuccessAlert2 = true;
    
    setTimeout(() => {
      this.showSuccessAlert2 = false;
    }, 3000);
  
    },
    (error: any) => {
      // Handle the error here
      console.error(error);
      this.showFailureAlert2 = true;
    
    setTimeout(() => {
      this.showFailureAlert2 = false;
    }, 3000);
    }
  );
  }

}


