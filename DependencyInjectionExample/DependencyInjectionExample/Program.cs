




class Program
{
    public class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }

    }
    public class clientservice
    {
        public person1 client;
        public clientservice(person1 client)
        {
            this.client = client;
        }
        public List<Person> getallclient()
        {
            return client.selectallclient();
        }
    }
    public interface iclient
    {
        List<Person> selectallclient();
    }
    public class person1 : iclient
    {
        public List<Person> selectallclient()
        {
            List<Person> ListPerson = new List<Person>();
            //Get the Employees from the Database
            //for now we are hard coded the employees
            ListPerson.Add(new Person() { ID = 1, Name = "A" });
            ListPerson.Add(new Person() { ID = 2, Name = "B" });
            ListPerson.Add(new Person() { ID = 3, Name = "C" });
            return ListPerson;
        }
    }


    public class person2 : iclient
    {
        public List<Person> selectallclient()
        {
            List<Person> ListPerson = new List<Person>();
            //Get the Employees from the Database
            //for now we are hard coded the employees
            ListPerson.Add(new Person() { ID = 1, Name = "D", });
            ListPerson.Add(new Person() { ID = 2, Name = "E", });
            ListPerson.Add(new Person() { ID = 3, Name = "F", });
            return ListPerson;
        }
    }

    static void Main(string[] args)
    {
        clientservice client = new clientservice(new person1());
        List<Person> ListEmployee = client.getallclient();
        foreach (Person emp in ListEmployee)
        {
            Console.WriteLine("ID = {0}, Name = {1}", emp.ID, emp.Name);
        }
        Console.ReadKey();
    }
}