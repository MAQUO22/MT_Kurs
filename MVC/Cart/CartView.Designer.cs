namespace MT_Kurs
{
    partial class CartView
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
            this.CartList = new System.Windows.Forms.TextBox();
            this.FirstAndLastName = new System.Windows.Forms.TextBox();
            this.mail = new System.Windows.Forms.TextBox();
            this.adress = new System.Windows.Forms.TextBox();
            this.Order = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.Sum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(105, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Корзина";
            // 
            // CartList
            // 
            this.CartList.Location = new System.Drawing.Point(17, 55);
            this.CartList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CartList.Multiline = true;
            this.CartList.Name = "CartList";
            this.CartList.ReadOnly = true;
            this.CartList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CartList.Size = new System.Drawing.Size(361, 173);
            this.CartList.TabIndex = 1;
            // 
            // FirstAndLastName
            // 
            this.FirstAndLastName.Location = new System.Drawing.Point(168, 298);
            this.FirstAndLastName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FirstAndLastName.Name = "FirstAndLastName";
            this.FirstAndLastName.Size = new System.Drawing.Size(188, 22);
            this.FirstAndLastName.TabIndex = 2;
            // 
            // mail
            // 
            this.mail.Location = new System.Drawing.Point(168, 354);
            this.mail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(188, 22);
            this.mail.TabIndex = 3;
            // 
            // adress
            // 
            this.adress.Location = new System.Drawing.Point(168, 411);
            this.adress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.adress.Name = "adress";
            this.adress.Size = new System.Drawing.Size(188, 22);
            this.adress.TabIndex = 4;
            // 
            // Order
            // 
            this.Order.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Order.Location = new System.Drawing.Point(113, 459);
            this.Order.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Order.Name = "Order";
            this.Order.Size = new System.Drawing.Size(181, 43);
            this.Order.TabIndex = 5;
            this.Order.Text = "Заказать";
            this.Order.UseVisualStyleBackColor = true;
            this.Order.Click += new System.EventHandler(this.Order_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 302);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Имя Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 358);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Адрес э. почты";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 415);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Адрес";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.Location = new System.Drawing.Point(6, 242);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(288, 25);
            this.label.TabIndex = 9;
            this.label.Text = "В корзине товары на сумму - ";
            // 
            // Sum
            // 
            this.Sum.AutoSize = true;
            this.Sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sum.Location = new System.Drawing.Point(301, 245);
            this.Sum.Name = "Sum";
            this.Sum.Size = new System.Drawing.Size(21, 22);
            this.Sum.TabIndex = 10;
            this.Sum.Text = "0";
            // 
            // CartWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(396, 517);
            this.Controls.Add(this.Sum);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Order);
            this.Controls.Add(this.adress);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.FirstAndLastName);
            this.Controls.Add(this.CartList);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "CartWindow";
            this.Text = "Cart";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CartList;
        private System.Windows.Forms.TextBox FirstAndLastName;
        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.TextBox adress;
        private System.Windows.Forms.Button Order;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label Sum;
    }
}