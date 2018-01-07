using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Entity;
using DataEntity;
using DataAccessLayer;
using BusinessObjects;

namespace FurnituresOrdersSystem
{
    public partial class FurnituresAndOrdersHomePage : System.Web.UI.Page
    {
        public static FurnituresAndOrdersDataBaseEntities entity = new FurnituresAndOrdersDataBaseEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
           


        }


        protected void CreateRecord(object sender, EventArgs e)
        {
            Response.Redirect("CreateRecordPage.aspx");
        }
    }
}



 





        




 