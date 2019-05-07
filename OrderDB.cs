/**
 * Program: View Order Details from Northwind Database
 * Course Module: CPRG 200 OOSD
 * Purpose: This includes Reading data and Updating Shipped Date from Order Table in Northwind Database
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
    public static class OrderDB
    {
        public static List<Order> GetOrders()
        {
            List<Order> orders = new List<Order>();
            Order order = null;

            // connect
            SqlConnection connect = NorthwindDB.Connect();

            // select
            string selectStatement = "SELECT OrderID, CustomerID, OrderDate, RequiredDate, ShippedDate " +
                                     "FROM Orders";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connect);

            // check
            try
            {
                // connect
                connect.Open();

                // execute
                SqlDataReader dr = selectCommand.ExecuteReader();

                while (dr.Read())
                {
                    order = new Order();
                    order.OrderID = (int)dr["OrderID"];

                    order.CustomerID = dr["CustomerID"] == DBNull.Value ? "" : dr["CustomerID"].ToString();

                    if (dr["OrderDate"] == DBNull.Value)
                        order.OrderDate = null;
                    else
                        order.OrderDate = (DateTime)dr["OrderDate"];

                    if (dr["RequiredDate"] == DBNull.Value)
                        order.RequiredDate = null;
                    else
                        order.RequiredDate = (DateTime)dr["RequiredDate"];

                    if (dr["ShippedDate"] == DBNull.Value)
                        order.ShippedDate = null;
                    else
                        order.ShippedDate = (DateTime)dr["ShippedDate"];

                    orders.Add(order);
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
            return orders;
        }


        // Update Shipped Date
        public static bool UpdateShippedDate(DateTime date, int orderID)
        { 
            bool result = true;

            // connect
            SqlConnection connect = NorthwindDB.Connect();

            // update statement
            string updateStatement = "UPDATE Orders " +
                                     "SET ShippedDate = @NewShippedDate " +
                                     "WHERE OrderID = @OrderId";


            SqlCommand updateCommand = new SqlCommand(updateStatement, connect);
            updateCommand.Parameters.AddWithValue("@OrderId", orderID);

            if (date == null)
                updateCommand.Parameters.AddWithValue("@NewShippedDate", DBNull.Value);
            else
                updateCommand.Parameters.AddWithValue("@NewShippedDate", date);

            // check
            try
            {
                // connect
                connect.Open();

                // execute
                int affectedRows = updateCommand.ExecuteNonQuery();

                if(affectedRows < 1)
                {
                    result = false;
                }
                
            }
            catch (Exception ex)
            {
                result = false;
                throw ex;
            }
            finally
            {
                connect.Close();
            }
            return result;
        }

        // calculate total amount of order
        public static Decimal GetOrderTotal(int orderID)
        {
             Decimal total = 0;

            // connect
            SqlConnection connect = NorthwindDB.Connect();

            // select statement
            string selectStatement = "SELECT sum(UnitPrice*(1-Discount)*Quantity) AS total FROM [Order Details]" +
                                     "WHERE OrderID = @OrderID GROUP BY OrderID";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connect);
            selectCommand.Parameters.AddWithValue("@OrderId", orderID);

            try
            {
                // open connection
                connect.Open();

                SqlDataReader dr = selectCommand.ExecuteReader();

                while (dr.Read())
                {
                    total += Convert.ToDecimal(dr["total"]);
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connect.Close();
            }
            return total;
        }

    } // end orderDB class
} // end form
