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

namespace LibrarySystem
{
    public partial class AddAuthorRecordPage : System.Web.UI.Page
    {
        public static LibraryDataBaseEntities entity = new LibraryDataBaseEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void AddAuthorRecordInDataBase(object sender, EventArgs e)
        {
            string name = this.NameTextbox.Text;
            string gender = this.GenderTextbox.Text;
            int yearofbirth = Convert.ToInt32(this.YearOfBirthTextbox.Text);


            BusinessObjects.Author author = new BusinessObjects.Author()
            {
                Name = name,
                Gender = gender,
                YearOfBirth = yearofbirth,
                


            };

            var exist = entity.Authors.FirstOrDefault(a => a.Name == name);

            if (exist != null)
            {
                Response.Redirect("RecordAlreadyExistsPage.aspx");
            }
            else
            {
                DataManipulation.CreateAuthorsRecord(author);

                Response.Redirect("RecordSuccessfullyAddedPage.aspx");
            }
        }
    }
}


