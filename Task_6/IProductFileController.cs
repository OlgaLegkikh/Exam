using System;
namespace Task_6
{
	public interface IProductFileController<T> where T : class
	{
        private const string _filePath = "product_list.json";
        public List<T> ProductFileReader(string filePath = _filePath);
		public void ProductFileWriter( List<Product> products, string filePath = _filePath);

    }
}

