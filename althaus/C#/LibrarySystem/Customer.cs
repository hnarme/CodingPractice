class Customer
{
  public int Id { get; set; }
  public string Name { get; set; }
  public DateOnly DateOfBirth { get; set; }

  public Customer(int id, string name, DateOnly dateOfBirth)
  {
    Id = id;
    Name = name;
    DateOfBirth = dateOfBirth;
  }

  public override string ToString()
  {
    return $"{Id},{Name},{DateOfBirth}";
  }
}