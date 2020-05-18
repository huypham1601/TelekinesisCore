using System.Collections.Generic;
using TelekinesisCoreApp.Application.ViewModels.Blog;
using TelekinesisCoreApp.Application.ViewModels.Common;
using TelekinesisCoreApp.Application.ViewModels.Product;

namespace TelekinesisCoreApp.Models
{
    public class HomeViewModel
    {
        public List<BlogViewModel> LastestBlogs { get; set; }
        public List<SlideViewModel> HomeSlides { get; set; }
        public List<ProductViewModel> HotProducts { get; set; }
        public List<ProductViewModel> TopSellProducts { get; set; }

        public List<ProductCategoryViewModel> HomeCategories { set; get; }

        public string Title { set; get; }
        public string MetaKeyword { set; get; }
        public string MetaDescription { set; get; }
    }
}
