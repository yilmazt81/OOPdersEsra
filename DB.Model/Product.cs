using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.Model
{
    public class Product
    {
        public static readonly string BosAd = "Yok";
        public static   float _MinTax = (float)0.18;

        public Product()
        {
            Name = BosAd;
            Tax = _MinTax;
        }
        public int Id { get; set; }
        public string Name { get; set; }

        public float Price { get; set; }
        public bool Active { get; set; }
        public int StocAdet { get; set; }
        public float Tax { get; set; }


        public Category MainCategory { get; set; }
        public Category Category { get; set; }
        public Category SubCategory { get; set; }

        public static string WriteProduc(Product product)
        {
            return product.Id + " " + product.Name + " " + product.MainCategory.Name;
        }
        public static float KDVDahil(Product product)
        {
            return product.Price +( product.Price * product.Tax);
        }

    }

}
