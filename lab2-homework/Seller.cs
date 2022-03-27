namespace Lab2Homework
{
    public class Seller : Person


    {
        public Seller(string name, int age) : base(name, age) { }

        override public string ToString()
        {
            return String.Format("Seller: {0} ({1} y. o.)", name, age);
        }
    }
}
