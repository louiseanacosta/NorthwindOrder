/**
 * Program: View Order Details from Northwind Database
 * Course Module: CPRG 200 OOSD
 * Purpose: This includes Reading data from Order Detail Table in Northwind Database 
 * Author: : Louise Acosta
 * Date: March 18, 2019
 **/
 using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LouiseAcosta_Lab4
{
    public static class OrderDetailDB
    {
        public static List<OrderDetail> GetOrderDetails()
        {
            List<OrderDetail> details = new List<OrderDetail>();
            OrderDetail detail = null;

            // connect
            SqlConnection connect = NorthwindDB.Connect();

            // select statement
            string selectStatement = "SELECT OrderID, ProductID, UnitPrice, Quantity, Discount " +
                                     "FROM [Order Details]";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connect);

            try
            {
                // open connection
                connect.Open();

                SqlDataReader dr = selectCommand.ExecuteReader();

                while (dr.Read())
                {
                    detail = new OrderDetail();
                    detail.OrderID = (int)dr["OrderID"];
                    detail.ProductID = (int)dr["ProductID"];
                    detail.UnitPrice = (decimal)dr["UnitPrice"];
                    detail.Quantity = Int32.Parse(dr["Quantity"].ToString());
                    detail.Discount = Decimal.Parse(dr["Discount"].ToString());
                    details.Add(detail); 
            }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connect.Close();
            }
            return details;
        }
    }
}
