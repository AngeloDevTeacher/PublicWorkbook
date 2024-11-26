

Book lotr = new Book();
Book notw = new Book();
Book twmf = new Book("The Wise Man's Fear", "rothfuss", 3);
lotr.bookNum = 1;
notw.bookNum = 2;
notw.author = "rothfuss";
lotr.author = "tolkien";

Book[] bookshelf = new Book[3];
bookshelf[0] = lotr;
bookshelf[1] = notw;
bookshelf[2] = twmf;
foreach (Book book in bookshelf)
{
    Console.WriteLine(book.author);
    Console.WriteLine(book.bookNum);
}

if (bookshelf[1].author == bookshelf[2].author)
{

}


class Book
{
    public string title;
    public string author;
    public int bookNum;
    string[] pages;



    public Book()
    {

    }

    public Book(string title, string author, int num)
    {
        this.title = title;
        this.author = author;
        this.bookNum = num;
    }


    /// <summary>
    /// Returns the pages. 
    /// </summary>
    /// <returns>pages</returns>
    string[] ReadBook()
    {
        return pages;
    }
    string ReadPage(int page)
    {
        return pages[page];
    }
}