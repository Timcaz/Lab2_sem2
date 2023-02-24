namespace Lab2_sem2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = GetProductsFromDatabase();
            var groupedProducts = products.GroupBy(p => p.Category);

            foreach (var group in groupedProducts)
            {
                Console.WriteLine("{0}:", group.Key);
                foreach (Product product in group)
                {
                    Console.WriteLine("- {0} ₴{1}", product.Name, product.Price);
                }
            }

            static List<Product> GetProductsFromDatabase(string filePath)
            {
                // Зчитування з бази данних
            }
        }
    }
}