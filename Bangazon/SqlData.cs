using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bangazon
{
    public class SqlData
    {
        #region Variables

        private SqlConnection _sqlConnection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" +
            "\"C:\\Users\\Paloma\\Documents\\Visual Studio 2015\\Projects\\Invoices\\Invoices\\Invoices.mdf\";Integrated Security=True");

        #endregion

        #region Properties

        #endregion

        #region Constructors

        #endregion

        #region Public Methods

        public void CreateCustomer(string firstName, string lastName, string streetAddress, string city, string stateProvidence, string postalCode, string phoneNumber)
        {
            string command = string.Format("INSERT INTO Customer (FirstName, LastName, StreetAddress, City, StateProvidence, PostalCode, PhoneNumber) " +
                "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')", firstName, lastName, streetAddress, city, stateProvidence, postalCode, phoneNumber );
            UpdateDataBase(command);
        }
        public void CreatePaymentOption()
        {
            string command = "";
            UpdateDataBase(command);
        }

        #endregion

        #region Private Methods

        private void UpdateDataBase(string commandString)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = commandString;
            cmd.Connection = _sqlConnection;

            _sqlConnection.Open();
            cmd.ExecuteNonQuery();
            _sqlConnection.Close();
        }

        #endregion
    }
}
