import { ProductType, ProductRequest, ProductResponse } from '../types/productType';
import { fetchData, postData } from '../hooks/fetch';

export const createNewProduct = (product: ProductType): Promise<ProductType> =>
    postData(`/api/product/create`, {
        method: 'POST',
        body: product,
    });
export const fetchAllProduct = (query: ProductRequest): Promise<ProductResponse> =>
    fetchData(`/api/product/getAllData`);
