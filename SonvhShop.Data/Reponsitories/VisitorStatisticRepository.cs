using SonvhShop.Data.Infrastructure;
using SonvhShop.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonvhShop.Data.Reponsitories
{
    public interface IVisitorStatisticRepository
    {

    }
   public class VisitorStatisticRepository:RepositoryBase<VisitorStatistic>, IVisitorStatisticRepository
    {
        public VisitorStatisticRepository(IDbFactory dbFactory):base(dbFactory)
        {

        }
    }
}
