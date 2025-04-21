using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET
{
    internal interface IDatabaseHandler
    {
        void OpenConnection();
        void Create();
        void Retrieve();
        void Update();
        void Delete();
        void CloseConnection();
    }

    internal class DatabaseHandler : IDatabaseHandler
    {
        private SqlConnection connection;
        private static User user;

        public void OpenConnection()
        {
            string connectionString = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=db2;Integrated Security=True";
            connection = new SqlConnection(connectionString);
            connection.Open();
            Console.WriteLine("Connection established successfully!");
        }

        public void Create()
        {
            Console.WriteLine("Enter the name of user");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the email address of user");
            string email = Console.ReadLine();
            Console.WriteLine("Enter the age of user");
            int age = int.Parse(Console.ReadLine());
            var user = new User()
            {
                Name = name,
                Email = email,
                Age = age
            };
            var context = new ValidationContext(user);
            var results = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(user, context, results, true);
            if (isValid)
            {
                string insertQuery = "INSERT INTO UserData(name,email,age)" +
                    "VALUES(@name,@email,@age)";
                SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                insertCommand.Parameters.AddWithValue("@name", name);
                insertCommand.Parameters.AddWithValue("@email", email);
                insertCommand.Parameters.AddWithValue("@age", age);
                insertCommand.ExecuteNonQuery();
                Console.WriteLine("User created successfully!");
            }
            else
            {
                Console.WriteLine("Validation errors :");
                foreach(var error in results)
                {
                    Console.WriteLine($" -> {error.ErrorMessage}");
                }
            }
        }

        public void Retrieve()
        {
            string selectQuery = "SELECT * FROM UserData";
            SqlCommand selectCommand = new SqlCommand(selectQuery, connection);
            SqlDataReader reader = selectCommand.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Console.WriteLine("Id : " + reader.GetValue(3).ToString());
                    Console.WriteLine("Name : " + reader.GetValue(0).ToString());
                    Console.WriteLine("Email : " + reader.GetValue(1).ToString());
                    Console.WriteLine("Age : " + reader.GetValue(2).ToString());
                    Console.WriteLine("-----------------------------------------");
                }
            }
            else
            {
                Console.WriteLine("No data found!");
            }

            reader.Close();
        }

        public void Update()
        {
            bool update = true;
            while (update)
            {
                Console.WriteLine("Enter the choice to be updated :\n1. Name\n2. Email\n3. Age\n4. Exit\n");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        UpdateName();
                        break;
                    case 2:
                        UpdateEmail();
                        break;
                    case 3:
                        UpdateAge();
                        break;
                    case 4:
                        update = false;
                        Console.WriteLine("Thank you! Please come again.");
                        break;
                    default:
                        Console.WriteLine("Invalid choice! Please enter valid choice.");
                        break;
                }
            }
        }

        public void UpdateName()
        {
            Console.WriteLine("Enter the user ID to update");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the updated name");
            string name = Console.ReadLine();
            var user = new User()
            {
                Id = id,
                Name = name
            };
            var results = new List<ValidationResult>();
            var propertiesToValidate = new Dictionary<string, object>()
            {
                { nameof(user.Id), user.Id },
                { nameof(user.Name), user.Name }
            };
            bool isValid = true;
            foreach(var property in propertiesToValidate)
            {
                var context = new ValidationContext(user)
                {
                    MemberName = property.Key
                };
                bool isPropertyValid = Validator.TryValidateProperty(property.Value, context, results);
                if (!isPropertyValid)
                {
                    isValid = false;
                }
            }
            if (isValid)
            {
                string updateNameQuery = "UPDATE UserData SET name=@name WHERE " +
                    "id=@id";
                SqlCommand updateNameCommand = new SqlCommand(updateNameQuery, connection);
                updateNameCommand.Parameters.AddWithValue("@name", name);
                updateNameCommand.Parameters.AddWithValue("@id", id);
                int rowsAffected = updateNameCommand.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    Console.WriteLine("User name updated successfully!");
                }
                else
                {
                    Console.WriteLine("User ID not found!");
                }
            }
        }

        public void UpdateEmail()
        {
            Console.WriteLine("Enter the user ID to update");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the updated email");
            string email = Console.ReadLine();
            var user = new User()
            {
                Id = id,
                Email = email
            };
            var results = new List<ValidationResult>();
            var propertiesToValidate = new Dictionary<string, object>()
            {
                { nameof(user.Id), user.Id },
                { nameof(user.Email), user.Email }
            };
            bool isValid = true;
            foreach (var property in propertiesToValidate)
            {
                var context = new ValidationContext(user)
                {
                    MemberName = property.Key
                };
                bool isPropertyValid = Validator.TryValidateProperty(property.Value, context, results);
                if (!isPropertyValid)
                {
                    isValid = false;
                }
            }
            if (isValid)
            {
                string updateEmailQuery = "UPDATE UserData SET email=@email WHERE " +
                    "id=@id";
                SqlCommand updateEmailCommand = new SqlCommand(updateEmailQuery, connection);
                updateEmailCommand.Parameters.AddWithValue("@email", email);
                updateEmailCommand.Parameters.AddWithValue("@id", id);
                int rowsAffected = updateEmailCommand.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    Console.WriteLine("User email updated successfully!");
                }
                else
                {
                    Console.WriteLine("User ID not found!");
                }
            }
        }

        public void UpdateAge()
        {
            Console.WriteLine("Enter the user ID to update");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the updated age");
            int age = int.Parse(Console.ReadLine());
            var user = new User()
            {
                Id = id,
                Age = age
            };
            var results = new List<ValidationResult>();
            var propertiesToValidate = new Dictionary<string, object>()
            {
                { nameof(user.Id), user.Id },
                { nameof(user.Age), user.Age }
            };
            bool isValid = true;
            foreach (var property in propertiesToValidate)
            {
                var context = new ValidationContext(user)
                {
                    MemberName = property.Key
                };
                bool isPropertyValid = Validator.TryValidateProperty(property.Value, context, results);
                if (!isPropertyValid)
                {
                    isValid = false;
                }
            }
            if (isValid)
            {
                string updateAgeQuery = "UPDATE UserData SET age=@age WHERE " +
                    "id=@id";
                SqlCommand updateAgeCommand = new SqlCommand(updateAgeQuery, connection);
                updateAgeCommand.Parameters.AddWithValue("@age", age);
                updateAgeCommand.Parameters.AddWithValue("@id", id);
                int rowsAffected = updateAgeCommand.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    Console.WriteLine("User age updated successfully!");
                }
                else
                {
                    Console.WriteLine("User ID not found!");
                }
            }
        }

        public void Delete()
        {
            Console.WriteLine("Enter a user ID to delete");
            int id = int.Parse(Console.ReadLine());

            string deleteQuery = "DELETE FROM UserData WHERE id=@id";
            SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection);
            deleteCommand.Parameters.AddWithValue("@id", id);
            int rowsAffected = deleteCommand.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                Console.WriteLine("User deleted successfully!");
            }
            else
            {
                Console.WriteLine("User ID not found!");
            }
        }

        public void CloseConnection()
        {
            connection.Close();
        }
    }

    internal class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50,ErrorMessage ="Name should contain 3 to 50 characters")]
        [RegularExpression(@"^([A-Z][a-z]+|[A-Z][a-z]+\s[A-Z][a-z]+)$")]
        public string Name { get; set; }

        [Required]
        [RegularExpression(@"^([A-Za-z0-9]+|[A-Za-z]+\.[A-Za-z0-9]+)\@[a-z0-9]+\.(com|org|gov|cc|in)$")]
        public string Email { get; set; }

        [Required]
        [Range(18,60,ErrorMessage ="Age should be between 18 and 60")]
        public int Age { get; set; }

        public static void PerformSql()
        {
            DatabaseHandler dbHandler = new DatabaseHandler();
            dbHandler.OpenConnection();
            try
            {
                bool sqlOperation = true;
                while (sqlOperation)
                {
                    Console.WriteLine("Enter the operation to perform :\n1. Create\n2. Retrieve\n3. Update\n4. Delete\n5. Exit");
                    int choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            dbHandler.Create();
                            break;
                        case 2:
                            dbHandler.Retrieve();
                            break;
                        case 3:
                            dbHandler.Update();
                            break;
                        case 4:
                            dbHandler.Delete();
                            break;
                        case 5:
                            sqlOperation = false;
                            Console.WriteLine("Thank you! Please come again.");
                            break;
                        default:
                            Console.WriteLine("Invalid choice! Please enter valid choice.");
                            break;
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                dbHandler.CloseConnection();
            }
        }
    }
}