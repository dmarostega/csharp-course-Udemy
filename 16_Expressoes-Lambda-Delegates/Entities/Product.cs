namespace Course_16_Expressoes_Lambda.Entities
{
    class Product /* : IComparable<Product> */
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return "Product: " + Name + ", Price: " + Price.ToString("F2");
        }

      /*
       * sem comparison
       * 
       * public int CompareTo(Product other)
        {
            return Name.ToUpper().CompareTo(other.Name.ToUpper());
        }
        
      */
    }
}
