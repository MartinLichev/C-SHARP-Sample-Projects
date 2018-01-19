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
    public partial class UpdateAuthorRecordPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void UpdateAuthorRecordInDataBase(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(this.AuthorIDTextbox.Text);
            string name = this.NameTextbox.Text;
            string gender = this.GenderTextbox.Text;
            int yearofbirth = Convert.ToInt16(this.YearOfBirthTextbox.Text);

            BusinessObjects.Author author = new BusinessObjects.Author()
            {
                Name = name,
                Gender = gender,
                YearOfBirth = yearofbirth,
            };

            DataManipulation.UpdateAuthorsRecord(author, id);

            Response.Redirect("RecordSuccessfullyUpdatedPage.aspx");
        }
    }
}