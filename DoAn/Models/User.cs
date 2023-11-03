using MySql.Data.MySqlClient;
using DoAn.ultilities;

namespace DoAn.Models
{
    internal class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        private MySQLConnect DbCon;

        public User()
        {
            DbCon = new MySQLConnect();
        }
    }
}
