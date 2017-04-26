
namespace SonvhShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private SonvhShopDbContext dbContext;

        public SonvhShopDbContext Init()
        {
            return dbContext ?? (dbContext = new SonvhShopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}