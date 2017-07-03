using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DZ3
{
    public partial class Warehouse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Category = TextBoxCategory.Text;
            product.Name = TextBoxName.Text;
            product.Price = double.Parse(TextBoxPrice.Text);

            using (MyContext context = new MyContext())
            {
                ProductRepository productRepository = new ProductRepository(context);
                productRepository.Create(product);
            }

            Response.Redirect("WebForm1.aspx");
        }
    }
}