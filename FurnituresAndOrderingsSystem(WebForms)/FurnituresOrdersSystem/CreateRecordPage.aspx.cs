using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;
using BusinessObjects;
using DataEntity;

namespace FurnituresOrdersSystem
{
    public partial class CreateRecordPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void CreateRecord(object sender, EventArgs e)
        {
            string name = this.NameText.Text;
            string description = this.DescriptionText.Text;
            int height = Convert.ToInt32(this.HeightText.Text);
            int width = Convert.ToInt32(this.WidthText.Text);
            string countryoforigin = this.CountryOfOriginText.Text;

            BusinessObjects.Order order = new BusinessObjects.Order
            {
                Name = name,

                Description = description,

                Height = height,

                Width = width,

                CountryOfOrigin = countryoforigin,

            };


            DataManipulation.CreateOrdersRecord(order);

            Response.Redirect("RecordSuccessfullyAddedPage.aspx");
            
        }
    }
}