namespace fp1
{
    partial class MainDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainDashboard));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lblHello = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Books = new System.Windows.Forms.TabPage();
            this.BBooks = new System.Windows.Forms.TabPage();
            this.RBooks = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Book1 = new System.Windows.Forms.Label();
            this.Book2 = new System.Windows.Forms.Label();
            this.Book3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.Books.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(202, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lblHello
            // 
            this.lblHello.AutoSize = true;
            this.lblHello.Location = new System.Drawing.Point(12, 9);
            this.lblHello.Name = "lblHello";
            this.lblHello.Size = new System.Drawing.Size(42, 16);
            this.lblHello.TabIndex = 1;
            this.lblHello.Text = "Hello,";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(60, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(46, 16);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "NAME";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Fictional Books",
            "Non-Fictional Books",
            "Academic Books"});
            this.comboBox1.Location = new System.Drawing.Point(6, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Books);
            this.tabControl1.Controls.Add(this.BBooks);
            this.tabControl1.Controls.Add(this.RBooks);
            this.tabControl1.Location = new System.Drawing.Point(15, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(878, 362);
            this.tabControl1.TabIndex = 5;
            // 
            // Books
            // 
            this.Books.Controls.Add(this.Book3);
            this.Books.Controls.Add(this.Book2);
            this.Books.Controls.Add(this.Book1);
            this.Books.Controls.Add(this.pictureBox3);
            this.Books.Controls.Add(this.pictureBox2);
            this.Books.Controls.Add(this.pictureBox1);
            this.Books.Controls.Add(this.comboBox1);
            this.Books.Location = new System.Drawing.Point(4, 25);
            this.Books.Name = "Books";
            this.Books.Padding = new System.Windows.Forms.Padding(3);
            this.Books.Size = new System.Drawing.Size(870, 333);
            this.Books.TabIndex = 0;
            this.Books.Text = "Books";
            this.Books.UseVisualStyleBackColor = true;
            // 
            // BBooks
            // 
            this.BBooks.Location = new System.Drawing.Point(4, 25);
            this.BBooks.Name = "BBooks";
            this.BBooks.Padding = new System.Windows.Forms.Padding(3);
            this.BBooks.Size = new System.Drawing.Size(870, 333);
            this.BBooks.TabIndex = 1;
            this.BBooks.Text = "Borrow Books";
            this.BBooks.UseVisualStyleBackColor = true;
            // 
            // RBooks
            // 
            this.RBooks.Location = new System.Drawing.Point(4, 25);
            this.RBooks.Name = "RBooks";
            this.RBooks.Padding = new System.Windows.Forms.Padding(3);
            this.RBooks.Size = new System.Drawing.Size(870, 333);
            this.RBooks.TabIndex = 2;
            this.RBooks.Text = "Return Books";
            this.RBooks.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(80, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(248, 65);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(118, 124);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(430, 65);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(119, 124);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // Book1
            // 
            this.Book1.AutoSize = true;
            this.Book1.Location = new System.Drawing.Point(108, 205);
            this.Book1.Name = "Book1";
            this.Book1.Size = new System.Drawing.Size(49, 16);
            this.Book1.TabIndex = 8;
            this.Book1.Text = "Book 1";
            // 
            // Book2
            // 
            this.Book2.AutoSize = true;
            this.Book2.Location = new System.Drawing.Point(282, 205);
            this.Book2.Name = "Book2";
            this.Book2.Size = new System.Drawing.Size(49, 16);
            this.Book2.TabIndex = 9;
            this.Book2.Text = "Book 2";
            // 
            // Book3
            // 
            this.Book3.AutoSize = true;
            this.Book3.Location = new System.Drawing.Point(461, 205);
            this.Book3.Name = "Book3";
            this.Book3.Size = new System.Drawing.Size(49, 16);
            this.Book3.TabIndex = 10;
            this.Book3.Text = "Book 3";
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblHello);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainDashboard";
            this.Text = "MainDashboard";
            this.tabControl1.ResumeLayout(false);
            this.Books.ResumeLayout(false);
            this.Books.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label lblHello;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Books;
        private System.Windows.Forms.TabPage BBooks;
        private System.Windows.Forms.TabPage RBooks;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Book3;
        private System.Windows.Forms.Label Book2;
        private System.Windows.Forms.Label Book1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}