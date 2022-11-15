﻿namespace SalesWinApp
{
    partial class Management
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
            this.dgvOrder = new System.Windows.Forms.TabControl();
            this.tabProduct = new System.Windows.Forms.TabPage();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearchProduct = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchProd = new System.Windows.Forms.TextBox();
            this.panelAction = new System.Windows.Forms.Panel();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.tabMember = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtMemDelete = new System.Windows.Forms.Button();
            this.txtMemUpdate = new System.Windows.Forms.Button();
            this.txtMemAdd = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dgvMember = new System.Windows.Forms.DataGridView();
            this.tabOrder = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnReport = new System.Windows.Forms.Button();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dgvOrder.SuspendLayout();
            this.tabProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelAction.SuspendLayout();
            this.tabMember.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMember)).BeginInit();
            this.tabOrder.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOrder
            // 
            this.dgvOrder.Controls.Add(this.tabProduct);
            this.dgvOrder.Controls.Add(this.tabMember);
            this.dgvOrder.Controls.Add(this.tabOrder);
            this.dgvOrder.Location = new System.Drawing.Point(12, 12);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.SelectedIndex = 0;
            this.dgvOrder.Size = new System.Drawing.Size(776, 426);
            this.dgvOrder.TabIndex = 0;
            // 
            // tabProduct
            // 
            this.tabProduct.Controls.Add(this.dgvProduct);
            this.tabProduct.Controls.Add(this.panel1);
            this.tabProduct.Controls.Add(this.panelAction);
            this.tabProduct.Location = new System.Drawing.Point(4, 24);
            this.tabProduct.Name = "tabProduct";
            this.tabProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tabProduct.Size = new System.Drawing.Size(768, 398);
            this.tabProduct.TabIndex = 0;
            this.tabProduct.Text = "Product";
            this.tabProduct.UseVisualStyleBackColor = true;
            // 
            // dgvProduct
            // 
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Location = new System.Drawing.Point(14, 6);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.RowTemplate.Height = 25;
            this.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduct.Size = new System.Drawing.Size(730, 277);
            this.dgvProduct.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSearchProduct);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtSearchProd);
            this.panel1.Location = new System.Drawing.Point(14, 289);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 45);
            this.panel1.TabIndex = 1;
            // 
            // btnSearchProduct
            // 
            this.btnSearchProduct.Location = new System.Drawing.Point(471, 15);
            this.btnSearchProduct.Name = "btnSearchProduct";
            this.btnSearchProduct.Size = new System.Drawing.Size(75, 27);
            this.btnSearchProduct.TabIndex = 2;
            this.btnSearchProduct.Text = "Search";
            this.btnSearchProduct.UseVisualStyleBackColor = true;
            this.btnSearchProduct.Click += new System.EventHandler(this.btnSearchProduct_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search product";
            // 
            // txtSearchProd
            // 
            this.txtSearchProd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearchProd.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearchProd.Location = new System.Drawing.Point(153, 15);
            this.txtSearchProd.Name = "txtSearchProd";
            this.txtSearchProd.PlaceholderText = "Name";
            this.txtSearchProd.Size = new System.Drawing.Size(288, 27);
            this.txtSearchProd.TabIndex = 0;
            // 
            // panelAction
            // 
            this.panelAction.Controls.Add(this.btnDeleteProduct);
            this.panelAction.Controls.Add(this.btnUpdateProduct);
            this.panelAction.Controls.Add(this.btnAddProduct);
            this.panelAction.Location = new System.Drawing.Point(14, 340);
            this.panelAction.Name = "panelAction";
            this.panelAction.Size = new System.Drawing.Size(730, 48);
            this.panelAction.TabIndex = 0;
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(459, 12);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(87, 33);
            this.btnDeleteProduct.TabIndex = 0;
            this.btnDeleteProduct.Text = "Delete";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.Location = new System.Drawing.Point(312, 12);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(87, 33);
            this.btnUpdateProduct.TabIndex = 0;
            this.btnUpdateProduct.Text = "Update";
            this.btnUpdateProduct.UseVisualStyleBackColor = true;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(171, 12);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(87, 33);
            this.btnAddProduct.TabIndex = 0;
            this.btnAddProduct.Text = "Add New";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // tabMember
            // 
            this.tabMember.Controls.Add(this.panel3);
            this.tabMember.Controls.Add(this.panel2);
            this.tabMember.Controls.Add(this.dgvMember);
            this.tabMember.Location = new System.Drawing.Point(4, 24);
            this.tabMember.Name = "tabMember";
            this.tabMember.Padding = new System.Windows.Forms.Padding(3);
            this.tabMember.Size = new System.Drawing.Size(768, 398);
            this.tabMember.TabIndex = 1;
            this.tabMember.Text = "Member";
            this.tabMember.UseVisualStyleBackColor = true;
            this.tabMember.Click += new System.EventHandler(this.tabMember_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtMemDelete);
            this.panel3.Controls.Add(this.txtMemUpdate);
            this.panel3.Controls.Add(this.txtMemAdd);
            this.panel3.Location = new System.Drawing.Point(3, 344);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(762, 48);
            this.panel3.TabIndex = 3;
            // 
            // txtMemDelete
            // 
            this.txtMemDelete.Location = new System.Drawing.Point(459, 12);
            this.txtMemDelete.Name = "txtMemDelete";
            this.txtMemDelete.Size = new System.Drawing.Size(87, 33);
            this.txtMemDelete.TabIndex = 0;
            this.txtMemDelete.Text = "Delete";
            this.txtMemDelete.UseVisualStyleBackColor = true;
            this.txtMemDelete.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtMemUpdate
            // 
            this.txtMemUpdate.Location = new System.Drawing.Point(312, 12);
            this.txtMemUpdate.Name = "txtMemUpdate";
            this.txtMemUpdate.Size = new System.Drawing.Size(87, 33);
            this.txtMemUpdate.TabIndex = 0;
            this.txtMemUpdate.Text = "Update";
            this.txtMemUpdate.UseVisualStyleBackColor = true;
            this.txtMemUpdate.Click += new System.EventHandler(this.txtMemUpdate_Click);
            // 
            // txtMemAdd
            // 
            this.txtMemAdd.Location = new System.Drawing.Point(171, 12);
            this.txtMemAdd.Name = "txtMemAdd";
            this.txtMemAdd.Size = new System.Drawing.Size(87, 33);
            this.txtMemAdd.TabIndex = 0;
            this.txtMemAdd.Text = "Add New";
            this.txtMemAdd.UseVisualStyleBackColor = true;
            this.txtMemAdd.Click += new System.EventHandler(this.txtMemAdd_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Location = new System.Drawing.Point(3, 283);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(762, 45);
            this.panel2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(424, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Search member";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(115, 15);
            this.textBox2.Name = "textBox2";
            this.textBox2.PlaceholderText = "email";
            this.textBox2.Size = new System.Drawing.Size(288, 27);
            this.textBox2.TabIndex = 0;
            // 
            // dgvMember
            // 
            this.dgvMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMember.Location = new System.Drawing.Point(3, 3);
            this.dgvMember.Name = "dgvMember";
            this.dgvMember.RowTemplate.Height = 25;
            this.dgvMember.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMember.Size = new System.Drawing.Size(762, 274);
            this.dgvMember.TabIndex = 0;
            // 
            // tabOrder
            // 
            this.tabOrder.Controls.Add(this.panel5);
            this.tabOrder.Controls.Add(this.panel4);
            this.tabOrder.Controls.Add(this.dataGridView2);
            this.tabOrder.Location = new System.Drawing.Point(4, 24);
            this.tabOrder.Name = "tabOrder";
            this.tabOrder.Size = new System.Drawing.Size(768, 398);
            this.tabOrder.TabIndex = 2;
            this.tabOrder.Text = "Order";
            this.tabOrder.UseVisualStyleBackColor = true;
            this.tabOrder.Click += new System.EventHandler(this.tabOrder_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button6);
            this.panel5.Controls.Add(this.button7);
            this.panel5.Controls.Add(this.button8);
            this.panel5.Location = new System.Drawing.Point(3, 347);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(756, 48);
            this.panel5.TabIndex = 5;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(459, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(87, 33);
            this.button6.TabIndex = 0;
            this.button6.Text = "Delete";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(312, 12);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(87, 33);
            this.button7.TabIndex = 0;
            this.button7.Text = "Update";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(171, 12);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(87, 33);
            this.button8.TabIndex = 0;
            this.button8.Text = "Add New";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnReport);
            this.panel4.Controls.Add(this.dtTo);
            this.panel4.Controls.Add(this.dtFrom);
            this.panel4.Location = new System.Drawing.Point(3, 281);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(756, 60);
            this.panel4.TabIndex = 4;
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(648, 18);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(75, 23);
            this.btnReport.TabIndex = 1;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // dtTo
            // 
            this.dtTo.Location = new System.Drawing.Point(380, 18);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(200, 23);
            this.dtTo.TabIndex = 0;
            // 
            // dtFrom
            // 
            this.dtFrom.Location = new System.Drawing.Point(83, 18);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(200, 23);
            this.dtFrom.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(762, 272);
            this.dataGridView2.TabIndex = 1;
            // 
            // Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvOrder);
            this.Name = "Management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Management";
            this.Load += new System.EventHandler(this.Management_Load);
            this.dgvOrder.ResumeLayout(false);
            this.tabProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelAction.ResumeLayout(false);
            this.tabMember.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMember)).EndInit();
            this.tabOrder.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl dgvOrder;
        private TabPage tabProduct;
        private Panel panel1;
        private Button btnSearchProduct;
        private Label label1;
        private TextBox txtSearchProd;
        private Panel panelAction;
        private Button btnDeleteProduct;
        private Button btnUpdateProduct;
        private Button btnAddProduct;
        private TabPage tabMember;
        private Panel panel3;
        private Button txtMemDelete;
        private Button txtMemUpdate;
        private Button txtMemAdd;
        private Panel panel2;
        private Button button1;
        private Label label2;
        private TextBox textBox2;
        private DataGridView dgvMember;
        private TabPage tabOrder;
        private Panel panel5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Panel panel4;
        private DataGridView dataGridView2;
        private DataGridView dgvProduct;
        private Button btnReport;
        private DateTimePicker dtTo;
        private DateTimePicker dtFrom;
    }
}