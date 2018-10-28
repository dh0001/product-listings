using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace store.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }

        public ICollection<Image> Images { set; get; }
        public ICollection<Category> Categories { set; get; }
    }

    public class Image
    {
        public int Id { set; get; }
        public byte[] ImageData { set; get; }
        public int ProductId { set; get; }
    }

    public class Category
    {
        public int Id { set; get; }
        public int ProductId { set; get; }
        public string CategoryName { set; get; }
    }
}
