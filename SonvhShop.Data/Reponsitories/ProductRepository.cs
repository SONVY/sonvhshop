using SonvhShop.Data.Infrastructure;
using SonvhShop.Model.Model;

namespace SonvhShop.Data.Reponsitories
{
    public interface IProductRepository
    {
    }

    public class ProductRepository : RepositoryBase<Product>
    {
        public ProductRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}