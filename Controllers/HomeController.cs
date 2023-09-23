using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var studentInfoArray = new[]
        {
            new StudentInfoModel { Name = "Bramie Baybayon", StudentId = "S001", StudentAge = "16" },
            new StudentInfoModel { Name = "Danilo Mirador", StudentId = "S002", StudentAge = "18" },
            new StudentInfoModel { Name = "Therese Santos", StudentId = "S003", StudentAge = "22" }
        };

        return View(studentInfoArray);
    }
}
