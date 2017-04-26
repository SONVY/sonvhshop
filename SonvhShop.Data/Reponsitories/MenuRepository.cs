using SonvhShop.Data.Infrastructure;
using SonvhShop.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonvhShop.Data.Reponsitories
{
    public interface IMenuRepository
    {

    }
   public class MenuRepository:RepositoryBase<Menu>, IMenuRepository
    {
        public MenuRepository(IDbFactory dbFactory):base(dbFactory)
        {

        }
    }
}
