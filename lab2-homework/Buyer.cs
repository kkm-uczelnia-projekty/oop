namespace Lab2Homework
{
    public class Buyer : Person


    {
        private List<Product> products;


        public Buyer(string name, int age) : base(name, age)
        {
            products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            this.products.Add(product);
        }

        public void RemoveProduct(int index)
        {
            this.products.RemoveAt(index);
        }

        private string RenderProducts(string prefix = "\t")
        {
            var convertedProducts = this.products.ConvertAll<string>(product => String.Format("{0}{1}", prefix, product.ToString()));
            return String.Join("\n", convertedProducts);
        }

        override public string ToString()
        {
            var renderedProducts = !!products.Any() ? String.Format("\n\t\t-- Products: --\n{0}", RenderProducts("\t\t")) : "";
            return String.Format("Buyer: {0} ({1} y. o.){2}", name, age, renderedProducts);
        }
    }
}
