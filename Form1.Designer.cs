namespace LouiseAcosta_Lab4
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label customerIDLabel;
            System.Windows.Forms.Label orderDateLabel;
            System.Windows.Forms.Label orderIDLabel;
            System.Windows.Forms.Label requiredDateLabel;
            System.Windows.Forms.Label shippedDateLabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.orderDateTextBox = new System.Windows.Forms.TextBox();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderIDComboBox = new System.Windows.Forms.ComboBox();
            this.requiredDateTextBox = new System.Windows.Forms.TextBox();
            this.customerIDTextBox = new System.Windows.Forms.TextBox();
            this.orderDetailDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtOrderTotal = new System.Windows.Forms.TextBox();
            this.shippedDateTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            customerIDLabel = new System.Windows.Forms.Label();
            orderDateLabel = new System.Windows.Forms.Label();
            orderIDLabel = new System.Windows.Forms.Label();
            requiredDateLabel = new System.Windows.Forms.Label();
            shippedDateLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // customerIDLabel
            // 
            customerIDLabel.AutoSize = true;
            customerIDLabel.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            customerIDLabel.Location = new System.Drawing.Point(175, 158);
            customerIDLabel.Name = "customerIDLabel";
            customerIDLabel.Size = new System.Drawing.Size(190, 38);
            customerIDLabel.TabIndex = 11;
            customerIDLabel.Text = "Customer ID:";
            // 
            // orderDateLabel
            // 
            orderDateLabel.AutoSize = true;
            orderDateLabel.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            orderDateLabel.Location = new System.Drawing.Point(175, 222);
            orderDateLabel.Name = "orderDateLabel";
            orderDateLabel.Size = new System.Drawing.Size(176, 38);
            orderDateLabel.TabIndex = 13;
            orderDateLabel.Text = "Order Date:";
            // 
            // orderIDLabel
            // 
            orderIDLabel.AutoSize = true;
            orderIDLabel.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            orderIDLabel.Location = new System.Drawing.Point(175, 90);
            orderIDLabel.Name = "orderIDLabel";
            orderIDLabel.Size = new System.Drawing.Size(140, 38);
            orderIDLabel.TabIndex = 15;
            orderIDLabel.Text = "Order ID:";
            // 
            // requiredDateLabel
            // 
            requiredDateLabel.AutoSize = true;
            requiredDateLabel.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            requiredDateLabel.Location = new System.Drawing.Point(175, 279);
            requiredDateLabel.Name = "requiredDateLabel";
            requiredDateLabel.Size = new System.Drawing.Size(218, 38);
            requiredDateLabel.TabIndex = 17;
            requiredDateLabel.Text = "Required Date:";
            // 
            // shippedDateLabel
            // 
            shippedDateLabel.AutoSize = true;
            shippedDateLabel.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            shippedDateLabel.Location = new System.Drawing.Point(175, 341);
            shippedDateLabel.Name = "shippedDateLabel";
            shippedDateLabel.Size = new System.Drawing.Size(205, 38);
            shippedDateLabel.TabIndex = 19;
            shippedDateLabel.Text = "Shipped Date:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(175, 412);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(179, 38);
            label1.TabIndex = 22;
            label1.Text = "Order Total:";
            // 
            // orderDateTextBox
            // 
            this.orderDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "OrderDate", true));
            this.orderDateTextBox.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderDateTextBox.Location = new System.Drawing.Point(424, 219);
            this.orderDateTextBox.Name = "orderDateTextBox";
            this.orderDateTextBox.ReadOnly = true;
            this.orderDateTextBox.Size = new System.Drawing.Size(594, 42);
            this.orderDateTextBox.TabIndex = 14;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(LouiseAcosta_Lab4.Order);
            this.orderBindingSource.CurrentChanged += new System.EventHandler(this.orderBindingSource_CurrentChanged);
            // 
            // orderIDComboBox
            // 
            this.orderIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "OrderID", true));
            this.orderIDComboBox.DataSource = this.orderBindingSource;
            this.orderIDComboBox.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderIDComboBox.FormattingEnabled = true;
            this.orderIDComboBox.Location = new System.Drawing.Point(424, 87);
            this.orderIDComboBox.Name = "orderIDComboBox";
            this.orderIDComboBox.Size = new System.Drawing.Size(258, 46);
            this.orderIDComboBox.TabIndex = 16;
            // 
            // requiredDateTextBox
            // 
            this.requiredDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "RequiredDate", true));
            this.requiredDateTextBox.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requiredDateTextBox.Location = new System.Drawing.Point(424, 276);
            this.requiredDateTextBox.Name = "requiredDateTextBox";
            this.requiredDateTextBox.ReadOnly = true;
            this.requiredDateTextBox.Size = new System.Drawing.Size(594, 42);
            this.requiredDateTextBox.TabIndex = 18;
            // 
            // customerIDTextBox
            // 
            this.customerIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "CustomerID", true));
            this.customerIDTextBox.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerIDTextBox.Location = new System.Drawing.Point(424, 154);
            this.customerIDTextBox.Name = "customerIDTextBox";
            this.customerIDTextBox.ReadOnly = true;
            this.customerIDTextBox.Size = new System.Drawing.Size(258, 42);
            this.customerIDTextBox.TabIndex = 21;
            // 
            // orderDetailDataGridView
            // 
            this.orderDetailDataGridView.AutoGenerateColumns = false;
            this.orderDetailDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.orderDetailDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.orderDetailDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDetailDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.Discount});
            this.orderDetailDataGridView.DataSource = this.orderDetailBindingSource;
            this.orderDetailDataGridView.Location = new System.Drawing.Point(164, 522);
            this.orderDetailDataGridView.Name = "orderDetailDataGridView";
            this.orderDetailDataGridView.ReadOnly = true;
            this.orderDetailDataGridView.RowTemplate.Height = 40;
            this.orderDetailDataGridView.Size = new System.Drawing.Size(1416, 549);
            this.orderDetailDataGridView.TabIndex = 21;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ProductID";
            this.dataGridViewTextBoxColumn2.HeaderText = "ProductID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 194;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "UnitPrice";
            this.dataGridViewTextBoxColumn3.HeaderText = "UnitPrice";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 185;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn4.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 176;
            // 
            // Discount
            // 
            this.Discount.DataPropertyName = "Discount";
            this.Discount.HeaderText = "Discount";
            this.Discount.Name = "Discount";
            this.Discount.ReadOnly = true;
            this.Discount.Width = 180;
            // 
            // orderDetailBindingSource
            // 
            this.orderDetailBindingSource.DataSource = typeof(LouiseAcosta_Lab4.OrderDetail);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(1054, 338);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(191, 56);
            this.btnUpdate.TabIndex = 24;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtOrderTotal
            // 
            this.txtOrderTotal.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderTotal.Location = new System.Drawing.Point(424, 412);
            this.txtOrderTotal.Name = "txtOrderTotal";
            this.txtOrderTotal.ReadOnly = true;
            this.txtOrderTotal.Size = new System.Drawing.Size(267, 42);
            this.txtOrderTotal.TabIndex = 25;
            // 
            // shippedDateTextBox
            // 
            this.shippedDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "ShippedDate", true));
            this.shippedDateTextBox.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shippedDateTextBox.Location = new System.Drawing.Point(424, 345);
            this.shippedDateTextBox.Name = "shippedDateTextBox";
            this.shippedDateTextBox.Size = new System.Drawing.Size(594, 42);
            this.shippedDateTextBox.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1048, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(299, 32);
            this.label2.TabIndex = 35;
            this.label2.Text = "Format: YYYY-MM-DD";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(2044, 1176);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.shippedDateTextBox);
            this.Controls.Add(this.txtOrderTotal);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(label1);
            this.Controls.Add(this.orderDetailDataGridView);
            this.Controls.Add(this.customerIDTextBox);
            this.Controls.Add(customerIDLabel);
            this.Controls.Add(orderDateLabel);
            this.Controls.Add(this.orderDateTextBox);
            this.Controls.Add(orderIDLabel);
            this.Controls.Add(this.orderIDComboBox);
            this.Controls.Add(requiredDateLabel);
            this.Controls.Add(this.requiredDateTextBox);
            this.Controls.Add(shippedDateLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.BindingSource orderDetailBindingSource;
        private System.Windows.Forms.TextBox orderDateTextBox;
        private System.Windows.Forms.ComboBox orderIDComboBox;
        private System.Windows.Forms.TextBox requiredDateTextBox;
        private System.Windows.Forms.TextBox customerIDTextBox;
        private System.Windows.Forms.DataGridView orderDetailDataGridView;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtOrderTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.TextBox shippedDateTextBox;
        private System.Windows.Forms.Label label2;
    }
}

