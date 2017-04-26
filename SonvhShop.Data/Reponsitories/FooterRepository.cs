using SonvhShop.Data.Infrastructure;
using SonvhShop.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonvhShop.Data.Reponsitories
{
    public interface IFooterRepository
    {

    }
   public class FooterRepository:RepositoryBase<Footer>, IFooterRepository
    {
        public FooterRepository(IDbFactory dbFactory):base(dbFactory)
        {

        }
    }
}
