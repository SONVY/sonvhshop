using SonvhShop.Data.Infrastructure;
using SonvhShop.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonvhShop.Data.Reponsitories
{
    public interface ISupportOnlineRepository
    {

    }
   public class SupportOnlineRepository:RepositoryBase<SupportOline>, ISupportOnlineRepository
    {
        public SupportOnlineRepository(IDbFactory dbFactory):base(dbFactory)
        {

        }
    }
}
