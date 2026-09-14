using Microsoft.AspNetCore.Mvc;
using TvcLesson05ViewComponents.Models;

namespace TvcLesson05ViewComponents.ViewComponents
{
    public class TvcCategoryViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke(bool? active)
        {
            var categories =  new List<TvcCategory>
            {
                new TvcCategory(){ CategoryId =1, CategoryName="Điện gia dụng", IsActive=true },
                new TvcCategory(){CategoryId=2,CategoryName="Iphone ", IsActive=true },
                new TvcCategory(){CategoryId=3,CategoryName="Làm đẹp ", IsActive=true },
                new TvcCategory(){CategoryId=4,CategoryName="Điện tử ", IsActive=false },

            };

            if(active != null)
            {
                categories = categories.Where(x => x.IsActive == active.Value).ToList();
            }
            return View(categories);
        } 
    }
}
