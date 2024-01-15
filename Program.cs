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
                    //DisplayCustomers(connection);
                    //DisplayCustomerEmails(connection);
                    //DisplayPromotions(connection);
                    //DisplayCities(connection);
                    //DisplayCountries(connection);
                    //DisplayCustomersByCity(connection, "Kyiv");
                    //DisplayCustomersByCountry(connection, "Ukraine");
                    //DisplayPromotionsByCountry(connection, "Ukraine");
                    //InsertNewCustomer(connection, "John Doe", "1990-01-01", "john.doe@email.com", "Kyiv", "Ukraine");
                    //InsertNewCountry(connection, "Germany");
                    //InsertNewCity(connection, "Berlin", "Germany");
                    //InsertNewSection(connection, "Electronics");
                    //InsertNewPromotionalProduct(connection, "Smartphone", "Electronics", "2024-01-15", "2024-01-30");
                    //UpdateCustomer(connection, 1, "Updated John Doe", "1990-01-01", "updated.john.doe@email.com", "Kyiv", "Ukraine");
                    //UpdateCountry(connection, 1, "Updated Ukraine");
                    //UpdateCity(connection, 1, "Updated Kyiv", "Updated Ukraine");
                    //UpdateSection(connection, 1, "Updated Electronics");
                    //UpdatePromotionalProduct(connection, 1, "Updated Smartphone", "Updated Electronics", "2024-02-01", "2024-02-15");
                    //DeleteCustomer(connection, 1);
                    //DeleteCountry(connection, 1);
                    //DeleteCity(connection, 1);
                    //DeleteSection(connection, 1);
                    //DeletePromotionalProduct(connection, 1);
                    //DisplayCitiesByCountry(connection, "Ukraine");
                    //DisplaySectionsByCustomer(connection, 1);
                    //DisplayPromotionalProductsBySection(connection, "Electronics");
                    //DisplayCustomerCountByCity(connection);
                    //DisplayCustomerCountByCountry(connection);
                    //DisplayCityCountByCountry(connection);
                    //DisplayAverageCityCount(connection);
                    //DisplaySectionsByCountry(connection, "Ukraine");
                    //DisplayPromotionalProductsBySectionAndTime(connection, "Electronics", "01.01.2024", "31.12.2024");
                    //DisplayPromotionalProductsByCustomer(connection, 1);
                    //DisplayTop3CountriesByCustomers(connection);
                    //DisplayBestCountryByCustomers(connection);
                    //DisplayTop3CitiesByCustomers(connection);
                    //DisplayBestCityByCustomers(connection);
                    //DisplayTop3Sections(connection);
                    //DisplayMostPopularSection(connection);
                    //DisplayTop3LeastPopularSections(connection);
                    //DisplayLeastPopularSection(connection);
                    DisplayTop3SectionsPromotional(connection);
                    DisplayMostPopularSectionPromotional(connection);
                    DisplayTop3LeastPopularSectionsPromotional(connection);
                    DisplayLeastPopularSectionPromotional(connection);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Connection error: {ex.Message}");
                }
            }
            Console.Read();
        }
        static void DisplayTop3SectionsPromotional(SqlConnection connection)
        {
            Console.WriteLine("\nTop 3 Most Popular Sections:");
            using (SqlCommand command = new SqlCommand("SELECT TOP 3 Section, COUNT(*) AS SectionCount FROM PromotionalProducts GROUP BY Section ORDER BY SectionCount DESC", connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"Section: {reader["Section"]}, Section Count: {reader["SectionCount"]}");
                    }
                }
            }
        }
        static void DisplayMostPopularSectionPromotional(SqlConnection connection)
        {
            Console.WriteLine("\nMost Popular Section:");
            using (SqlCommand command = new SqlCommand("SELECT TOP 1 Section, COUNT(*) AS SectionCount FROM PromotionalProducts GROUP BY Section ORDER BY SectionCount DESC", connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"Section: {reader["Section"]}, Section Count: {reader["SectionCount"]}");
                    }
                }
            }
        }
        static void DisplayTop3LeastPopularSectionsPromotional(SqlConnection connection)
        {
            Console.WriteLine("\nTop 3 Least Popular Sections:");
            using (SqlCommand command = new SqlCommand("SELECT TOP 3 Section, COUNT(*) AS SectionCount FROM PromotionalProducts GROUP BY Section ORDER BY SectionCount ASC", connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"Section: {reader["Section"]}, Section Count: {reader["SectionCount"]}");
                    }
                }
            }
        }
        static void DisplayLeastPopularSectionPromotional(SqlConnection connection)
        {
            Console.WriteLine("\nLeast Popular Section:");
            using (SqlCommand command = new SqlCommand("SELECT TOP 1 Section, COUNT(*) AS SectionCount FROM PromotionalProducts GROUP BY Section ORDER BY SectionCount ASC", connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"Section: {reader["Section"]}, Section Count: {reader["SectionCount"]}");
                    }
                }
            }
        }
        static void DisplayTop3Sections(SqlConnection connection)
        {
            Console.WriteLine("\nTop 3 Most Popular Sections:");
            using (SqlCommand command = new SqlCommand("SELECT TOP 3 Section, COUNT(*) AS SectionCount FROM PromotionalProducts GROUP BY Section ORDER BY SectionCount DESC", connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"Section: {reader["Section"]}, Section Count: {reader["SectionCount"]}");
                    }
                }
            }
        }
        static void DisplayMostPopularSection(SqlConnection connection)
        {
            Console.WriteLine("\nMost Popular Section:");
            using (SqlCommand command = new SqlCommand("SELECT TOP 1 Section, COUNT(*) AS SectionCount FROM PromotionalProducts GROUP BY Section ORDER BY SectionCount DESC", connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"Section: {reader["Section"]}, Section Count: {reader["SectionCount"]}");
                    }
                }
            }
        }
        static void DisplayTop3LeastPopularSections(SqlConnection connection)
        {
            Console.WriteLine("\nTop 3 Least Popular Sections:");
            using (SqlCommand command = new SqlCommand("SELECT TOP 3 Section, COUNT(*) AS SectionCount FROM PromotionalProducts GROUP BY Section ORDER BY SectionCount ASC", connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"Section: {reader["Section"]}, Section Count: {reader["SectionCount"]}");
                    }
                }
            }
        }
        static void DisplayLeastPopularSection(SqlConnection connection)
        {
            Console.WriteLine("\nLeast Popular Section:");
            using (SqlCommand command = new SqlCommand("SELECT TOP 1 Section, COUNT(*) AS SectionCount FROM PromotionalProducts GROUP BY Section ORDER BY SectionCount ASC", connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"Section: {reader["Section"]}, Section Count: {reader["SectionCount"]}");
                    }
                }
            }
        }
        static void DisplayTop3CountriesByCustomers(SqlConnection connection)
        {
            Console.WriteLine("\nTop 3 Countries by Number of Customers:");
            using (SqlCommand command = new SqlCommand("SELECT TOP 3 Country, COUNT(*) AS CustomerCount FROM Customers GROUP BY Country ORDER BY CustomerCount DESC", connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"Country: {reader["Country"]}, Customer Count: {reader["CustomerCount"]}");
                    }
                }
            }
        }
        static void DisplayBestCountryByCustomers(SqlConnection connection)
        {
            Console.WriteLine("\nBest Country by Number of Customers:");
            using (SqlCommand command = new SqlCommand("SELECT TOP 1 Country, COUNT(*) AS CustomerCount FROM Customers GROUP BY Country ORDER BY CustomerCount DESC", connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"Country: {reader["Country"]}, Customer Count: {reader["CustomerCount"]}");
                    }
                }
            }
        }
        static void DisplayTop3CitiesByCustomers(SqlConnection connection)
        {
            Console.WriteLine("\nTop 3 Cities by Number of Customers:");
            using (SqlCommand command = new SqlCommand("SELECT TOP 3 City, COUNT(*) AS CustomerCount FROM Customers GROUP BY City ORDER BY CustomerCount DESC", connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"City: {reader["City"]}, Customer Count: {reader["CustomerCount"]}");
                    }
                }
            }
        }
        static void DisplayBestCityByCustomers(SqlConnection connection)
        {
            Console.WriteLine("\nBest City by Number of Customers:");
            using (SqlCommand command = new SqlCommand("SELECT TOP 1 City, COUNT(*) AS CustomerCount FROM Customers GROUP BY City ORDER BY CustomerCount DESC", connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"City: {reader["City"]}, Customer Count: {reader["CustomerCount"]}");
                    }
                }
            }
        }
        static void DisplaySectionsByCountry(SqlConnection connection, string country)
        {
            Console.WriteLine($"\nList of Sections for Customers in {country}:");
            using (SqlCommand command = new SqlCommand("SELECT DISTINCT Sections.SectionName FROM Customers JOIN Promotions ON Customers.Country = Promotions.Country JOIN PromotionalProducts ON Promotions.PromotionID = PromotionalProducts.PromotionID JOIN Sections ON PromotionalProducts.Section = Sections.SectionID WHERE Customers.Country = @Country", connection))
            {
                command.Parameters.AddWithValue("@Country", country);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"Section Name: {reader["SectionName"]}");
                    }
                }
            }
        }
        static void DisplayPromotionalProductsBySectionAndTime(SqlConnection connection, string sectionName, string startDate, string endDate)
        {
            Console.WriteLine($"\nList of Promotional Products in Section {sectionName} from {startDate} to {endDate}:");
            using (SqlCommand command = new SqlCommand("SELECT * FROM PromotionalProducts WHERE Section = (SELECT SectionID FROM Sections WHERE SectionName = @SectionName) AND StartDate >= @StartDate AND EndDate <= @EndDate", connection))
            {
                command.Parameters.AddWithValue("@SectionName", sectionName);
                command.Parameters.AddWithValue("@StartDate", startDate);
                command.Parameters.AddWithValue("@EndDate", endDate);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"ProductID: {reader["ProductID"]}, ProductName: {reader["ProductName"]}, StartDate: {reader["StartDate"]}, EndDate: {reader["EndDate"]}");
                    }
                }
            }
        }
        static void DisplayPromotionalProductsByCustomer(SqlConnection connection, int customerId)
        {
            Console.WriteLine($"\nList of Promotional Products for Customer ID {customerId}:");
            using (SqlCommand command = new SqlCommand("SELECT DISTINCT PromotionalProducts.ProductID, PromotionalProducts.ProductName, PromotionalProducts.StartDate, PromotionalProducts.EndDate FROM Customers JOIN Promotions ON Customers.Country = Promotions.Country JOIN PromotionalProducts ON Promotions.PromotionID = PromotionalProducts.PromotionID WHERE Customers.CustomerID = @CustomerID", connection))
            {
                command.Parameters.AddWithValue("@CustomerID", customerId);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"ProductID: {reader["ProductID"]}, ProductName: {reader["ProductName"]}, StartDate: {reader["StartDate"]}, EndDate: {reader["EndDate"]}");
                    }
                }
            }
        }
        static void DisplayCustomerCountByCity(SqlConnection connection)
        {
            Console.WriteLine("\nNumber of Customers in Each City:");
            using (SqlCommand command = new SqlCommand("SELECT City, COUNT(*) AS CustomerCount FROM Customers GROUP BY City", connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"City: {reader["City"]}, Customer Count: {reader["CustomerCount"]}");
                    }
                }
            }
        }
        static void DisplayCustomerCountByCountry(SqlConnection connection)
        {
            Console.WriteLine("\nNumber of Customers in Each Country:");
            using (SqlCommand command = new SqlCommand("SELECT Country, COUNT(*) AS CustomerCount FROM Customers GROUP BY Country", connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"Country: {reader["Country"]}, Customer Count: {reader["CustomerCount"]}");
                    }
                }
            }
        }
        static void DisplayCityCountByCountry(SqlConnection connection)
        {
            Console.WriteLine("\nNumber of Cities in Each Country:");
            using (SqlCommand command = new SqlCommand("SELECT Country, COUNT(DISTINCT City) AS CityCount FROM Customers GROUP BY Country", connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"Country: {reader["Country"]}, City Count: {reader["CityCount"]}");
                    }
                }
            }
        }
        static void DisplayAverageCityCount(SqlConnection connection)
        {
            Console.WriteLine("\nAverage Number of Cities in All Countries:");
            using (SqlCommand command = new SqlCommand("SELECT AVG(CityCount) AS AverageCityCount FROM (SELECT COUNT(DISTINCT City) AS CityCount FROM Customers GROUP BY Country) AS CityCounts", connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"Average City Count: {reader["AverageCityCount"]}");
                    }
                }
            }
        }
        static void DisplayCitiesByCountry(SqlConnection connection, string country)
        {
            Console.WriteLine($"\nList of Cities in {country}:");
            using (SqlCommand command = new SqlCommand("SELECT DISTINCT City FROM Customers WHERE Country = @Country", connection))
            {
                command.Parameters.AddWithValue("@Country", country);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"City: {reader["City"]}");
                    }
                }
            }
        }
        static void DisplaySectionsByCustomer(SqlConnection connection, int customerId)
        {
            Console.WriteLine($"\nList of Sections for Customer ID {customerId}:");
            using (SqlCommand command = new SqlCommand("SELECT DISTINCT Sections.SectionName FROM Customers JOIN Promotions ON Customers.Country = Promotions.Country JOIN PromotionalProducts ON Promotions.PromotionID = PromotionalProducts.PromotionID JOIN Sections ON PromotionalProducts.Section = Sections.SectionID WHERE Customers.CustomerID = @CustomerID", connection))
            {
                command.Parameters.AddWithValue("@CustomerID", customerId);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"Section Name: {reader["SectionName"]}");
                    }
                }
            }
        }
        static void DisplayPromotionalProductsBySection(SqlConnection connection, string sectionName)
        {
            Console.WriteLine($"\nList of Promotional Products in Section {sectionName}:");
            using (SqlCommand command = new SqlCommand("SELECT * FROM PromotionalProducts WHERE Section = (SELECT SectionID FROM Sections WHERE SectionName = @SectionName)", connection))
            {
                command.Parameters.AddWithValue("@SectionName", sectionName);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"ProductID: {reader["ProductID"]}, ProductName: {reader["ProductName"]}, StartDate: {reader["StartDate"]}, EndDate: {reader["EndDate"]}");
                    }
                }
            }
        }
        static void DeleteCustomer(SqlConnection connection, int customerId)
        {
            using (SqlCommand command = new SqlCommand("DELETE FROM Customers WHERE CustomerID = @CustomerID", connection))
            {
                command.Parameters.AddWithValue("@CustomerID", customerId);
                command.ExecuteNonQuery();
                Console.WriteLine($"Customer with ID {customerId} deleted successfully.");
            }
        }
        static void DeleteCountry(SqlConnection connection, int countryId)
        {
            using (SqlCommand command = new SqlCommand("DELETE FROM Countries WHERE CountryID = @CountryID", connection))
            {
                command.Parameters.AddWithValue("@CountryID", countryId);
                command.ExecuteNonQuery();
                Console.WriteLine($"Country with ID {countryId} deleted successfully.");
            }
        }
        static void DeleteCity(SqlConnection connection, int cityId)
        {
            using (SqlCommand command = new SqlCommand("DELETE FROM Cities WHERE CityID = @CityID", connection))
            {
                command.Parameters.AddWithValue("@CityID", cityId);
                command.ExecuteNonQuery();
                Console.WriteLine($"City with ID {cityId} deleted successfully.");
            }
        }
        static void DeleteSection(SqlConnection connection, int sectionId)
        {
            using (SqlCommand command = new SqlCommand("DELETE FROM Sections WHERE SectionID = @SectionID", connection))
            {
                command.Parameters.AddWithValue("@SectionID", sectionId);
                command.ExecuteNonQuery();
                Console.WriteLine($"Section with ID {sectionId} deleted successfully.");
            }
        }
        static void DeletePromotionalProduct(SqlConnection connection, int productId)
        {
            using (SqlCommand command = new SqlCommand("DELETE FROM PromotionalProducts WHERE ProductID = @ProductID", connection))
            {
                command.Parameters.AddWithValue("@ProductID", productId);
                command.ExecuteNonQuery();
                Console.WriteLine($"Promotional product with ID {productId} deleted successfully.");
            }
        }
        static void UpdateCustomer(SqlConnection connection, int customerId, string fullName, string birthDate, string email, string city, string country)
        {
            using (SqlCommand command = new SqlCommand("UPDATE Customers SET FullName = @FullName, BirthDate = @BirthDate, Email = @Email, City = @City, Country = @Country WHERE CustomerID = @CustomerID", connection))
            {
                command.Parameters.AddWithValue("@CustomerID", customerId);
                command.Parameters.AddWithValue("@FullName", fullName);
                command.Parameters.AddWithValue("@BirthDate", birthDate);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@City", city);
                command.Parameters.AddWithValue("@Country", country);
                command.ExecuteNonQuery();
                Console.WriteLine($"Customer with ID {customerId} updated successfully.");
            }
        }
        static void UpdateCountry(SqlConnection connection, int countryId, string countryName)
        {
            using (SqlCommand command = new SqlCommand("UPDATE Countries SET CountryName = @CountryName WHERE CountryID = @CountryID", connection))
            {
                command.Parameters.AddWithValue("@CountryID", countryId);
                command.Parameters.AddWithValue("@CountryName", countryName);
                command.ExecuteNonQuery();
                Console.WriteLine($"Country with ID {countryId} updated successfully.");
            }
        }
        static void UpdateCity(SqlConnection connection, int cityId, string cityName, string country)
        {
            using (SqlCommand command = new SqlCommand("UPDATE Cities SET CityName = @CityName, Country = @Country WHERE CityID = @CityID", connection))
            {
                command.Parameters.AddWithValue("@CityID", cityId);
                command.Parameters.AddWithValue("@CityName", cityName);
                command.Parameters.AddWithValue("@Country", country);
                command.ExecuteNonQuery();
                Console.WriteLine($"City with ID {cityId} updated successfully.");
            }
        }
        static void UpdateSection(SqlConnection connection, int sectionId, string sectionName)
        {
            using (SqlCommand command = new SqlCommand("UPDATE Sections SET SectionName = @SectionName WHERE SectionID = @SectionID", connection))
            {
                command.Parameters.AddWithValue("@SectionID", sectionId);
                command.Parameters.AddWithValue("@SectionName", sectionName);
                command.ExecuteNonQuery();
                Console.WriteLine($"Section with ID {sectionId} updated successfully.");
            }
        }
        static void UpdatePromotionalProduct(SqlConnection connection, int productId, string productName, string section, string startDate, string endDate)
        {
            using (SqlCommand command = new SqlCommand("UPDATE PromotionalProducts SET ProductName = @ProductName, Section = @Section, StartDate = @StartDate, EndDate = @EndDate WHERE ProductID = @ProductID", connection))
            {
                command.Parameters.AddWithValue("@ProductID", productId);
                command.Parameters.AddWithValue("@ProductName", productName);
                command.Parameters.AddWithValue("@Section", section);
                command.Parameters.AddWithValue("@StartDate", startDate);
                command.Parameters.AddWithValue("@EndDate", endDate);
                command.ExecuteNonQuery();
                Console.WriteLine($"Promotional product with ID {productId} updated successfully.");
            }
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