using System;
namespace Task_6
{
	public class ProductRepository : IProductRepository<Product> 
    {
        private List<Product> _products = new List<Product>();
        private int _nextId = 1;

        public ProductRepository()
		{
            Add(new Product { Name = "Хлеб", Category = "Выпечка", Price = 1.39M });
            Add(new Product { Name = "Гамлет", Category = "Книги", Price = 3.75M });
            Add(new Product { Name = "Сатин", Category = "Ткани", Price = 16.99M });
        }

        public Product Add(Product item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            item.Id = _nextId++;
            _products.Add(item);
            return item;
        }

        public Product Get(int id)
        {
            return _products.Find(p => p.Id == id);
        }

        public void Remove(int id)
        {
            _products.RemoveAll(p => p.Id == id);
        }

        public bool Update(Product item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            int index = _products.FindIndex(p => p.Id == item.Id);
            if (index == -1)
            {
                return false;
            }
            _products.RemoveAt(index);
            _products.Add(item);
            return true;
        }

        public List<Product> GetAll()
        {
            return _products;
        }
    }
}

