namespace sqluserlogin
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelFoxiINC = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSecurityID = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxSecurityID = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.labelMessage = new System.Windows.Forms.Label();
            this.labelDebug1 = new System.Windows.Forms.Label();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-97, -8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(564, 343);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelFoxiINC
            // 
            this.labelFoxiINC.AutoSize = true;
            this.labelFoxiINC.BackColor = System.Drawing.Color.Tomato;
            this.labelFoxiINC.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFoxiINC.ForeColor = System.Drawing.Color.Blue;
            this.labelFoxiINC.Location = new System.Drawing.Point(182, 48);
            this.labelFoxiINC.Name = "labelFoxiINC";
            this.labelFoxiINC.Size = new System.Drawing.Size(112, 37);
            this.labelFoxiINC.TabIndex = 1;
            this.labelFoxiINC.Text = "Foxi Inc.";
            // 
            // labelPassword
            // 
            this.labelPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPassword.Location = new System.Drawing.Point(79, 160);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(70, 21);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "Password:";
            // 
            // labelName
            // 
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelName.Location = new System.Drawing.Point(79, 124);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(48, 21);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Name:";
            // 
            // labelSecurityID
            // 
            this.labelSecurityID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSecurityID.Location = new System.Drawing.Point(79, 195);
            this.labelSecurityID.Name = "labelSecurityID";
            this.labelSecurityID.Size = new System.Drawing.Size(74, 21);
            this.labelSecurityID.TabIndex = 4;
            this.labelSecurityID.Text = "SecurityID:";
            // 
            // textBoxName
            // 
            this.textBoxName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxName.Location = new System.Drawing.Point(133, 123);
            this.textBoxName.MaxLength = 100;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.PlaceholderText = "Name";
            this.textBoxName.Size = new System.Drawing.Size(100, 23);
            this.textBoxName.TabIndex = 5;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPassword.Location = new System.Drawing.Point(155, 160);
            this.textBoxPassword.MaxLength = 100;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PlaceholderText = "Password";
            this.textBoxPassword.Size = new System.Drawing.Size(100, 23);
            this.textBoxPassword.TabIndex = 6;
            // 
            // textBoxSecurityID
            // 
            this.textBoxSecurityID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxSecurityID.Location = new System.Drawing.Point(159, 193);
            this.textBoxSecurityID.MaxLength = 4;
            this.textBoxSecurityID.Name = "textBoxSecurityID";
            this.textBoxSecurityID.PlaceholderText = "SecurityID";
            this.textBoxSecurityID.Size = new System.Drawing.Size(100, 23);
            this.textBoxSecurityID.TabIndex = 7;
            // 
            // buttonLogin
            // 
            this.buttonLogin.ForeColor = System.Drawing.Color.Black;
            this.buttonLogin.Location = new System.Drawing.Point(79, 237);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonLogin.TabIndex = 8;
            this.buttonLogin.Text = "LOGIN";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(79, 321);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(34, 15);
            this.labelMessage.TabIndex = 9;
            this.labelMessage.Text = "loool";
            // 
            // labelDebug1
            // 
            this.labelDebug1.Location = new System.Drawing.Point(42, 9);
            this.labelDebug1.Name = "labelDebug1";
            this.labelDebug1.Size = new System.Drawing.Size(385, 21);
            this.labelDebug1.TabIndex = 10;
            this.labelDebug1.Text = "label1";
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(79, 266);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(135, 23);
            this.buttonCreate.TabIndex = 11;
            this.buttonCreate.Text = "CREATE AN ACCOUNT";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(79, 295);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(114, 23);
            this.buttonDelete.TabIndex = 12;
            this.buttonDelete.Text = "DELETE ACCOUNT";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 347);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.labelDebug1);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBoxSecurityID);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelSecurityID);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelFoxiINC);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FoxisLoginMananger";
            this.TransparencyKey = System.Drawing.Color.Lime;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label labelFoxiINC;
        private Label labelPassword;
        private Label labelName;
        private Label labelSecurityID;
        private TextBox textBoxName;
        private TextBox textBoxPassword;
        private TextBox textBoxSecurityID;
        private Button buttonLogin;
        private Label labelMessage;
        private Label labelDebug1;
        private Button buttonCreate;
        private Button buttonDelete;
    }
}