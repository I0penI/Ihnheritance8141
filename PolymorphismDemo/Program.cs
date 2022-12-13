namespace PolymorphismDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Database db = new OracleDatabase()
            {
                Company = "Oracle",
                Name = "Oracle"
            };
            
            db.Create();
            db.Read();
        }
        
    }
    class Database // Base
    {
        public string Name { get; set; }
        public string Company { get; set; }


        public void Create()
        {
            Console.WriteLine("Created by Database " + Name);
        }
        public void Read()
        {
            Console.WriteLine("Read by Database " + Name);
        }
        public void Update()
        {
            Console.WriteLine("Updated by Database " + Name);
        }
        public void Delete()
        {
            Console.WriteLine("Deleted by Database " + Name);
        }

    }
    

    class SqlDatabase : Database
    {

    }
    class OracleDatabase : Database
    {

    }
}