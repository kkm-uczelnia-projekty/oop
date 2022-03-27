namespace Lab2Homework
{
    public class Fruit : Product
    {
        private int count;

        public Fruit(string name, int count) : base(name)
        {
            this.count = count;
        }

        new public string Name()
        {
            return name;
        }

        override public string ToString()
        {
            var fruitForm = count == 1 ? "fruit" : "fruits";
            return String.Format("{0} ({1} {2})", name, count, fruitForm);
        }
    }
}
