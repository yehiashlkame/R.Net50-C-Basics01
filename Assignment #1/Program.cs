using System.Reflection;

namespace Assignment__1
{
    internal class Program
    {
        static void Main()
        {


            #region Book
            Console.WriteLine("Assignment #1");
            Console.WriteLine("--------------------------------------------");


            object obj = new Book() { Title = "Test" , Pages = 500};
            Console.WriteLine(obj);
            #endregion

            #region Types
            Console.WriteLine(obj.ToString());
            Console.WriteLine(obj.Equals(obj));
            Console.WriteLine(obj.GetHashCode());
            Console.WriteLine(obj.GetType());
            #endregion

            #region Compile-time error
            //int Pages = "450"; 
            // Compile-time error 
            int Pages = 450;
            Console.WriteLine(Pages);
            #endregion

            #region Catch
            try 
            {
                int x = 10;
                int y = 0;

                Console.WriteLine(x / y);

            }

            catch
            {
                Console.WriteLine("Cannot Devide By Zero");
            }

            finally
            {
                Console.WriteLine("Done");
            }
            #endregion


        }
    }
}
