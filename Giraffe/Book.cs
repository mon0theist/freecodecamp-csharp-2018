namespace Giraffe
{
    class Book
    {
        public string title;
        public string author;
        public int pages;
        
        // Constructor
        // public Book(){
        //     Console.WriteLine("Creating book...");
        // }

        // can have multiple constructor functions in a class

        // "default" constructor with no parameters
        public Book() {

        }
        public Book(string aTitle, string aAuthor, int aPages){
            title = aTitle;
            author = aAuthor;
            pages = aPages;
        }
    }
}