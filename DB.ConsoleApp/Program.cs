using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DB.Model;
using DB.Layer.SQL;

namespace DB.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Form form = new Form
            {
                Text = "Deneme"
            };
            Button button = new Button();
            button.Text = "Deneme";
            button.Click += Button_Click;
            form.Controls.Add(button);
            form.ShowDialog();
            */
            /*
            Category[] categories = new Category[3];
            categories[0] = new Category(2, "Taşınabilir")
            {
                SubCategory = new Category[] {
                    new Category(),
                    new Category() }
            };
            categories[1] = new Category();

            Category category = new Category()
            {
                Id = 1,
                Name = "Bilgisayar",
                SubCategory = new Category[] {new Category(2,"Taşınabilir"),new Category(3,"Notebook")}
            };
            Console.WriteLine(categories[2].Name);
            */

            var cat = Category.GetCategoryStatic(1);
            Category category = new Category();
            var cat2 = category.GetCategory(1);
            Product._MinTax = (float)0.01;
            Product product = new Product();
            product.Price = 100;
            product.Name = "I7 Notebook";
            product.MainCategory = new Category(1, "Bilgisayar");
            product.Category = new Category(3, "Taşınabilir");
            product.SubCategory = new Category(2, "Notebook");
            var proname = Product.WriteProduc(product);
            var taxWithPrie = Product.KDVDahil(product);

        }

        private static void Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }
    }
}
