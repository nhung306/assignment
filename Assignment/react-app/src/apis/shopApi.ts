import { fetchData, postData } from "../hooks/fetch";
import { ShopResponse, ShopType } from "../types/shopType";

export const fetchAllShop = (): Promise<ShopResponse> = > fetchData('/api/shop/getAllData');
export const createNewShop = (shop: ShopType): Promise<ShopType> = >
    postData(`/api/shop/create`, {
    method: 'POST',
    body: shop,
  });
