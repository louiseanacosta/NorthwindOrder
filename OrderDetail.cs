/**
 * Program: View Order Details from Northwind Database
 * Course Module: CPRG 200 OOSD
 * Purpose: Public properties for Order Detail class
 * Author: : Louise Acosta
 * Date: March 18, 2019
 **/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LouiseAcosta_Lab4
{
    public class OrderDetail
    {
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public decimal Discount { get; set; }

    }
}
