public class ioc
{
    static void Main(String[] args)
    {
        User user = new User(new myoracledatabase());
        user.add("some data");
    }

    public class User
    {
        database database;

        public User(database database)
        {
            this.database = database;
        }
        public void add(String data)
        {
            database.persist(data);
        }
    }

    public interface database { 
        void persist(String data);
    }

    public class mysqldatabase : database
    {
        public void persist(String data)
        {
            Console.WriteLine("my sql has persisted:" + data);
        }
    }

    public class myoracledatabase : database
    {
        public void persist(String data)
        {
            Console.WriteLine("my oracle has persisted:" + data);
        }
    }
}
