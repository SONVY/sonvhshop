using SonvhShop.Data.Infrastructure;
using SonvhShop.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonvhShop.Data.Reponsitories
{
    public interface IPageRepository
    {

    }
   public class PageRepository:RepositoryBase<Page>, IPageRepository
    {
        public PageRepository(IDbFactory dbFactory):base(dbFactory)
        {

        }
    }
}
