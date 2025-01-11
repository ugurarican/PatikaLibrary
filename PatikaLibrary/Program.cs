using PatikaLibrary;


// Burada Book nesnesini oluşturuyoruz ve book1'e atıyoruz.
//Parametresiz counstructor kullandığımız için değişkenleri tek tek tanımlıyoruz.
Book book1 = new Book();
book1.BookName = "Adı Aylin";
book1.AuthorName = "Ayşe";
book1.AuthorSurname = "Kulin";
book1.PublishingHouse = "Remzi";
book1.NumberOfPages = 398;
book1.RegistrationDate = DateTime.Now;


Console.WriteLine("Kitap Adı: " + book1.BookName +
                  "\nYazar Adı, Soyadı : " + book1.AuthorName + " " + book1.AuthorSurname +
                  "\nSayfa Sayısı: " + book1.NumberOfPages +
                  "\nYayınevi: " + book1.PublishingHouse +
                  "\nKayıt Tarihi: " + book1.RegistrationDate.Date.ToString("dd.MM.yyyy"));

Console.WriteLine("                                               " +
                  "\n---------------------------------------------" +
                  "\n                                             ");

// Burada Book nesnesini oluşturuyoruz ve book2'e atıyoruz.
//Parametreli counstructor kullandığımız için değişkenleri parametre olarak veriyoruz.
Book book2 = new Book("Adı Aylin", "Ayşe", "Kulin", 398, "Remzi");

Console.WriteLine("Kitap Adı: " + book2.BookName +
                  "\nYazar Adı, Soyadı : " + book2.AuthorName + " " + book1.AuthorSurname +
                  "\nSayfa Sayısı: " + book2.NumberOfPages +
                  "\nYayınevi: " + book2.PublishingHouse +
                  "\nKayıt Tarihi: " + book2.RegistrationDate.Date.ToString("dd.MM.yyyy"));