
namespace OpenCore_AutoInstaller
{
    partial class Support
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Support));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ipv4 = new System.Windows.Forms.CheckBox();
            this.hwd = new System.Windows.Forms.CheckBox();
            this.settings = new System.Windows.Forms.CheckBox();
            this.env = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(348, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(59, 63);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 459);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(395, 66);
            this.button1.TabIndex = 6;
            this.button1.Text = "Send Support Request";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DodgerBlue;
            this.textBox1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(12, 81);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(395, 142);
            this.textBox1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 38);
            this.label1.TabIndex = 8;
            this.label1.Text = "Support";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Message";
            // 
            // ipv4
            // 
            this.ipv4.AutoSize = true;
            this.ipv4.BackColor = System.Drawing.Color.DodgerBlue;
            this.ipv4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ipv4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ipv4.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ipv4.ForeColor = System.Drawing.Color.Black;
            this.ipv4.Location = new System.Drawing.Point(12, 327);
            this.ipv4.Name = "ipv4";
            this.ipv4.Size = new System.Drawing.Size(125, 27);
            this.ipv4.TabIndex = 10;
            this.ipv4.Text = "Send IPV4";
            this.ipv4.UseVisualStyleBackColor = false;
            // 
            // hwd
            // 
            this.hwd.AutoSize = true;
            this.hwd.BackColor = System.Drawing.Color.DodgerBlue;
            this.hwd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hwd.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hwd.ForeColor = System.Drawing.Color.Black;
            this.hwd.Location = new System.Drawing.Point(12, 360);
            this.hwd.Name = "hwd";
            this.hwd.Size = new System.Drawing.Size(224, 27);
            this.hwd.TabIndex = 11;
            this.hwd.Text = "Send Hardware Data";
            this.hwd.UseVisualStyleBackColor = false;
            // 
            // settings
            // 
            this.settings.AutoSize = true;
            this.settings.BackColor = System.Drawing.Color.DodgerBlue;
            this.settings.Checked = true;
            this.settings.CheckState = System.Windows.Forms.CheckState.Checked;
            this.settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settings.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.settings.ForeColor = System.Drawing.Color.Black;
            this.settings.Location = new System.Drawing.Point(12, 393);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(169, 27);
            this.settings.TabIndex = 12;
            this.settings.Text = "Send Settings";
            this.settings.UseVisualStyleBackColor = false;
            // 
            // env
            // 
            this.env.AutoSize = true;
            this.env.BackColor = System.Drawing.Color.DodgerBlue;
            this.env.Checked = true;
            this.env.CheckState = System.Windows.Forms.CheckState.Checked;
            this.env.Cursor = System.Windows.Forms.Cursors.Hand;
            this.env.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.env.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.env.ForeColor = System.Drawing.Color.Black;
            this.env.Location = new System.Drawing.Point(12, 426);
            this.env.Name = "env";
            this.env.Size = new System.Drawing.Size(290, 27);
            this.env.TabIndex = 13;
            this.env.Text = "Send All Evironment Info";
            this.env.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(252, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "Discord (Name and Tag)";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.DodgerBlue;
            this.textBox2.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(12, 278);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(395, 31);
            this.textBox2.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(12, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Example: PeenkLion#0001";
            // 
            // Support
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(419, 535);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.env);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.hwd);
            this.Controls.Add(this.ipv4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Support";
            this.Text = "Support";
            this.Load += new System.EventHandler(this.Support_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Support_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Support_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Support_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ipv4;
        private System.Windows.Forms.CheckBox hwd;
        private System.Windows.Forms.CheckBox settings;
        private System.Windows.Forms.CheckBox env;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
    }
}