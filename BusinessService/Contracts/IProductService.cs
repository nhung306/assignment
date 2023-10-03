using DataAccess.Entities;

namespace BusinessService.Contracts
{
    public interface IProductService
    {
        void RandomInsertCustomer();

        void AddProduct(Product product);
    }
}
