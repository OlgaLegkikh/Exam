using System;
namespace Task_6
{
	public interface IProductRepository<T> where T : Product
    {
        public List<T> GetAll();
        Product Get(int id);
        Product Add(Product item);
        void Remove(int id);
        bool Update(Product item);
    }
}

