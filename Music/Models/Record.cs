using System.Collections.Generic;

namespace Music.Models
{
  public class Record
  {
    private static List<Record> _instances = new List<Record> {};
    public string Name { get; set; }
    public int Id { get; }
    public List<Artist> Artists {get; set; }

    public Record(string artistName)
    {
      Name = recordName;
      _instances.Add(this);
      Id = _instances.Count;
      Artists = new List<Artist>{};
    }

       public static void ClearAll()
    {
      _instances.Clear();
    }

  }
}