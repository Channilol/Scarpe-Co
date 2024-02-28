using Microsoft.AspNetCore.Mvc;
using Scarpe_Co.Models;

namespace Scarpe_Co.Controllers
{
    public class DetailsController : Controller
    {
        [HttpGet]
        public IActionResult Index([FromRoute] int? id)
        {
            if (id.HasValue)
            {
                return View(StaticDB.GetById(id));
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(int Id, string Name, string Description, string BgImgUrl, string ImgUrl, string ImgUrl2, string ImgUrl3, decimal Price)
        {
            var prodotto = StaticDB.Add(Id, Name, Description, BgImgUrl, ImgUrl, ImgUrl2, ImgUrl3, Price);
            return RedirectToAction("Index");
        }

        public IActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Edit(int Id, string Name, string Description, string BgImgUrl, string ImgUrl, string ImgUrl2, string ImgUrl3, decimal Price)
        {
            var prodotto = StaticDB.Edit(Id, Name, Description, BgImgUrl, ImgUrl, ImgUrl2, ImgUrl3, Price);
            return RedirectToAction("Index");
        }

        public IActionResult Delete()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Delete(int Id)
        {
            var prodotto = StaticDB.Delete(Id);
            return RedirectToAction("Index");
        }

    }
}
