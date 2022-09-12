namespace send_Mail
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.txtsub = new System.Windows.Forms.TextBox();
            this.txtmess = new System.Windows.Forms.TextBox();
            this.btnsend = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(45, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Send Email in C#";
            // 
            // txtmail
            // 
            this.txtmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.txtmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtmail.Location = new System.Drawing.Point(24, 200);
            this.txtmail.Multiline = true;
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(202, 27);
            this.txtmail.TabIndex = 2;
            this.txtmail.Text = "  Email";
            this.txtmail.TextChanged += new System.EventHandler(this.txtmail_TextChanged);
            this.txtmail.Enter += new System.EventHandler(this.txtmail_Enter);
            this.txtmail.Leave += new System.EventHandler(this.txtmail_Leave);
            // 
            // txtsub
            // 
            this.txtsub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.txtsub.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtsub.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtsub.Location = new System.Drawing.Point(24, 247);
            this.txtsub.Multiline = true;
            this.txtsub.Name = "txtsub";
            this.txtsub.Size = new System.Drawing.Size(202, 27);
            this.txtsub.TabIndex = 2;
            this.txtsub.Text = "  Subject";
            this.txtsub.Enter += new System.EventHandler(this.txtsub_Enter);
            this.txtsub.Leave += new System.EventHandler(this.txtsub_Leave);
            // 
            // txtmess
            // 
            this.txtmess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.txtmess.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtmess.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtmess.Location = new System.Drawing.Point(24, 293);
            this.txtmess.Multiline = true;
            this.txtmess.Name = "txtmess";
            this.txtmess.Size = new System.Drawing.Size(202, 81);
            this.txtmess.TabIndex = 2;
            this.txtmess.Text = "  Message";
            this.txtmess.Enter += new System.EventHandler(this.txtmess_Enter);
            this.txtmess.Leave += new System.EventHandler(this.txtmess_Leave);
            // 
            // btnsend
            // 
            this.btnsend.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnsend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsend.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsend.ForeColor = System.Drawing.Color.White;
            this.btnsend.Location = new System.Drawing.Point(24, 395);
            this.btnsend.Name = "btnsend";
            this.btnsend.Size = new System.Drawing.Size(202, 34);
            this.btnsend.TabIndex = 3;
            this.btnsend.Text = "Send Email";
            this.btnsend.UseVisualStyleBackColor = false;
            this.btnsend.Click += new System.EventHandler(this.btnsend_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::send_Mail.Properties.Resources.close;
            this.pictureBox3.Location = new System.Drawing.Point(222, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(29, 28);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::send_Mail.Properties.Resources._1200x600wa;
            this.pictureBox1.Location = new System.Drawing.Point(78, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(257, 497);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnsend);
            this.Controls.Add(this.txtmess);
            this.Controls.Add(this.txtsub);
            this.Controls.Add(this.txtmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.TextBox txtsub;
        private System.Windows.Forms.TextBox txtmess;
        private System.Windows.Forms.Button btnsend;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

