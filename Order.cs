/**
 * Program: View Order Details from Northwind Database
 * Course Module: CPRG 200 OOSD
 * Purpose: Public properties for Order class
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
    public class Order
    {
        public int OrderID { get; set; }
        public string CustomerID { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? RequiredDate { get; set; }
        public DateTime? ShippedDate { get; set; }
        public decimal orderTotal { get; set; }

        public override string ToString()
        {
            return OrderID.ToString();
        }

    }

}
