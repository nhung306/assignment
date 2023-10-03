import { BaseType } from './baseType';
import { ShopType } from './shopType';

export interface ProductType extends BaseType {
    name: string;
    imageUrl: string;
    price: number;
    shop: ShopType;
    shopId: number;
}

export interface ProductRequest {
    pageNumber: number;
    pageSize: number;
    searchText: string;
}

export interface ProductResponse {
    pageNumber: number;
    pageSize: number;
    search: string;
    totalPages: number;
    totalRecords: number;
    items: ProductType[];
}
