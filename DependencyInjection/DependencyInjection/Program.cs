namespace DependencyInjection // Note: actual namespace depends on the project name.
{
    class Program
    {
        // 1. client class --> client class là class phụ thuộc (dependency) vào class service
        // 2. service class --> class service là class cung cấp cho class client
        // 3. injector class --> injector class là class sẽ inject class service vào class client
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ClientService objservice = new ClientService(new Studentservice());

            //Studentservice std = new Studentservice();
            //std.GetFirstName();
            //std.GetLastName();


            Console.ReadKey();
        }

        // client class
        public class ClientService
        {
            private Iservice cservice;
            public ClientService(Iservice cservice)
            {
                this.cservice = cservice;
                this.cservice.GetFirstName();
                this.cservice.GetLastName();
                
            }
        }



        public interface Iservice
        {
            void GetFirstName();

            void GetLastName();


        }

            
        //service class
        public class Studentservice : Iservice
        {
            public void GetFirstName()
            {
                Console.WriteLine("student first name");
            }
            public void GetLastName()
            {
                Console.WriteLine("student last name");
            }
        }
        //service class
        public class Teacherservice : Iservice
        {
            public void GetFirstName()
            {
                Console.WriteLine("teacher first name");
            }
            public void GetLastName()
            {
                Console.WriteLine("teacher last name");
            }
        }
    }
}