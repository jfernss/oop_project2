namespace fp1
{
    partial class TeacherLogIn
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
            this.btnStudLogIn = new System.Windows.Forms.Button();
            this.txtbxTeacherPass = new System.Windows.Forms.TextBox();
            this.txtbxTeacherID = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblBack = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStudLogIn
            // 
            this.btnStudLogIn.Location = new System.Drawing.Point(359, 277);
            this.btnStudLogIn.Name = "btnStudLogIn";
            this.btnStudLogIn.Size = new System.Drawing.Size(75, 23);
            this.btnStudLogIn.TabIndex = 9;
            this.btnStudLogIn.Text = "Log In";
            this.btnStudLogIn.UseVisualStyleBackColor = true;
            this.btnStudLogIn.Click += new System.EventHandler(this.btnStudLogIn_Click);
            // 
            // txtbxTeacherPass
            // 
            this.txtbxTeacherPass.Location = new System.Drawing.Point(400, 172);
            this.txtbxTeacherPass.Name = "txtbxTeacherPass";
            this.txtbxTeacherPass.Size = new System.Drawing.Size(100, 22);
            this.txtbxTeacherPass.TabIndex = 8;
            // 
            // txtbxTeacherID
            // 
            this.txtbxTeacherID.Location = new System.Drawing.Point(400, 116);
            this.txtbxTeacherID.Name = "txtbxTeacherID";
            this.txtbxTeacherID.Size = new System.Drawing.Size(100, 22);
            this.txtbxTeacherID.TabIndex = 7;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(261, 178);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(67, 16);
            this.lblPass.TabIndex = 6;
            this.lblPass.Text = "Password";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(261, 119);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(68, 16);
            this.lblID.TabIndex = 5;
            this.lblID.Text = "Student ID";
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.Location = new System.Drawing.Point(12, 9);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(38, 16);
            this.lblBack.TabIndex = 10;
            this.lblBack.Text = "Back";
            this.lblBack.Click += new System.EventHandler(this.lblBack_Click);
            // 
            // TeacherLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.btnStudLogIn);
            this.Controls.Add(this.txtbxTeacherPass);
            this.Controls.Add(this.txtbxTeacherID);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblID);
            this.Name = "TeacherLogIn";
            this.Text = "TeacherLogIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStudLogIn;
        private System.Windows.Forms.TextBox txtbxTeacherPass;
        private System.Windows.Forms.TextBox txtbxTeacherID;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblBack;
    }
}