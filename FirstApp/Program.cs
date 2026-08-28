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
            // object mybook = new Book { Title = "C# Programming", Pages = 350 };
            //Console.WriteLine(mybook);
            #endregion
            #region Question02
            //2.Using the Book class above, print the result of calling ToString(), Equals() (compare book
            // with itself), GetHashCode(), and GetType() on book.
            //object mybook = new Book { Title = "C# Programming", Pages = 350 };
            //Console.WriteLine(mybook.ToString());
            //Console.WriteLine(mybook.Equals(mybook));
            //Console.WriteLine(mybook.GetHashCode());
            //Console.WriteLine(mybook.GetType());
            #endregion
            #region Question03
            //3.Look at the line below. Is it a compile-time error, a runtime error, or a logical error? Fix it.
            //int pages = "464";
            //Answer: This is a compile-time error because you cannot put text (string) into an int varible.
            // int pages = 464;
            #endregion

        }

    }
    public class Book
    {
        public string Title { get; set; }
        public int Pages { get; set; }
    }
}