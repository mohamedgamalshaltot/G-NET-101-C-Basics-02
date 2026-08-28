namespace FirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            #region Question01
            //1.Create a Book class with a Title (string) and Pages (int). Create a Book object and store it
            //in a variable of type object.Print it.
            object mybook = new book { title = "c# programming", pages = 350 };
            console.writeline(mybook);
            #endregion
            #region Question02
            //2.Using the Book class above, print the result of calling ToString(), Equals() (compare book
            // with itself), GetHashCode(), and GetType() on book.
            object mybook = new Book { Title = "C# Programming", Pages = 350 };
            Console.WriteLine(mybook.ToString());
            Console.WriteLine(mybook.Equals(mybook));
            Console.WriteLine(mybook.GetHashCode());
            Console.WriteLine(mybook.GetType());
            #endregion
            #region Question03
            //3.Look at the line below. Is it a compile-time error, a runtime error, or a logical error? Fix it.
            //int pages = "464";
             Answer: This is a compile - time error because you cannot put text(string) into an int varible.
             int pages = 464;
            #endregion
            #region Question04

            //4.Write code that divides 10 by 0 inside a try block, catches the exception, prints "Cannot
            //divide by zero", and then prints "Done" in a finally block.
            try
            {
                int x = 10;
                int y = 0;
                int result = x/ y;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
            }
            finally
            {
                Console.WriteLine("Done");
            }
            #endregion
            #region Question05
            //5.Declare an int pages = 300; then store it in a double variable without using a cast.
            int pages = 300;
            double pagesDouble = pages;
            Console.WriteLine(pagesDouble);

            #endregion


        }

    }
    public class Book
    {
        public string Title { get; set; }
        public int Pages { get; set; }
    }
}