import { BaseType } from './baseType';

export interface ShopType extends BaseType {
    name: string;
    location: string;
}

export interface ShopResponse {
    totalRecords: number;
    items: ShopType[];
}
