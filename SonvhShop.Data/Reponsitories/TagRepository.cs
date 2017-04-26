using SonvhShop.Data.Infrastructure;
using SonvhShop.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonvhShop.Data.Reponsitories
{
    public interface ITagRepository
    {

    }
   public class TagRepository:RepositoryBase<Tag>, ITagRepository
    {
        public TagRepository(IDbFactory dbFactory):base(dbFactory)
        {

        }
    }
}
