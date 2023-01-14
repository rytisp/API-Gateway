using MySql.Data.MySqlClient;

namespace API_Gateway.Helpers
{
    public class MySQLactions : PasswordHashing
    {
        public void Insert(string passwdInput)
        {
            var passwd = new PasswordHashing();
            var hashedPassword = passwd.Encrypt(passwdInput);

            using (var connection = new MySqlConnection("server=rytis.co.uk;user=root;database=passwords;password=xxxxx;"))
            {
                connection.Open();
                var sqlCommand = "INSERT INTO hashed (password) VALUES (@password)";
                using (var command = new MySqlCommand(sqlCommand, connection))
                {
                    command.Parameters.AddWithValue("@password", hashedPassword);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
