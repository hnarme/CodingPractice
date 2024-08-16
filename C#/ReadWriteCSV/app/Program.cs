using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using CsvHelper;

class Program {
  public static void Main (string[] args) {
    var records = new List<Foo>
    {
        new Foo { Id = 1, Name = "one" },
        new Foo { Id = 2, Name = "two" },
        new Foo { Id = 3, Name = "three" },
        new Foo { Id = 4, Name = "four" },
    };

    using (var writer = new StreamWriter("file.csv"))
    using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
    {
        csv.WriteRecords(records);
    }

    using (var reader = new StreamReader("file.csv"))
using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
{
    var recordsget = csv.GetRecords<Foo>();
}
  }

  public class Foo
  {
      public int Id { get; set; }
      public string Name { get; set; }
    }
}