/**
 * Program: View Order Details from Northwind Database
 * Course Module: CPRG 200 OOSD
 * Purpose: This creates a method to connect to the Northwind Database
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
    public static class NorthwindDB
    {
        // method connect to Northwind Database
        public static SqlConnection Connect()
        {
            string connectionString = @"Data Source=localhost\sqlexpress;Initial Catalog=Northwind;Integrated Security=True";
            return new SqlConnection(connectionString);
        }
    }
}
