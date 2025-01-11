using PatikaLibrary;

Book book1 = new Book();
book1.BookName = "Adı Aylin";
book1.AuthorName = "Ayşe";
book1.AuthorSurname = "Kulin";
book1.PublishingHouse = "Remzi";
book1.NumberOfPages = 398;
book1.RegistrationDate = DateTime.Now;

Console.WriteLine($"{book1.BookName} adlı kitap {book1.AuthorName} {book1.AuthorSurname} yazarı {book1.NumberOfPages} sayfa sayısı ve " +
    $"{book1.PublishingHouse} Yayınevi ile {book1.RegistrationDate.Date.ToString("dd.MM.yyyy")} Kayıt tarihinde Patika Kütüphanesine kaydedilmiştir.");

Book book2 = new Book("Duyarlılıktan Doğan Güç", "Jane", "Novak", 181, "SERENAD");
Console.WriteLine($"{book2.BookName} adlı kitap {book2.AuthorName} {book2.AuthorSurname} yazarı {book2.NumberOfPages} sayfa sayısı ve " +
    $"{book2.PublishingHouse} Yayınevi ile {book2.RegistrationDate.Date.ToString("dd.MM.yyyy")} Kayıt tarihinde Patika Kütüphanesine kaydedilmiştir.");