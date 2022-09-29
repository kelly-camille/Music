
using System.Collections.Generic;

namespace Music.Models
{
  public class Artist
  {
    public string ArtistName { get; set;}
    public int Id {get; }
    private static List<Artist> _instances = new List<Artist> {};

    public Artist(string artistname)
    {
      ArtistName = artistname;
      _instances.Add(this);
      Id = _instances.Count;
    }

    // public static void GetAll()
    // {
    //   return _instances;
    // }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Artist Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}