using Marten.Schema;

namespace CatalogApi.Data
{
    public class CatalogInitialData : IInitialData
    {
        public async Task Populate(IDocumentStore store, CancellationToken cancellation)
        {
            using var session = store.LightweightSession();


            if (await session.Query<Product>().AnyAsync())
                return;

            session.Store<Product>(GetPreConfiguredProducts());
            await session.SaveChangesAsync();
        }

        public static IEnumerable<Product> GetPreConfiguredProducts() => new List<Product>()
        {
            new Product()
            {
                Id = new Guid(Guid.NewGuid().ToString()),
                Name = "IPhone X",
                ImageFile = "product-1.png",
                Price = 950.00M,
                Category = new List<string> { "Smart Phone"}
            },
            new Product()
            {
                Id = new Guid(Guid.NewGuid().ToString()),
                Name = "IPhone X",
                ImageFile = "product-1.png",
                Price = 950.00M,
                Category = new List<string> { "Smart Phone"}
            }
        };
    }
}
