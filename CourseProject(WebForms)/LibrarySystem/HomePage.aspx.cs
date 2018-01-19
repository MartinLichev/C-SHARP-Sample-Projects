using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibrarySystem
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RedirectToAddAuthorRecordPage(object sender, EventArgs e)
        {
            Response.Redirect("AddAuthorRecordPage.aspx");
        }

        protected void RedirectToAddTenantRecordPage(object sender, EventArgs e)
        {
            Response.Redirect("AddTenantRecordPage.aspx");
        }



        protected void RedirectToAddBookRecordPage(object sender, EventArgs e)
        {
            Response.Redirect("AddBookRecordPage.aspx");
        }

        protected void RedirectToDeleteBookRecordPage(object sender, EventArgs e)
        {
            Response.Redirect("DeleteBookRecordPage.aspx");
        }

        protected void RedirectToDeleteAuthorRecordPage(object sender, EventArgs e)
        {
            Response.Redirect("DeleteAuthorRecordPage.aspx");
        }

        protected void RedirectToDeleteTenantRecordPage(object sender, EventArgs e)
        {
            Response.Redirect("DeleteTenantRecordPage.aspx");
        }

        protected void RedirectToUpdateBookRecordPage(object sender, EventArgs e)
        {
            Response.Redirect("UpdateBookRecordPage.aspx");
        }

        protected void RedirectToUpdateAuthorRecordPage(object sender, EventArgs e)
        {
            Response.Redirect("UpdateAuthorRecordPage.aspx");
        }

        protected void RedirectToUpdateTenantRecordPage(object sender, EventArgs e)
        {
            Response.Redirect("UpdateTenantRecordPage.aspx");
        }
    }
}