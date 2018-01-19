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
    public partial class UpdateBookRecordPage : System.Web.UI.Page
    {
        public static LibraryDataBaseEntities entity = new LibraryDataBaseEntities();
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void UpdateBookRecordInDataBase(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(this.BookIDTextbox.Text);
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

            DataManipulation.UpdateBooksRecord(book, id);

            Response.Redirect("RecordSuccessfullyUpdatedPage.aspx");
        }
    }
}





