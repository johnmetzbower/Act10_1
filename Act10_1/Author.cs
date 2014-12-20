using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Act10_1
{
    public class Author
    {

        SqlConnection _pubConnection;
        string _connString;
        public Author()
        {
        }
        public List<String> GetAuthorList()
        {
            SqlCommand authorsCommand = new SqlCommand();
            SqlDataReader authorDataReader;
            List<string> nameList = new List<string>();
            try
            {
                authorsCommand.Connection = _pubConnection;
                authorsCommand.CommandText = "Select au_lnamae from authors";
                _pubConnection.Open();
                authorDataReader = authorsCommand.ExecuteReader();
                while (authorDataReader.Read() == true)
                {
                    nameList.Add(authorDataReader.GetString(0));
                }
                return nameList;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                if (_pubConnection != null)
                {
                    _pubConnection.Close();
                }
            }
            _connString =
                    "Data source=localhost;Initial Catalog=pubs;Integrated Security=True";
            _pubConnection = new SqlConnection();
            _pubConnection.ConnectionString = _connString;
        }
        public int CountAuthors()
        {
            try
            {
                SqlCommand pubCommand = new SqlCommand();
                pubCommand.Connection = _pubConnection;
                pubCommand.CommandText = "Select Count(au_id) from authors";
                _pubConnection.Open();
                return (int)pubCommand.ExecuteScalar();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                if (_pubConnection != null)
                {
                    _pubConnection.Close();
                }
            }
        }
    }
}
    
