namespace Lab2Homework
{
    public class Shop : IThing
    {
        private string name;
        private List<Person> people;
        private List<Product> products;


        public Shop(string name, Person[] people, Product[] products)
        {
            this.name = name;
            this.people = people.ToList();
            this.products = products.ToList();
        }

        public string Name()
        {
            return name;
        }

        public void Print(string prefix = "")
        {
            Console.WriteLine(String.Format("{0}{1}", prefix, ToString()));
        }

        private string RenderPeople(string prefix = "\t")
        {
            var convertedPeople = this.people.ConvertAll<string>(person => String.Format("{0}{1}", prefix, person.ToString()));
            return String.Join("\n", convertedPeople);
        }

        private string RenderProducts(string prefix = "\t")
        {
            var convertedProducts = this.products.ConvertAll<string>(product => String.Format("{0}{1}", prefix, product.ToString()));
            return String.Join("\n", convertedProducts);
        }

        override public string ToString()
        {
            return String.Format("Shop: {0}\n-- People: --\n{1}\n-- Products: --\n{2}", name, RenderPeople(), RenderProducts());
        }
    }
}
