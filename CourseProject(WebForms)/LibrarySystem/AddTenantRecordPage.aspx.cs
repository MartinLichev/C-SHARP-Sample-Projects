using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Entity;
using DataEntity;
using BusinessObjects;
using DataAccessLayer;


namespace LibrarySystem
{
    public partial class AddTenantRecord : System.Web.UI.Page
    {
        public static LibraryDataBaseEntities entity = new LibraryDataBaseEntities();
    
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void AddTenantRecordInDataBase(object sender, EventArgs e)
        {
            string name = this.NameTextbox.Text;
            long idcard = Convert.ToInt64(this.IDCardTextbox.Text);
            long uniquecitizenshipnumber = Convert.ToInt64(this.UniqueCitizenshipNumberTextbox.Text);
            string address = this.AddressTextBox.Text;
            string gender = this.GenderTextBox.Text;
            long phonenumber = Convert.ToInt64(this.PhoneTextBox.Text);
            string email = this.EmailTextBox.Text;
            


            BusinessObjects.Tenant tenant = new BusinessObjects.Tenant()
            {
                Name = name,
                IDCard = idcard,
                UniqueCitizenshipNumber = uniquecitizenshipnumber,
                Address = address,
                Gender = gender,
                PhoneNumber = phonenumber,
                Email = email,
                


            };

            var exist = entity.Tenants.FirstOrDefault(a => a.Name == name);

            if (exist != null)
            {
                Response.Redirect("RecordAlreadyExistsPage.aspx");
            }
            else
            {
                DataManipulation.CreateTenantsRecord(tenant);

                Response.Redirect("RecordSuccessfullyAddedPage.aspx");
            }
        }
    }
}