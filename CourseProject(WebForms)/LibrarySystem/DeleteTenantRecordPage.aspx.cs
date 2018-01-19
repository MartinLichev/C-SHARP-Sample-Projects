using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Entity;
using DataEntity;
using DataAccessLayer;

namespace LibrarySystem
{
    public partial class DeleteTenantRecordPage : System.Web.UI.Page
    {
        public static LibraryDataBaseEntities entity = new LibraryDataBaseEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DeleteTenantRecordFromDataBase(object sender, EventArgs e)
        {
            string name = this.NameTextbox.Text;

            var result = entity.Tenants.FirstOrDefault(a => a.Name == name);

            if (result != null)
            {

                DataManipulation.DeleteTenantsRecord(name);

                Response.Redirect("RecordSuccessfullyDeletedPage.aspx");
            }
            else
            {
                Response.Redirect("NoSuchRecordExistsPage.aspx");
            }



        }
    }
}