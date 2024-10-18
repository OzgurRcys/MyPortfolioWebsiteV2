using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.ViewComponents
{
    public class _StatisticComponentPartical : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
