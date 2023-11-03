using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1;
using DoAn.ultilities;

namespace DoAn.Models
{
    internal class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        private MySQLConnect DbCon;

        public Book()
        {
            DbCon = new MySQLConnect();
        }
        public List<Book> GetAllBooks()
        {
            List<Book> books = new List<Book>();

            if (DbCon.OpenConnection())
            {
                string query = "SELECT * FROM books";
                MySqlCommand cmd = new MySqlCommand(query, DbCon.GetConnection());
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Book book = new Book();
                    book.Id = reader.GetInt32(0);
                    book.Title = reader.GetString(1);
                    book.Author = reader.GetString(2);
                    books.Add(book);
                }
                reader.Close();
                DbCon.CloseConnection();
            }
            return books;
        }
        public bool CreateBook(string title, string author)
        {
            if (DbCon.OpenConnection())
            {
                string query = "Insert Into books(title, author) values(@title, @author)";
                MySqlCommand cmd = new MySqlCommand(query, DbCon.GetConnection());
                cmd.Parameters.AddWithValue("@title", title);
                cmd.Parameters.AddWithValue("@author", author);
                int affectedRows = cmd.ExecuteNonQuery();
                DbCon.CloseConnection();
                return affectedRows > 0;
            }
            else
            {
                return false;
            }
        }

        public bool EditBook(int id, string title, string author)
        {
            if (DbCon.OpenConnection())
            {
                string query = "UPDATE books SET title = @title, author = @author WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(query, DbCon.GetConnection());
                cmd.Parameters.AddWithValue("@title", title);
                cmd.Parameters.AddWithValue("@author", author);
                cmd.Parameters.AddWithValue("@id", id);
                int affectedRows = cmd.ExecuteNonQuery();
                DbCon.CloseConnection();
                return affectedRows > 0;
            }
            else
            {
                return false;
            }
        }
        public bool DeleteBook(int id, string username)
        {
            if (DbCon.OpenConnection())
            {
                string query = "Call DeleteBook(@id,@username)";
                MySqlCommand cmd = new MySqlCommand(query, DbCon.GetConnection());
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@username", username);

                // Sử dụng ExecuteScalar để nhận giá trị trả về từ stored procedure
                object result = cmd.ExecuteScalar();
                bool isDeleted = Convert.ToBoolean(result);
                DbCon.CloseConnection();
                return isDeleted;
            }
            else
            {
                return false;
            }
        }
    }
}
