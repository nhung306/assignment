import { BaseType } from './baseType';

export interface CustomerType extends BaseType {
    fullName: string;
    email: string;
    dateOfBirth: Date;
}

export interface CustomerResponse {
    totalRecords: number;
    items: CustomerType[];
}
