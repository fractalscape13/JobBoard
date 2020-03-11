using System.Collections.Generic;

namespace JobBoard.Models
{
  public class JobOpening
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public string Info { get; set; }
    public int Id { get; set; }
    private static  List<JobOpening> _instances = new List<JobOpening> {}; 
    
    public JobOpening(string title, string description, string info)
    {
    _instances.Add(this);
    Title = title;
    Description = description;
    Info = info;
    Id = _instances.Count;
    }
    public static List<JobOpening> GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static JobOpening Find(int searchId)
    {
      return _instances[searchId - 1];
    }
    public static void RemoveItem(int searchId)
    {
      _instances.RemoveAt(searchId-1);
    }
  }
}