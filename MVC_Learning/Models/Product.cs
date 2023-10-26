namespace MVC_Learning.Models
{
    public class Product
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
        public double Price { get; set; }

        public Product(int id, string name, int count, double price)
        {
            Id = id;
            Name = name;
            Count = count;
            Price = price;
        }
    }


}
