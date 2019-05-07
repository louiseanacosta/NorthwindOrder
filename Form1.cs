/**
 * Program: View Order Details from Northwind Database
 * Course Module: CPRG 200 OOSD
 * Purpose: The purpose of this program is to view Order details for each order, calculate order total,
 *  and update Shipped date.
 * Author: : Louise Acosta
 * Date: March 18, 2019
 **/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LouiseAcosta_Lab4
{
    public partial class Form1 : Form
    {
        List<Order> orders = OrderDB.GetOrders(); // order list
        List<OrderDetail> details = OrderDetailDB.GetOrderDetails(); // details list

        public Form1()
        {
            InitializeComponent();
        }

        // form loads
        private void Form1_Load(object sender, EventArgs e)
        {
            // bind order textboxes
            orderBindingSource.DataSource = orders;
        }

        // user clicks on update
        private void btnUpdate_Click(object sender, EventArgs e)
        {

            int orderID = Convert.ToInt32(orderIDComboBox.Text);
            DateTime newDate;
            DateTime orderDate;
            DateTime requiredDate;

            if (DateTime.TryParse(shippedDateTextBox.Text, out newDate)
                && DateTime.TryParse(orderDateTextBox.Text, out orderDate)
                && DateTime.TryParse(requiredDateTextBox.Text, out requiredDate))
            {
                
                if(newDate < orderDate) // shipped date is earlier than order date
                {
                    MessageBox.Show("Shipped Date should be later than or same day as order date.");
                    shippedDateTextBox.Focus();
                }
                else if(newDate > requiredDate) // shipped date later than required date
                {
                    MessageBox.Show("Shipped Date should be earlier than or same day as required date.");
                    shippedDateTextBox.Focus();
                }
                else
                {
                 
                    if (OrderDB.UpdateShippedDate(newDate, orderID)) // shipped date is valid, save changes
                        MessageBox.Show("Your changes have been saved.");
                    else
                        MessageBox.Show("Please try again"); // date not valid
                    
                }
            }
            else
            {
                MessageBox.Show("Invalid date format. Please enter in this format YYYY-MM-DD");
            }

        }

        private void orderBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (orderIDComboBox.Text == "") { return; }

            var detailsOfOrders = new List<OrderDetail>(); // list of order details

            // add to list
            foreach (var detail in details)
            {
                if (detail.OrderID == Int32.Parse(orderIDComboBox.Text)) 
                    detailsOfOrders.Add(detail); 
            }

            orderDetailBindingSource.DataSource = detailsOfOrders;  // bind order detail textboxes

            // display order total amount
            int orderID = Convert.ToInt32(orderIDComboBox.Text);
            Decimal total = this.GetOrderTotal(orderID); 
            txtOrderTotal.Text = total.ToString("c"); 
        }

        // get order total amount
        private Decimal GetOrderTotal(int orderID)
        {
            Decimal total = 0;
            try
            {
                total = OrderDB.GetOrderTotal(orderID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
            return total;
        }



    }
}
