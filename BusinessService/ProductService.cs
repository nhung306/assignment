using AutoMapper;
using BusinessService.Contracts;
using DataAccess;
using DataAccess.Entities;

namespace BusinessService
{
    public class ProductService :BaseService, IProductService
    {
        public ProductService(AssignmentDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }

        public void AddProduct(Product product)
        {

        }


        public void RandomInsertCustomer()
        {
            try
            {
                _dbContext.Database.EnsureCreated();

                // Number of random records to insert
                int numberOfRecords = 10;

                for (int i = 0; i < numberOfRecords; i++)
                {
                    // Generate random data
                    string randomString = GenerateRandomString(10); // Adjust the length as needed
                    int randomNumber = GenerateRandomNumber(1, 100);
                    DateTime randomDateTime = GenerateRandomDate(new DateTime(1950, 1, 1), new DateTime(2020, 12, 31));
                    string randomEmail = GenerateRandomEmail();

                    var customer = new Customer()
                    {
                        FullName = GenerateRandomString(10),
                        DateOfBirth = GenerateRandomDate(new DateTime(1950, 1, 1), new DateTime(2020, 12, 31)),
                        Email = GenerateRandomEmail()
                    };


                    _dbContext.Add(customer);

                    int rowsAffected = _dbContext.SaveChanges();
                    Console.WriteLine($"Inserted {rowsAffected} rows into the table.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        public static string GenerateRandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static int GenerateRandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max + 1);
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

    }
}