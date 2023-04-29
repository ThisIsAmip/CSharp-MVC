using Entity;

namespace Service
{
    public interface IProductService
    {
        //thêm, sửa, xóa, get all, ...
        Task CreateAsync(Product product);

        Task DeleteAsync(Product product);
        Task UpdateAsync(Product product);

        Task DeleteById(int id);
        IEnumerable<Product> GetAll();

        Product GetByProductId(int product);
        Task<List<Product>> GetProducts(int pageNumber, int pageSize);
        Task<List<Product>> GetProductsByCategory(int categoryId, int pageNumber, int pageSize);
        int GetTotalCount();
    }
}
