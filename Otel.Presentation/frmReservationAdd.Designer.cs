namespace Otel.Presentation
{
    partial class frmReservationAdd
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.dataCustomerList = new System.Windows.Forms.DataGridView();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.btnClearCustomer = new System.Windows.Forms.Button();
            this.btnOtelClear = new System.Windows.Forms.Button();
            this.lblOtelName = new System.Windows.Forms.Label();
            this.dataOtelList = new System.Windows.Forms.DataGridView();
            this.txtOtelName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataCustomerList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataOtelList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri Ara";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(86, 6);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(191, 23);
            this.txtCustomerName.TabIndex = 1;
            this.txtCustomerName.TextChanged += new System.EventHandler(this.txtCustomerName_TextChanged);
            // 
            // dataCustomerList
            // 
            this.dataCustomerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCustomerList.Location = new System.Drawing.Point(12, 35);
            this.dataCustomerList.Name = "dataCustomerList";
            this.dataCustomerList.RowTemplate.Height = 25;
            this.dataCustomerList.Size = new System.Drawing.Size(265, 150);
            this.dataCustomerList.TabIndex = 2;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCustomerName.Location = new System.Drawing.Point(12, 188);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(265, 32);
            this.lblCustomerName.TabIndex = 3;
            this.lblCustomerName.Text = "label2";
            this.lblCustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnClearCustomer
            // 
            this.btnClearCustomer.Location = new System.Drawing.Point(243, 192);
            this.btnClearCustomer.Name = "btnClearCustomer";
            this.btnClearCustomer.Size = new System.Drawing.Size(29, 23);
            this.btnClearCustomer.TabIndex = 4;
            this.btnClearCustomer.Text = "x";
            this.btnClearCustomer.UseVisualStyleBackColor = true;
            // 
            // btnOtelClear
            // 
            this.btnOtelClear.Location = new System.Drawing.Point(624, 193);
            this.btnOtelClear.Name = "btnOtelClear";
            this.btnOtelClear.Size = new System.Drawing.Size(29, 23);
            this.btnOtelClear.TabIndex = 9;
            this.btnOtelClear.Text = "x";
            this.btnOtelClear.UseVisualStyleBackColor = true;
            // 
            // lblOtelName
            // 
            this.lblOtelName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblOtelName.Location = new System.Drawing.Point(386, 188);
            this.lblOtelName.Name = "lblOtelName";
            this.lblOtelName.Size = new System.Drawing.Size(276, 32);
            this.lblOtelName.TabIndex = 8;
            this.lblOtelName.Text = "label2";
            this.lblOtelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataOtelList
            // 
            this.dataOtelList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataOtelList.Location = new System.Drawing.Point(386, 35);
            this.dataOtelList.Name = "dataOtelList";
            this.dataOtelList.RowTemplate.Height = 25;
            this.dataOtelList.Size = new System.Drawing.Size(276, 150);
            this.dataOtelList.TabIndex = 7;
            // 
            // txtOtelName
            // 
            this.txtOtelName.Location = new System.Drawing.Point(460, 6);
            this.txtOtelName.Name = "txtOtelName";
            this.txtOtelName.Size = new System.Drawing.Size(202, 23);
            this.txtOtelName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(386, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Otel Ara";
            // 
            // frmReservationAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOtelClear);
            this.Controls.Add(this.lblOtelName);
            this.Controls.Add(this.dataOtelList);
            this.Controls.Add(this.txtOtelName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClearCustomer);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.dataCustomerList);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.label1);
            this.Name = "frmReservationAdd";
            this.Text = "frmReservationAdd";
            ((System.ComponentModel.ISupportInitialize)(this.dataCustomerList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataOtelList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.DataGridView dataCustomerList;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Button btnClearCustomer;
        private System.Windows.Forms.Button btnOtelClear;
        private System.Windows.Forms.Label lblOtelName;
        private System.Windows.Forms.DataGridView dataOtelList;
        private System.Windows.Forms.TextBox txtOtelName;
        private System.Windows.Forms.Label label3;
    }
}