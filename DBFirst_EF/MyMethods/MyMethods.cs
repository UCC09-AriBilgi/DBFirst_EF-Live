using DBFirst_EF.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace DBFirst_EF.MyMethods
{
    public class MyMethods
    {
        public MyMethods() 
        { 
        
        }

        public dynamic ToSelectList(DbSet<Category> categories, string valueField, string textField)
        {
            // View tarafına gidecek olan Category listesi hazırlanıyor
            List<SelectListItem> list = new List<SelectListItem>();

            // liste oluşuyor
            foreach (var item in categories)
            {
                list.Add(new SelectListItem()
                {
                    Text = item.CategoryName,
                    Value = item.CategoryId.ToString()
                });
            }


            return new SelectList(list, "Value", "Text");
        }
    }
}
