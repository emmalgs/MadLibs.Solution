using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Form(string action) { return View(); }

    [Route("/punch")]
    public ActionResult Story(params string[] inputs) 
    {
      StoryVariable newStory = new StoryVariable();
      foreach (string input in inputs)
      {
        newStory.StoryList.Add(input);
      }
      return View(newStory);
    }
  }
}