import { CustomerType, CustomerResponse } from '../types/customer';
import { fetchData, postData } from '../hooks/fetch';

export const fetchAllCustomer = (): Promise<CustomerResponse> => fetchData('/api/customer/');
export const createNewCustomer = (customer: CustomerType): Promise<CustomerResponse> =>
    postData(`/api/customer/create`, {
        method: 'POST',
        body: customer,
    });