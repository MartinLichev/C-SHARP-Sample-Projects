using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataEntity;
using DataAccessLayer;
using System.Data.Entity;

namespace LibrarySystem
{
    public partial class UpdateTenantRecordPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void UpdateTenantRecordInDataBase(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(this.TenantIDTextbox.Text);
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

            DataManipulation.UpdateTenantsRecord(tenant, id);

            Response.Redirect("RecordSuccessfullyUpdatedPage.aspx");
        }
    }
}
 
