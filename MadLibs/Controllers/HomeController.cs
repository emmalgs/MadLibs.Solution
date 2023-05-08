using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Form(string action) { return View(); }

    [Route("/punch")]
    public ActionResult Story(string[] inputs, string [] id) 
    {
      StoryVariable newStory = new StoryVariable();
      for (int i = 0; i < inputs.Length; i ++)
      {
        newStory.StoryDict.Add(id[i], inputs[i]);
      }
      return View(newStory);
    }
  }
}