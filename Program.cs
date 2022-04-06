using System;
using System.Data.SqlClient;

namespace SQLcrud
{
    class Program
    {
        static void Main(string[] args)
        {
            Secondary db = new Secondary();
            string restart;

            do
            {
                Console.WriteLine("1. Insert Query");
                Console.WriteLine("2. Update Query");
                Console.WriteLine("3. Delete Query");
                Console.WriteLine("4. Select Query");
                Console.WriteLine();
                Console.WriteLine("Enter required query: ");
                int options = Convert.ToInt32(Console.ReadLine());
                switch (options)
                {
                    case 1:
                        db.insert();
                        break;
                    case 2:
                        db.update();
                        break;
                    case 3:
                        db.delete();
                        break;
                    case 4:
                        db.select();
                        break;
                }
                Console.WriteLine();
                Console.WriteLine("Do you want to proceed for queries? (YES/NO): ");
                restart = Console.ReadLine();
                Console.WriteLine();
            } while (restart == "YES");
        }
    }
}
