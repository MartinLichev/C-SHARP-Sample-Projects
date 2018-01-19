using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataEntity;
using DataAccessLayer;
using BusinessObjects;
using System.Data.Entity;


namespace LibrarySystem
{
    public partial class AddBookRecordPage : System.Web.UI.Page
    {
        public static LibraryDataBaseEntities entity = new LibraryDataBaseEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void AddBookRecordInDataBase(object sender, EventArgs e)
        {
            string name = this.NameTextbox.Text;
            string author = this.AuthorTextbox.Text;
            long isbn = Convert.ToInt64(this.ISBNTextbox.Text);
            int numberofpages = Convert.ToInt16(this.NumberOfPagesTextbox.Text);
            int yearofpublishing = Convert.ToInt16(this.YearOfPublishingTextbox.Text);

            BusinessObjects.Book book = new BusinessObjects.Book()
            {
                Name = name,
                Author = author,
                ISBN = isbn,
                NumberOfPages = numberofpages,
                YearOfPublishing = yearofpublishing,

            };

            var exist = entity.Books.FirstOrDefault(a => a.Name == name);

            if (exist != null)
            {
                Response.Redirect("RecordAlreadyExistsPage.aspx");
            }
            else
            {
                DataManipulation.CreateBooksRecord(book);

                Response.Redirect("RecordSuccessfullyAddedPage.aspx");
            }
        }
    }
}