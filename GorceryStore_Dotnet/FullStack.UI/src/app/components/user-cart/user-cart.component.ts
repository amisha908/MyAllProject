import { Component, OnInit } from '@angular/core';
import { UserServiceService } from 'src/app/services/user-service.service';
import { SharedService } from 'src/app/services/shared.service';
import { ProductService } from 'src/app/services/product.service';

@Component({
  selector: 'app-user-cart',
  templateUrl: './user-cart.component.html',
  styleUrls: ['./user-cart.component.css']
})
export class UserCartComponent implements OnInit {
  productDetails: any[] = [];
  cartItems: any[] = [];
  totalPrice: number = 0;
  totalDiscount: number = 0;
  totalAmountToPay: number = 0;


  constructor(private cartService: UserServiceService,
    private Sharedservice:SharedService,
    private productservice:ProductService) { }
    showSuccessAlert: boolean = false;
  showFailureAlert: boolean = false;

 

  ngOnInit(): void {
    // Get the user's cart items
    const userId=this.Sharedservice.getUserIDvalue();
    
    this.cartService.getUserCart(userId).subscribe(
      (response: any[]) => {
        this.cartItems = response;
        console.log(this.cartItems); // You can check the response in the console
        for (const item of this.cartItems) {
          this.getProductDetails(item.productId);
        }
      },
      (error: any) => {
        console.log(error); // Handle the error if necessary
      }
    );
  
}
getProductDetails(productId: string) {
  this.productservice.getProductById(productId).subscribe(
    (response: any) => {
      const productIndex = this.cartItems.findIndex((item) => item.productId === productId);
      if (productIndex !== -1) {
        this.cartItems[productIndex].productName = response.productName;
        this.cartItems[productIndex].image = response.image;
        this.cartItems[productIndex].price=response.price;
        this.cartItems[productIndex].description=response.description;
        this.cartItems[productIndex].discount=response.discount;
        

        // Set any other product details you want to display
      }
      console.log(this.cartItems); // You can check the updated cart items in the console
    },
    (error: any) => {
      console.log(error); // Handle the error if necessary
    }
  );
}


calculateTotalPriceToPay(): number {
  let totalPriceToPay = 0;
  for (const item of this.cartItems) {
    totalPriceToPay += (item.price - item.discount) * item.totalQuantity;
  }
  return totalPriceToPay;
}



placeOrder() {
  const userId = this.Sharedservice.getUserIDvalue();
  console.log(this.cartItems)
for (const item of this.cartItems)
{
  const order: any = {
    userID: userId,
    productID: item.productId,
    totalMoneyPaid: (item.price - item.discount) * item.totalQuantity,
    
  };

  this.cartService.addOrder(order).subscribe(
    (response: any) => {
      // Handle the response if necessary
      // Empty the user cart
      console.log(response)
      this.cartItems = [];
      this.totalAmountToPay = 0;
      this.showSuccessAlert = true;

      // After a certain duration or event, hide the success alert
      setTimeout(() => {
        this.showSuccessAlert = false;
      }, 3000);
    },
    (error: any) => {
      console.log(error);
      this.showFailureAlert = true;

    // After a certain duration or event, hide the failure alert
    setTimeout(() => {
      this.showFailureAlert = false;
    }, 3000); // Hide after 3 seconds // Handle the error if necessary
    }
  );
}
this.cartService.emptyUserCart(userId).subscribe(
  (response: any)=>{
    console.log(response)
  },
  (error: any) => {
    console.log(error); // Handle the error if necessary
  }
  );


}
}
  

