
namespace launcher
{
    partial class main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.newPosters = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMemory = new System.Windows.Forms.TextBox();
            this.tbNickname = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.checkData = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.newPosters)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // newPosters
            // 
            this.newPosters.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.newPosters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newPosters.Location = new System.Drawing.Point(-3, -5);
            this.newPosters.Name = "newPosters";
            this.newPosters.Size = new System.Drawing.Size(895, 573);
            this.newPosters.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.newPosters.TabIndex = 5;
            this.newPosters.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbMemory);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(534, 405);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(321, 128);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Настройки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(6, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "Кол-во RAM(МБ):";
            // 
            // tbMemory
            // 
            this.tbMemory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tbMemory.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Bold);
            this.tbMemory.ForeColor = System.Drawing.Color.White;
            this.tbMemory.Location = new System.Drawing.Point(11, 66);
            this.tbMemory.Name = "tbMemory";
            this.tbMemory.Size = new System.Drawing.Size(176, 36);
            this.tbMemory.TabIndex = 5;
            this.tbMemory.Text = "Memory";
            this.tbMemory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbNickname
            // 
            this.tbNickname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tbNickname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNickname.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Bold);
            this.tbNickname.ForeColor = System.Drawing.Color.White;
            this.tbNickname.Location = new System.Drawing.Point(29, 440);
            this.tbNickname.Name = "tbNickname";
            this.tbNickname.Size = new System.Drawing.Size(275, 36);
            this.tbNickname.TabIndex = 9;
            this.tbNickname.Text = "Ваш Никнейм";
            this.tbNickname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbNickname.Click += new System.EventHandler(this.tbNickname_Click);
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.ForeColor = System.Drawing.Color.White;
            this.login.Location = new System.Drawing.Point(29, 488);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(275, 45);
            this.login.TabIndex = 8;
            this.login.Text = "Играть";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.logo.Location = new System.Drawing.Point(12, 12);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(630, 77);
            this.logo.TabIndex = 10;
            this.logo.TabStop = false;
            // 
            // checkData
            // 
            this.checkData.Interval = 60000;
            this.checkData.Tick += new System.EventHandler(this.checkData_Tick);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.tbNickname);
            this.Controls.Add(this.login);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.newPosters);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(900, 600);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KAMACarft Launcher v1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.main_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.newPosters)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox newPosters;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMemory;
        private System.Windows.Forms.TextBox tbNickname;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Timer checkData;
    }
}