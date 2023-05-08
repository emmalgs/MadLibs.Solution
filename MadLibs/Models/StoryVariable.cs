using System.Collections.Generic;

namespace MadLibs.Models

{
  public class StoryVariable
  {
    public static string Madlib { get; set; }
    public Dictionary<string, string> StoryList { get; set; } = new Dictionary<string, string> () 
    {
      {"foodnoun", ""},
      {"adjective", ""},
      {"adjective2", ""},
      {"bodypart", ""},
      {"verbpast", ""},
      {"gerund", ""},
      {"verb", ""},
      {"propernoun", ""},
      {"gerund2", ""},
      {"noun3", ""},
      {"pastparticiple", ""},

    };
  }
}