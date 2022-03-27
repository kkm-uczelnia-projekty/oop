namespace Lab2Homework
{
    public class Product : IThing
    {
        protected string name;

        public Product(string name)
        {
            this.name = name;
        }

        public string Name()
        {
            return name;
        }

        public void Print(string prefix = "")
        {
            Console.WriteLine(String.Format("{0}{1}", prefix, ToString()));
        }

        override public string ToString()
        {
            return name;
        }
    }
}
