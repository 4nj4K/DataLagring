using Data.Contexts;
using Data.Entities;

namespace Data.Repositories;

public class ProductRepository : BaseRepository<ProductEntity>
{
    public ProductRepository(DataContext context) : base(context)
    {
    }
}
