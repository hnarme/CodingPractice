class Books
{
    public string Name;
    public string Author;
    public int ISBN;
    public DateOnly LibraryAD;

    public Books()
    {
        Name = "";
        Author = "";
        ISBN = 0;
        LibraryAD = new DateOnly(0000, 00, 0);
    }
}
