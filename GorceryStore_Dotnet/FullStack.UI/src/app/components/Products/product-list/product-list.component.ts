import { Component, OnInit } from '@angular/core';
import { Products } from 'src/app/Models/product.model';
import { ProductService } from 'src/app/services/product.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-product-list',
  templateUrl: './product-list.component.html',
  styleUrls: ['./product-list.component.css']
})
export class ProductListComponent implements OnInit {
  products: Products[] = [];
  filteredProducts: Products[] = []; // New property for filtered products
  ratings: { [productId: string]: number } = {};
  categories: string[] = []; // New property for product categories
  selectedCategory: string = ''; // New property for selected category
  searchKeyword: string = ''; // New property for search keyword

  constructor(private productService: ProductService, private router: Router) {}

  showProductDetails(product: Products) {
    this.router.navigate(['/Product-view', product.id]);
  }

  ngOnInit(): void {
    this.productService.getAllProducts().subscribe({
      next: (products) => {
        this.products = products;
        this.filteredProducts = products; // Initialize filtered products with all products
        this.fetchRatingsForProducts(products);
        this.extractCategories(products);
      },
      error: (error) => {
        console.log('Error:', error); // Handle the error appropriately
      }
    });
  }

  fetchRatingsForProducts(products: Products[]): void {
    for (const product of products) {
      this.productService.getAverageRating(product.id).subscribe({
        next: (rating) => {
          this.ratings[product.id] = rating;
        },
        error: (error) => {
          console.log('Error:', error); // Handle the error appropriately
        }
      });
    }
  }

  extractCategories(products: Products[]): void {
    this.categories = [...new Set(products.map((product) => product.category))];
  }

  filterByCategory(): void {
    if (this.selectedCategory) {
      this.filteredProducts = this.products.filter((product) => product.category === this.selectedCategory);
    } else {
      this.filteredProducts = this.products;
    }
  }

  filterByKeyword(): void {
    const keyword = this.searchKeyword.toLowerCase();
    this.filteredProducts = this.products.filter(
      (product) =>
        product.productName.toLowerCase().includes(keyword) ||
        product.description.toLowerCase().includes(keyword)
    );
  }
}
