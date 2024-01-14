using System;
using System.Data.SqlClient;
namespace Module_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            string connectionString = "Data Source=LAPTOP-2;Initial Catalog=promotion_list;Integrated Security=True;Connect Timeout=30;Encrypt=False";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Database connection successful!");
                    DisplayCustomers(connection);
                    DisplayCustomerEmails(connection);
                    DisplayPromotions(connection);
                    DisplayCities(connection);
                    DisplayCountries(connection);
                    DisplayCustomersByCity(connection, "Kyiv");
                    DisplayCustomersByCountry(connection, "Ukraine");
                    DisplayPromotionsByCountry(connection, "Ukraine");
                    InsertNewCustomer(connection, "John Doe", "1990-01-01", "john.doe@email.com", "Kyiv", "Ukraine");
                    InsertNewCountry(connection, "Germany");
                    InsertNewCity(connection, "Berlin", "Germany");
                    InsertNewSection(connection, "Electronics");
                    InsertNewPromotionalProduct(connection, "Smartphone", "Electronics", "2024-01-15", "2024-01-30");

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Connection error: {ex.Message}");
                }
            }
            Console.ReadLine();
        }
        static void InsertNewCustomer(SqlConnection connection, string fullName, string birthDate, string email, string city, string country)
        {
            using (SqlCommand command = new SqlCommand("INSERT INTO Customers (FullName, BirthDate, Email, City, Country) VALUES (@FullName, @BirthDate, @Email, @City, @Country)", connection))
            {
                command.Parameters.AddWithValue("@FullName", fullName);
                command.Parameters.AddWithValue("@BirthDate", birthDate);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@City", city);
                command.Parameters.AddWithValue("@Country", country);
                command.ExecuteNonQuery();
                Console.WriteLine("New customer inserted successfully.");
            }
        }
        static void InsertNewCountry(SqlConnection connection, string countryName)
        {
            using (SqlCommand command = new SqlCommand("INSERT INTO Countries (CountryName) VALUES (@CountryName)", connection))
            {
                command.Parameters.AddWithValue("@CountryName", countryName);
                command.ExecuteNonQuery();
                Console.WriteLine("New country inserted successfully.");
            }
        }
        static void InsertNewCity(SqlConnection connection, string cityName, string country)
        {
            using (SqlCommand command = new SqlCommand("INSERT INTO Cities (CityName, Country) VALUES (@CityName, @Country)", connection))
            {
                command.Parameters.AddWithValue("@CityName", cityName);
                command.Parameters.AddWithValue("@Country", country);
                command.ExecuteNonQuery();
                Console.WriteLine("New city inserted successfully.");
            }
        }
        static void InsertNewSection(SqlConnection connection, string sectionName)
        {
            using (SqlCommand command = new SqlCommand("INSERT INTO Sections (SectionName) VALUES (@SectionName)", connection))
            {
                command.Parameters.AddWithValue("@SectionName", sectionName);
                command.ExecuteNonQuery();
                Console.WriteLine("New section inserted successfully.");
            }
        }
        static void InsertNewPromotionalProduct(SqlConnection connection, string productName, string section, string startDate, string endDate)
        {
            using (SqlCommand command = new SqlCommand("INSERT INTO PromotionalProducts (ProductName, Section, StartDate, EndDate) VALUES (@ProductName, @Section, @StartDate, @EndDate)", connection))
            {
                command.Parameters.AddWithValue("@ProductName", productName);
                command.Parameters.AddWithValue("@Section", section);
                command.Parameters.AddWithValue("@StartDate", startDate);
                command.Parameters.AddWithValue("@EndDate", endDate);
                command.ExecuteNonQuery();
                Console.WriteLine("New promotional product inserted successfully.");
            }
        }
        static void DisplayCustomersByCity(SqlConnection connection, string city)
        {
            Console.WriteLine($"\nList of Customers in {city}:");
            using (SqlCommand command = new SqlCommand("SELECT * FROM Customers WHERE City = @City", connection))
            {
                command.Parameters.AddWithValue("@City", city);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"CustomerID: {reader["CustomerID"]}, FullName: {reader["FullName"]}, BirthDate: {reader["BirthDate"]}");
                    }
                }
            }
        }
        static void DisplayCustomersByCountry(SqlConnection connection, string country)
        {
            Console.WriteLine($"\nList of Customers in {country}:");
            using (SqlCommand command = new SqlCommand("SELECT * FROM Customers WHERE Country = @Country", connection))
            {
                command.Parameters.AddWithValue("@Country", country);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"CustomerID: {reader["CustomerID"]}, FullName: {reader["FullName"]}, BirthDate: {reader["BirthDate"]}");
                    }
                }
            }
        }
        static void DisplayPromotionsByCountry(SqlConnection connection, string country)
        {
            Console.WriteLine($"\nList of Promotions in {country}:");
            using (SqlCommand command = new SqlCommand("SELECT * FROM Promotions WHERE Country = @Country", connection))
            {
                command.Parameters.AddWithValue("@Country", country);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"PromotionID: {reader["PromotionID"]}, StartDate: {reader["StartDate"]}, EndDate: {reader["EndDate"]}");
                    }
                }
            }
        }
        static void DisplayCountries(SqlConnection connection)
        {
            Console.WriteLine("\nList of Countries:");
            using (SqlCommand command = new SqlCommand("SELECT DISTINCT Country FROM Customers", connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"Country: {reader["Country"]}");
                    }
                }
            }
        }
        static void DisplayCustomers(SqlConnection connection)
        {
            Console.WriteLine("\nList of Customers:");
            using (SqlCommand command = new SqlCommand("SELECT * FROM Customers", connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"CustomerID: {reader["CustomerID"]}, FullName: {reader["FullName"]}, BirthDate: {reader["BirthDate"]}");
                    }
                }
            }
        }
        static void DisplayCustomerEmails(SqlConnection connection)
        {
            Console.WriteLine("\nList of Customer Emails:");
            using (SqlCommand command = new SqlCommand("SELECT Email FROM Customers", connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"Email: {reader["Email"]}");
                    }
                }
            }
        }
        static void DisplayPromotions(SqlConnection connection)
        {
            Console.WriteLine("\nList of Promotions:");
            using (SqlCommand command = new SqlCommand("SELECT * FROM Promotions", connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"PromotionID: {reader["PromotionID"]}, Country: {reader["Country"]}, StartDate: {reader["StartDate"]}, EndDate: {reader["EndDate"]}");
                    }
                }
            }
        }
        static void DisplayCities(SqlConnection connection)
        {
            Console.WriteLine("\nList of Cities:");
            using (SqlCommand command = new SqlCommand("SELECT DISTINCT City FROM Customers", connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"City: {reader["City"]}");
                    }
                }
            }
        }
    }
}