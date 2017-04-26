﻿using SonvhShop.Data.Infrastructure;
using SonvhShop.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonvhShop.Data.Reponsitories
{
    public interface IPostCategoryRepository
    {

    }
   public class PostCategoryRepository:RepositoryBase<PostCategory>, IPostCategoryRepository
    {
        public PostCategoryRepository(IDbFactory dbFactory):base(dbFactory)
        {

        }
    }
}
