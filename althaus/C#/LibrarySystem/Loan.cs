class Loan
{
  public int Id { get; set; }
  public string ISBN { get; set; }
  public DateOnly DueDate { get; set; }

  public Loan(int id, string isbn, DateOnly dueDate)
  {
    Id = id;
    ISBN = isbn;
    DueDate = dueDate;
  }
}