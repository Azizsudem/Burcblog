using Microsoft.AspNetCore.Mvc;
using System;

public class UserController : Controller
{
    [HttpGet]
    public IActionResult Profile(string firstName, string lastName, DateTime birthDate)
    {
        // Kullanıcı bilgilerini işleme
        var user = new User
        {
            FirstName = firstName,
            LastName = lastName,
            BirthDate = birthDate,
            ZodiacSign = CalculateZodiacSign(birthDate)
        };

        return View(user);
    }

    private string CalculateZodiacSign(DateTime date)
    {
        int month = date.Month;
        int day = date.Day;

        if ((month == 1 && day >= 20) || (month == 2 && day <= 18)) return "Kova";
        if ((month == 2 && day >= 19) || (month == 3 && day <= 20)) return "Balık";
        if ((month == 3 && day >= 21) || (month == 4 && day <= 19)) return "Koç";
        if ((month == 4 && day >= 20) || (month == 5 && day <= 20)) return "Boğa";
        if ((month == 5 && day >= 21) || (month == 6 && day <= 20)) return "İkizler";
        if ((month == 6 && day >= 21) || (month == 7 && day <= 22)) return "Yengeç";
        if ((month == 7 && day >= 23) || (month == 8 && day <= 22)) return "Aslan";
        if ((month == 8 && day >= 23) || (month == 9 && day <= 22)) return "Başak";
        if ((month == 9 && day >= 23) || (month == 10 && day <= 22)) return "Terazi";
        if ((month == 10 && day >= 23) || (month == 11 && day <= 21)) return "Akrep";
        if ((month == 11 && day >= 22) || (month == 12 && day <= 21)) return "Yay";
        if ((month == 12 && day >= 22) || (month == 1 && day <= 19)) return "Oğlak";

        return "Bilinmiyor"; // Varsayılan değer
    }
}
