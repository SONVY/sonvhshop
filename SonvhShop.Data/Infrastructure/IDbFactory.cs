using SonvhShop.Data;
using System;

namespace SonvhShop.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        SonvhShopDbContext Init();
    }
}