using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PatikaLibrary
{
    //Book adında nesne oluşturuyoruz.
    internal class Book
    {
        private string _bookName;
        private string _authorName;
        private string _authorSurname;
        private int _numberOfPages;
        private string _publishingHouse;
        private DateTime _registrationDate;

        //Parametresiz Constructorımızı tanımlıyoruz.
        public Book()
        {
            //Parametresiz olduğu için burada tanımlama yapmadık.
                        
        }

        //Parametreli Constructorımızı tanımlıyoruz.
        public Book(string bookName, string authorName, string authorSurname, int numberOfPages, string publishingHouse)
        {
            //Parametreli olduğu için burada tanımlama yaptık.
            _bookName = bookName;
            _authorName = authorName;
            _authorSurname = authorSurname;
            _numberOfPages = numberOfPages;
            _publishingHouse = publishingHouse;
            _registrationDate = DateTime.Now;
        }


        //Propertyleri oluşturuyoruz. Encapsulation yapıyoruz.
        public string BookName{
            get{ return _bookName; }
            set{ _bookName = value; }
            }

        public string AuthorName
        {
            get { return _authorName; }
            set { _authorName = value; }
        }

        public string AuthorSurname
        {
            get { return _authorSurname; }
            set { _authorSurname = value; }
        }

        public int NumberOfPages
        {
            get { return _numberOfPages; }
            set { _numberOfPages = value; }
        }

        public string PublishingHouse
        {
            get { return _publishingHouse; }
            set { _publishingHouse = value; }
        }

        public DateTime RegistrationDate
        {
            get { return _registrationDate; }
            set { _registrationDate = value; }
        }





    }
}
