namespace MT_Kurs.MVC.Admin
{
    partial class AdminView
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
            this.UsersList = new System.Windows.Forms.TextBox();
            this.UserLogin = new System.Windows.Forms.TextBox();
            this.GetOrders = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Products = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.DeleteOrders = new System.Windows.Forms.Button();
            this.DeleteUser = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // UsersList
            // 
            this.UsersList.Location = new System.Drawing.Point(16, 44);
            this.UsersList.Multiline = true;
            this.UsersList.Name = "UsersList";
            this.UsersList.ReadOnly = true;
            this.UsersList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.UsersList.Size = new System.Drawing.Size(186, 309);
            this.UsersList.TabIndex = 0;
            // 
            // UserLogin
            // 
            this.UserLogin.Location = new System.Drawing.Point(490, 53);
            this.UserLogin.Name = "UserLogin";
            this.UserLogin.Size = new System.Drawing.Size(100, 22);
            this.UserLogin.TabIndex = 1;
            // 
            // GetOrders
            // 
            this.GetOrders.Location = new System.Drawing.Point(622, 36);
            this.GetOrders.Name = "GetOrders";
            this.GetOrders.Size = new System.Drawing.Size(155, 55);
            this.GetOrders.TabIndex = 2;
            this.GetOrders.Text = "вывод заказов пользователя";
            this.GetOrders.UseVisualStyleBackColor = true;
            this.GetOrders.Click += new System.EventHandler(this.GetOrders_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.UsersList);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 377);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Список пользователей";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Login,
            this.TimeOrder,
            this.Products,
            this.TotalSum,
            this.FIO,
            this.Adress,
            this.Email});
            this.dataGridView1.Location = new System.Drawing.Point(248, 125);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(929, 262);
            this.dataGridView1.TabIndex = 4;
            // 
            // Login
            // 
            this.Login.HeaderText = "Login";
            this.Login.MinimumWidth = 6;
            this.Login.Name = "Login";
            this.Login.Width = 125;
            // 
            // TimeOrder
            // 
            this.TimeOrder.HeaderText = "TimeOrder";
            this.TimeOrder.MinimumWidth = 6;
            this.TimeOrder.Name = "TimeOrder";
            this.TimeOrder.Width = 125;
            // 
            // Products
            // 
            this.Products.HeaderText = "Products";
            this.Products.MinimumWidth = 6;
            this.Products.Name = "Products";
            this.Products.Width = 125;
            // 
            // TotalSum
            // 
            this.TotalSum.HeaderText = "TotalSum";
            this.TotalSum.MinimumWidth = 6;
            this.TotalSum.Name = "TotalSum";
            this.TotalSum.Width = 125;
            // 
            // FIO
            // 
            this.FIO.HeaderText = "Name";
            this.FIO.MinimumWidth = 6;
            this.FIO.Name = "FIO";
            this.FIO.Width = 125;
            // 
            // Adress
            // 
            this.Adress.HeaderText = "Adress";
            this.Adress.MinimumWidth = 6;
            this.Adress.Name = "Adress";
            this.Adress.Width = 125;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Операции над пользователем ->";
            // 
            // DeleteOrders
            // 
            this.DeleteOrders.Location = new System.Drawing.Point(795, 38);
            this.DeleteOrders.Name = "DeleteOrders";
            this.DeleteOrders.Size = new System.Drawing.Size(135, 53);
            this.DeleteOrders.TabIndex = 6;
            this.DeleteOrders.Text = "Удалить заказы пользователя";
            this.DeleteOrders.UseVisualStyleBackColor = true;
            this.DeleteOrders.Click += new System.EventHandler(this.DeleteOrders_Click);
            // 
            // DeleteUser
            // 
            this.DeleteUser.Location = new System.Drawing.Point(949, 39);
            this.DeleteUser.Name = "DeleteUser";
            this.DeleteUser.Size = new System.Drawing.Size(123, 52);
            this.DeleteUser.TabIndex = 7;
            this.DeleteUser.Text = "Удалить пользователя";
            this.DeleteUser.UseVisualStyleBackColor = true;
            this.DeleteUser.Click += new System.EventHandler(this.DeleteUser_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(1102, 61);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 8;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // AdminView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 399);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.DeleteUser);
            this.Controls.Add(this.DeleteOrders);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GetOrders);
            this.Controls.Add(this.UserLogin);
            this.Name = "AdminView";
            this.Text = "Admin Window";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UsersList;
        private System.Windows.Forms.TextBox UserLogin;
        private System.Windows.Forms.Button GetOrders;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Login;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn Products;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalSum;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DeleteOrders;
        private System.Windows.Forms.Button DeleteUser;
        private System.Windows.Forms.Button Back;
    }
}