using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult SaveData(string data, DateTime expirationDate)
    {
        //для демонстрації логування помилочки
        string nullData = null;
        var length = nullData.Length;

        TempData["UserData"] = data;
        return RedirectToAction("DisplayData");
    }

    public IActionResult DisplayData()
    {
        string userData = TempData["UserData"] as string;
        TempData.Remove("UserData");
        return View("UserData", userData);
    }
}
