namespace fp1
{
    partial class StudentLogIn
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
            this.lblID = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtbxStudID = new System.Windows.Forms.TextBox();
            this.txtbxStudPass = new System.Windows.Forms.TextBox();
            this.btnStudLogIn = new System.Windows.Forms.Button();
            this.lblBack = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(224, 112);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(68, 16);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "Student ID";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(224, 171);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(67, 16);
            this.lblPass.TabIndex = 1;
            this.lblPass.Text = "Password";
            // 
            // txtbxStudID
            // 
            this.txtbxStudID.Location = new System.Drawing.Point(363, 109);
            this.txtbxStudID.Name = "txtbxStudID";
            this.txtbxStudID.Size = new System.Drawing.Size(100, 22);
            this.txtbxStudID.TabIndex = 2;
            // 
            // txtbxStudPass
            // 
            this.txtbxStudPass.Location = new System.Drawing.Point(363, 165);
            this.txtbxStudPass.Name = "txtbxStudPass";
            this.txtbxStudPass.Size = new System.Drawing.Size(100, 22);
            this.txtbxStudPass.TabIndex = 3;
            // 
            // btnStudLogIn
            // 
            this.btnStudLogIn.Location = new System.Drawing.Point(322, 270);
            this.btnStudLogIn.Name = "btnStudLogIn";
            this.btnStudLogIn.Size = new System.Drawing.Size(75, 23);
            this.btnStudLogIn.TabIndex = 4;
            this.btnStudLogIn.Text = "Log In";
            this.btnStudLogIn.UseVisualStyleBackColor = true;
            this.btnStudLogIn.Click += new System.EventHandler(this.btnStudLogIn_Click);
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.Location = new System.Drawing.Point(12, 9);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(38, 16);
            this.lblBack.TabIndex = 5;
            this.lblBack.Text = "Back";
            // 
            // StudentLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.btnStudLogIn);
            this.Controls.Add(this.txtbxStudPass);
            this.Controls.Add(this.txtbxStudID);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblID);
            this.Name = "StudentLogIn";
            this.Text = "StudentLogIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtbxStudID;
        private System.Windows.Forms.TextBox txtbxStudPass;
        private System.Windows.Forms.Button btnStudLogIn;
        private System.Windows.Forms.Label lblBack;
    }
}