namespace Lab2Homework
{
    public class Meat : Product
    {
        private double weight;

        public Meat(string name, double weight) : base(name)
        {
            this.weight = weight;
        }

        new public string Name()
        {
            return name;
        }

        override public string ToString()
        {
            return String.Format("{0} ({1} kg)", name, weight);
        }
    }
}
