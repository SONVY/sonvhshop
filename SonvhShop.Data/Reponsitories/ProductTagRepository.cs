using SonvhShop.Data.Infrastructure;
using SonvhShop.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonvhShop.Data.Reponsitories
{
    public interface IProductTagRepository
    {

    }
  public  class ProductTagRepository:RepositoryBase<ProductTag>, IProductTagRepository
    {
        public ProductTagRepository(IDbFactory dbFactory):base(dbFactory)
        {

        }
    }
}
