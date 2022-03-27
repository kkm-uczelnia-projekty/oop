namespace Lab2Homework
{
    public class Person : IThing
    {
        protected string name;
        protected int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
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
            return String.Format("{0} ({1} y. o.)", name, age);
        }
    }
}
