using Assignment.DataAccess;
using Assignment.DataAccess.Entities;
using MySql.Data.MySqlClient;

namespace Assignment.Services
{
    public class ProductService
    {
        public ProductService()
        {
        }
        public void AddProduct(Product product)
        {
        }

        public static string GenerateRandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static decimal GenerateRandomDecimal()
        {
            Random random = new Random();
            return new decimal(random.NextDouble());
        }

        public static DateTime GenerateRandomDate(DateTime startDate, DateTime endDate)
        {
            Random random = new Random();
            int range = (endDate - startDate).Days;
            return startDate.AddDays(random.Next(range));
        }
        public static string GenerateRandomEmail()
        {
            // Generate a random name part
            string randomName = GenerateRandomString(8); // You can adjust the length as needed

            // Combine the name and domain to form the email
            string randomEmail = randomName + "@" + "gmail.com";

            return randomEmail;
        }
        public static string GetRandomImageUrl()
        {
            List<string> imageUrls = new List<string>
        {
            "https://example.com/image1.jpg",
            "https://example.com/image2.jpg",
            "https://example.com/image3.jpg"
        };
            Random random = new Random();
            int randomIndex = random.Next(imageUrls.Count);
            return imageUrls[randomIndex];
        }
        public static int GenerateRandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max + 1);
        }
    }
}

