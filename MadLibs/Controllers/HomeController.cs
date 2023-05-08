using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;
using System.Collections.Generic;
using System.Linq;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Home()
    {
      return View();
    }

    [Route("/form")]
    public ActionResult Form(string madlib)
    {
      StoryVariable.Madlib = madlib;
      return View();
    }

    [Route("/punch")]
    public ActionResult Punch(string[] inputs)
    {
      StoryVariable newStory = new StoryVariable();
      for (int i = 0; i < inputs.Length; i++)
      {
        KeyValuePair<string, string> word = newStory.StoryList.ElementAt(i);
        newStory.StoryList[word.Key] = inputs[i];
      }
      return View(newStory);
    }
  }
}