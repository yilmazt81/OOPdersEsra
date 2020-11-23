using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.Model
{
    public class Category
    {
        private static Category[] categories = new Category[]
        {
            new Category(1, "Bilgisayar"),
              new Category(2,"Taşınabilir"),
                    new Category(3,"Notebook")
        };
        /*
        public static readonly Category[] categories = new Category[]
        {
            new Category(1, "Bilgisayar")
            {
                SubCategory = new Category[]
                {
                    new Category(2,"Taşınabilir"),
                    new Category(3,"Notebook")
                }
            }
        };*/
        public Category()
        {
            Name = "Lütfen Giriniz";
        }

        public Category(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public int Id { get; set; }
        public string Name { get; set; }

        public Category[] SubCategory { get; set; }

        public Category GetCategory(int id)
        {
            var cate = categories.SingleOrDefault(s => s.Id == id);

            return cate;
        }

        public static Category GetCategoryStatic(int id)
        {
            var cate = categories.SingleOrDefault(s => s.Id == id);

            return cate;
        }
    }

}
