using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using SmallBusinessManagementSystem.Model;

namespace SmallBusinessManagementSystem.Repository
{
    class SupplierEntryRepository
    {
        private ConnectionRepository _connectionRepository = new ConnectionRepository();
        public bool IsSaved(SupplierEntry _supplierEntry)
        {

            bool saved = false;

            try
            {


                //Connection Establish
                string connectionString = _connectionRepository.GetConnectionString();
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Comand establish
                // string commandString = @"INSERT INTO Items (Name, Price) VALUES( '" + item.Name + " ', " + item.Price + ")";
                string commandString = @"INSERT INTO Supplier(Code, Name, Address, Email, Contact, ContactPerson) VALUES ('" + _supplierEntry.Code + "', '" + _supplierEntry.Name + "', '" + _supplierEntry.Address + "', '" + _supplierEntry.Email + "', '" + _supplierEntry.Contact + "', '" + _supplierEntry.ContactPerson + "');";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);


                sqlConnection.Open();

                //Sql command Execute
                int isExecuted = sqlCommand.ExecuteNonQuery();

                if (isExecuted > 0)
                {
                    saved = true;
                }

                sqlConnection.Close();

            }
            catch (Exception exception)
            {
                return false;
            }

            return saved;
        }

        public DataTable ShowSuppliers()
        {


            //Connection Establish
            string connectionString = _connectionRepository.GetConnectionString();
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Comand establish
            string commandString = @"SELECT * FROM Supplier";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);


            sqlConnection.Open();

            //Sql command Execute

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
           

            sqlConnection.Close();
            return dataTable;
        }

        public bool isCodeExist(SupplierEntry _supplierEntry)
        {
            bool Exist = false;

            try
            {

                string connectionString = _connectionRepository.GetConnectionString();
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Comand establish
                string commandString = @"SELECT * FROM Supplier WHERE Code  = '" + _supplierEntry.Code + "' ";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);


                sqlConnection.Open();

                //Sql command Execute
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                //Ckeck for uniqueness
                if (dataTable.Rows.Count > 0)
                {
                    Exist = true;

                }


                sqlConnection.Close();
            }

            catch (Exception exception)
            {
                // MessageBox.Show(exception.Message);
            }

            return Exist;
        }

        public bool isEmailExist(SupplierEntry _supplierEntry)
        {
            bool Exist = false;

            try
            {

                string connectionString = _connectionRepository.GetConnectionString();
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Comand establish
                string commandString = @"SELECT * FROM Supplier WHERE Email  = '" + _supplierEntry.Email + "' ";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);


                sqlConnection.Open();

                //Sql command Execute
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                //Ckeck for uniqueness
                if (dataTable.Rows.Count > 0)
                {
                    Exist = true;

                }


                sqlConnection.Close();
            }

            catch (Exception exception)
            {
                // MessageBox.Show(exception.Message);
            }

            return Exist;
        }


        public bool isContactExist(SupplierEntry _supplierEntry)
        {
            bool Exist = false;

            try
            {

                string connectionString = _connectionRepository.GetConnectionString();
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Comand establish
                string commandString = @"SELECT * FROM Supplier WHERE Contact  = '" + _supplierEntry.Contact + "' ";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);


                sqlConnection.Open();

                //Sql command Execute
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                //Ckeck for uniqueness
                if (dataTable.Rows.Count > 0)
                {
                    Exist = true;

                }


                sqlConnection.Close();
            }

            catch (Exception exception)
            {
                // MessageBox.Show(exception.Message);
            }

            return Exist;
        }

      

        public bool isEditExist(SupplierEntry _supplierEntry)
        {
            bool isEdited = false;

            try
            {

                string connectionString = _connectionRepository.GetConnectionString();
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Comand establish
                string commandString = @"SELECT * FROM Supplier WHERE Code  = '" + _supplierEntry.Code + "' OR Email = '" + _supplierEntry.Email + "' OR Contact = '" + _supplierEntry.Contact + "' ";
                //string commandString = @"SELECT * FROM Supplier WHERE Code  = '" + _suppliers.Code + "' ";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);


                sqlConnection.Open();

                //Sql command Execute
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                //Ckeck for uniqueness
                if (dataTable.Rows.Count > 0)
                {
                    isEdited = true;

                }


                sqlConnection.Close();
            }

            catch (Exception exception)
            {
                //MessageBox.Show(exception.Message);
            }

            return isEdited;
        }
        public bool EditData(SupplierEntry _supplierEntry)
        {
            //check for existing name CANT BE UPDATED
            bool isEdited = false;
            try
            {
                string connectionString = _connectionRepository.GetConnectionString();
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command establish
                string commandString = @"UPDATE Supplier  SET Name = '" + _supplierEntry.Name + "',  Email = '" + _supplierEntry.Email + "', Contact = '" + _supplierEntry.Contact + "', ContactPerson = '" + _supplierEntry.ContactPerson + "',Address = '" + _supplierEntry.Address + "' WHERE Code = '" + _supplierEntry.Code + "' ";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);


                sqlConnection.Open();

                //Sql command Execute
                int isExecuted = sqlCommand.ExecuteNonQuery();

                if (isExecuted > 0)
                {
                    isEdited = true;
                }

                sqlConnection.Close();

            }

            catch (Exception exception)

            {
                //MessageBox.Show(exception.Message);
            }

            return isEdited;
        }

        public DataTable SearchSupplier(SupplierEntry _supplierEntry)
        {
            string connectionString = _connectionRepository.GetConnectionString();
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            string commandString = @"SELECT * FROM Supplier WHERE Name = '" + _supplierEntry.Name + "' OR Email = '" + _supplierEntry.Email + "' OR Contact = '" + _supplierEntry.Contact + "' ";

            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            //execution
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                return dataTable;
            }

            //close
            sqlConnection.Close();

            return dataTable;
        }
       

    }
}

