using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Entity;
using DataAccessLayer;
using BusinessObjects;
using DataEntity;


namespace LibrarySystem
{
    public partial class DeleteBookRecordPage : System.Web.UI.Page
    {
        public static LibraryDataBaseEntities entity = new LibraryDataBaseEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DeleteBookRecordFromDataBase(object sender, EventArgs e)
        {
            string name = this.NameTextbox.Text;

            var result = entity.Books.FirstOrDefault(a => a.Name == name);

            if (result != null)
            {

                DataManipulation.DeleteBooksRecord(name);

                Response.Redirect("RecordSuccessfullyDeletedPage.aspx");
            }
            else
            {
                Response.Redirect("NoSuchRecordExistsPage.aspx");
            }


            
        }
    }
}