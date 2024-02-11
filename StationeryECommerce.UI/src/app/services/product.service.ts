import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { Product } from '../models/product';

@Injectable({
  providedIn: 'root',
})
export class ProductService {
  constructor(private http: HttpClient) {}

  private url = 'Product';

  public getProducts(): Observable<Product> {
    return this.http.get<Product>(`${environment.apiURL}/${this.url}`);
  }
}
