﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using SmallBusinessManagementSystem.Model;

namespace SmallBusinessManagementSystem.Repository
{
    class SaleRepotingRepository
    {
        private ConnectionRepository _connectionRepository = new ConnectionRepository();
        public List<SaleRepotingModel> SearchValue(SaleRepotingModel saleRepotingModel)
        {
            string connectionString = _connectionRepository.GetConnectionString();
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            string CommandString = @"SELECT * FROM SalesRepoting WHERE Date BETWEEN '"+saleRepotingModel.Date+"' AND '"+saleRepotingModel.Date2+"'";

            SqlCommand sqlCommand = new SqlCommand(CommandString, sqlConnection);
            sqlConnection.Open();

            List<SaleRepotingModel> saleRepotingModels = new List<SaleRepotingModel>();

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                SaleRepotingModel _saleRepotingModel = new SaleRepotingModel();

                _saleRepotingModel.Product = Convert.ToString(sqlDataReader["Name"]);
                _saleRepotingModel.Category = Convert.ToString(sqlDataReader["Category"]);
                
                _saleRepotingModel.Quantity = Convert.ToDouble(sqlDataReader["Quantity"]);
             
                 _saleRepotingModel.UnitPrice = Convert.ToDouble(sqlDataReader["totalUnitPrice"]);
                _saleRepotingModel.MRP = Convert.ToDouble(sqlDataReader["TotalMRP"]);
                _saleRepotingModel.Profit = Convert.ToDouble(sqlDataReader["Profit"]);

                saleRepotingModels.Add(_saleRepotingModel);
            }

            sqlConnection.Close();

            return saleRepotingModels;




        }
        public List<SaleRepotingModel> SearchValueByName(SaleRepotingModel saleRepotingModel)
        {
            string connectionString = _connectionRepository.GetConnectionString();
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            string CommandString = @"SELECT * FROM SalesRepoting WHERE Name='"+ saleRepotingModel.Name + "'";

            SqlCommand sqlCommand = new SqlCommand(CommandString, sqlConnection);
            sqlConnection.Open();

            List<SaleRepotingModel> saleRepotingModels = new List<SaleRepotingModel>();

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                SaleRepotingModel _saleRepotingModel = new SaleRepotingModel();

                _saleRepotingModel.Product = Convert.ToString(sqlDataReader["Name"]);
                _saleRepotingModel.Category = Convert.ToString(sqlDataReader["Category"]);

                _saleRepotingModel.Quantity = Convert.ToDouble(sqlDataReader["Quantity"]);

                _saleRepotingModel.UnitPrice = Convert.ToDouble(sqlDataReader["totalUnitPrice"]);
                _saleRepotingModel.MRP = Convert.ToDouble(sqlDataReader["TotalMRP"]);
                _saleRepotingModel.Profit = Convert.ToDouble(sqlDataReader["Profit"]);

                saleRepotingModels.Add(_saleRepotingModel);
            }

            sqlConnection.Close();

            return saleRepotingModels;




        }
    }
}
