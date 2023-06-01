namespace Ignition
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_incorrect = new System.Windows.Forms.Label();
            this.Usignin_btn = new Guna.UI2.WinForms.Guna2Button();
            this.Uname_txtbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.UPass_txtbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_reset = new Guna.UI2.WinForms.Guna2CircleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(286, 96);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(319, 341);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(345, 38);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(121, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(303, 123);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome to";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LimeGreen;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(485, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ignition";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(301, 151);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 64);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sign in";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(307, 205);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Enter Your Username ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(307, 269);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Enter Your Password";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lbl_incorrect
            // 
            this.lbl_incorrect.AutoSize = true;
            this.lbl_incorrect.BackColor = System.Drawing.Color.Transparent;
            this.lbl_incorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_incorrect.ForeColor = System.Drawing.Color.Red;
            this.lbl_incorrect.Image = ((System.Drawing.Image)(resources.GetObject("lbl_incorrect.Image")));
            this.lbl_incorrect.Location = new System.Drawing.Point(290, 340);
            this.lbl_incorrect.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_incorrect.Name = "lbl_incorrect";
            this.lbl_incorrect.Size = new System.Drawing.Size(300, 25);
            this.lbl_incorrect.TabIndex = 9;
            this.lbl_incorrect.Text = "Incorrect Username Or Password";
            this.lbl_incorrect.Visible = false;
            // 
            // Usignin_btn
            // 
            this.Usignin_btn.BackColor = System.Drawing.Color.Transparent;
            this.Usignin_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Usignin_btn.BackgroundImage")));
            this.Usignin_btn.BorderColor = System.Drawing.Color.Transparent;
            this.Usignin_btn.BorderRadius = 10;
            this.Usignin_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Usignin_btn.FillColor = System.Drawing.Color.LimeGreen;
            this.Usignin_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usignin_btn.ForeColor = System.Drawing.Color.White;
            this.Usignin_btn.Location = new System.Drawing.Point(323, 380);
            this.Usignin_btn.Margin = new System.Windows.Forms.Padding(2);
            this.Usignin_btn.Name = "Usignin_btn";
            this.Usignin_btn.ShadowDecoration.BorderRadius = 20;
            this.Usignin_btn.Size = new System.Drawing.Size(108, 41);
            this.Usignin_btn.TabIndex = 10;
            this.Usignin_btn.Text = "Sign in";
            this.Usignin_btn.Click += new System.EventHandler(this.Usignin_btn_Click);
            // 
            // Uname_txtbox
            // 
            this.Uname_txtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Uname_txtbox.DefaultText = "";
            this.Uname_txtbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Uname_txtbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Uname_txtbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Uname_txtbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Uname_txtbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Uname_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Uname_txtbox.ForeColor = System.Drawing.Color.Green;
            this.Uname_txtbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Uname_txtbox.Location = new System.Drawing.Point(309, 233);
            this.Uname_txtbox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Uname_txtbox.Name = "Uname_txtbox";
            this.Uname_txtbox.PasswordChar = '\0';
            this.Uname_txtbox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.Uname_txtbox.PlaceholderText = "Username";
            this.Uname_txtbox.SelectedText = "";
            this.Uname_txtbox.Size = new System.Drawing.Size(185, 23);
            this.Uname_txtbox.TabIndex = 11;
            this.Uname_txtbox.TextChanged += new System.EventHandler(this.Uname_txtbox_TextChanged);
            // 
            // UPass_txtbox
            // 
            this.UPass_txtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UPass_txtbox.DefaultText = "";
            this.UPass_txtbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UPass_txtbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UPass_txtbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UPass_txtbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UPass_txtbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UPass_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UPass_txtbox.ForeColor = System.Drawing.Color.Green;
            this.UPass_txtbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UPass_txtbox.Location = new System.Drawing.Point(309, 314);
            this.UPass_txtbox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.UPass_txtbox.Name = "UPass_txtbox";
            this.UPass_txtbox.PasswordChar = '*';
            this.UPass_txtbox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.UPass_txtbox.PlaceholderText = "Password";
            this.UPass_txtbox.SelectedText = "";
            this.UPass_txtbox.Size = new System.Drawing.Size(185, 23);
            this.UPass_txtbox.TabIndex = 12;
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.Transparent;
            this.btn_reset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_reset.BackgroundImage")));
            this.btn_reset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_reset.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_reset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_reset.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_reset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_reset.FillColor = System.Drawing.Color.Transparent;
            this.btn_reset.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_reset.ForeColor = System.Drawing.Color.White;
            this.btn_reset.Location = new System.Drawing.Point(763, 12);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_reset.Size = new System.Drawing.Size(35, 34);
            this.btn_reset.TabIndex = 22;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(810, 474);
            this.ControlBox = false;
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.UPass_txtbox);
            this.Controls.Add(this.Uname_txtbox);
            this.Controls.Add(this.Usignin_btn);
            this.Controls.Add(this.lbl_incorrect);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ignition";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_incorrect;
        private Guna.UI2.WinForms.Guna2Button Usignin_btn;
        private Guna.UI2.WinForms.Guna2TextBox Uname_txtbox;
        private Guna.UI2.WinForms.Guna2TextBox UPass_txtbox;
        private Guna.UI2.WinForms.Guna2CircleButton btn_reset;
    }
}

