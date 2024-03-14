import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ProductListComponent } from './components/Products/product-list/product-list.component';
import { RegisterComponent } from './components/Register/register.component';
import { LoginComponent } from './components/Login/login.component';
import { AdminviewComponent } from './components/adminview/adminview.component';
import { UserviewComponent } from './components/userview/userview.component';
import { AddProductComponent } from './components/Products/add-product/add-product.component';
import { EditProductComponent } from './components/Products/edit-product/edit-product.component';
import { ProductViewComponent } from './components/Products/product-view/product-view.component';
import { ProductUserViewComponent } from './components/Products/product-user-view/product-user-view.component';
import { UserCartComponent } from './components/user-cart/user-cart.component';
import { UserOrdersComponent } from './components/user-orders/user-orders.component';
import { AdminViewRecentOrdersComponent } from './components/admin-view-recent-orders/admin-view-recent-orders.component';
const routes: Routes = [
  {
    path:"My_Orders/:id",
    component:UserOrdersComponent
  },
  {
    path:"My_Cart/:id",
    component:UserCartComponent
  },
  {
    path: "Product-user-view/:id",
    component: ProductUserViewComponent
  },
  {
    path: "Product-view/:id",
    component: ProductViewComponent
  },
  {
    path: "Edit-Product/:id",
    component:EditProductComponent
  },
  {
    path : "",
    component : ProductListComponent
  },
  {
    path : "Products",
    component : ProductListComponent
  },
  {
    path : "Register",
    component : RegisterComponent
  },
  {
    path : "Login",
    component : LoginComponent
  },
  { path: '', redirectTo: '/Login', pathMatch: 'full' },
  { path: '', redirectTo: '/Register', pathMatch: 'full' },
  {
    path : "Admin-view",
    component : AdminviewComponent, children :[{
      path: "Add-Product",
      component: AddProductComponent
    },
    {
      path:"Recent-Orders",
      component: AdminViewRecentOrdersComponent
    }
  ]
  },
  
    {
      path:"Recent-Orders",
      component: AdminViewRecentOrdersComponent
    },
  
  {
    path : "User-view",
    component : UserviewComponent
  },
  {
    path : "Add-Product",
    component : AddProductComponent
  }

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
