using System.Reflection;
using System.Text;
using Newtonsoft.Json;

namespace CSharp.VCardCreation.Models;

public class RequestApi
{
    // API'den belirtilen sayıda kullanıcı bilgisi isteyen metot
    static public async Task RequestFromApi(int userCount)
    {
        // Eğer istenilen kullanıcı sayısı 5000'den fazlaysa Exception firlatir, sitenin kendisinde de bu belirtiliyor
        if (userCount > 5000)
        {
            throw new ExceptionHandling.UserLimitException("En fazla 5000 kullanici yaratabilirsiniz.");
        }

        try
        {
            string requestUrl = $"https://randomuser.me/api/?results={userCount}";
            using HttpClient client = new HttpClient();
            using HttpResponseMessage response = await client.GetAsync(requestUrl);
            response.EnsureSuccessStatusCode(); // Eger API'ye request atmak basarisizsa HTTPRequestException firlatiyor
            string responseBody = await response.Content.ReadAsStringAsync();
            ResponseApi apiResult = JsonConvert.DeserializeObject<ResponseApi>(responseBody);

            Console.WriteLine($"Toplam olusturulan kullanici sayisi: {apiResult.Results.Count}");
            Console.WriteLine();
            foreach (var employees in apiResult.Results)
            {
                Console.WriteLine($"ID: {employees.Login.Uuid}");
                Console.WriteLine($"Isim: {employees.Name.First} {employees.Name.Last}");
                Console.WriteLine($"Mail: {employees.Email}");
                Console.WriteLine($"Phone: {employees.Phone}");
                Console.WriteLine($"Ulke: {employees.Location.Country}");
                Console.WriteLine($"Sehir: {employees.Location.City}");
                Console.WriteLine();

                VCardCreation.updateVCardContents(
                    employees.Name.First,
                    employees.Name.Last,
                    employees.Email,
                    employees.Phone,
                    employees.Login.Uuid,
                    employees.Location.Country,
                    employees.Location.City);
            }
        }
        catch (Exception)
        {
            throw;
        }
    }
}