using FirstApi.Domain.Entities;

namespace FirstApi.Domain.Helper
{
    public class CategoryProducts
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public Product Product { get; set; }
        public Category Category { get; set; }
    }
}