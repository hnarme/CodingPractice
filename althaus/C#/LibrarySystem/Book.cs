class Book
{
  public string Name { get; set; }
  public string Author { get; set; }
  public string ISBN { get; set; }
  public DateOnly LibraryAcquisitionDate { get; set; }

  public Book(string name, string author, string isbn, DateOnly libraryAcquisitionDate)
  {
    Name = name;
    Author = author;
    ISBN = isbn;
    LibraryAcquisitionDate = libraryAcquisitionDate;
  }

  public override string ToString()
  {
    return $"{Name},{Author},{ISBN},{LibraryAcquisitionDate}";
  }
}