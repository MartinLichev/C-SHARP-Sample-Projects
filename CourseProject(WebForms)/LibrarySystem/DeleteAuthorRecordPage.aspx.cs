using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Entity;
using DataAccessLayer;
using DataEntity;

namespace LibrarySystem
{
    public partial class DeleteAuthorRecordPage : System.Web.UI.Page
    {
        public static LibraryDataBaseEntities entity = new LibraryDataBaseEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DeleteAuthorRecordFromDataBase(object sender, EventArgs e)
        {
            string name = this.NameTextbox.Text;

            var result = entity.Authors.FirstOrDefault(a => a.Name == name);

            if (result != null)
            {

                DataManipulation.DeleteAuthorsRecord(name);

                Response.Redirect("RecordSuccessfullyDeletedPage.aspx");
            }
            else
            {
                Response.Redirect("NoSuchRecordExistsPage.aspx");
            }



        }
    }
}