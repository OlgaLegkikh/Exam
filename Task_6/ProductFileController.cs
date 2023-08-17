using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

namespace Task_6
{
    public class ProductFileController : IProductFileController<Product>
	{
        
        public ProductFileController() 
		{
		}
        
        public List<Product> ProductFileReader(string filePath)
        {
            string line;
            StreamReader sr = new StreamReader(filePath);
            List<Product>? _innerList = new List<Product>();
            try
            {

                var json = sr.ReadToEnd();
            _innerList = JsonSerializer.Deserialize<List<Product>>(json);
            return _innerList;

            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
                return _innerList;
            }
            finally
            {
                sr.Close();
            }
        }

        public void ProductFileWriter(List<Product> promt, string filePath)
        {
            var option = new JsonSerializerOptions
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                WriteIndented = true
            };
            try
            {

                string jsonString = JsonSerializer.Serialize(promt, option);
                //Console.WriteLine(jsonString);

                File.WriteAllText(filePath, jsonString);
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
    }
}

