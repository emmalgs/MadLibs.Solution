using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Form() { return View(); }
    [Route("/story")]
    public ActionResult Story(string noun, string adjective, string noun) 
    {
      StoryVariable newStory = new StoryVariable();
      newStory.Noun = noun;
      newStory.Adjective = adjective;
      return View(newStory);
    }
  }
}