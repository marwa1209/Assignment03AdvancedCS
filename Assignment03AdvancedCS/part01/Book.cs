using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03AdvancedCS.part01
{
    public class Book
    {
        #region Properties
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string[] Authors { get; set; }
        public DateTime PublicationDate { get; set; }
        public decimal Price { get; set; }
        #endregion

        #region Constructor
        public Book(string iSBN, string title, string[] authors, DateTime publicationDate, decimal price)
        {
            ISBN = iSBN;
            Title = title;
            Authors = authors;
            PublicationDate = publicationDate;
            Price = price;
        }
        #endregion

        #region Methods

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(Authors[0]);

            for (int i = 1; i < Authors.Length; i++)
            {
                sb.Append(", ");
                sb.Append(Authors[i]);
            }

            return $"ISBN: {ISBN}\nTitle: {Title}\nAuthors: {sb}\nPublication Date: {PublicationDate}\nPrice: {Price}";

        }

        #endregion
    }
}
