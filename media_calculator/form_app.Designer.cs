namespace media_calculator
{
    partial class form_home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_home));
            this.btn_mini = new System.Windows.Forms.Button();
            this.gb_info = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_sd_new = new System.Windows.Forms.TextBox();
            this.tb_sd_add = new System.Windows.Forms.TextBox();
            this.tb_sd_cu = new System.Windows.Forms.TextBox();
            this.tb_s_new = new System.Windows.Forms.TextBox();
            this.tb_s_add = new System.Windows.Forms.TextBox();
            this.tb_s_cu = new System.Windows.Forms.TextBox();
            this.tb_m_new = new System.Windows.Forms.TextBox();
            this.tb_m_add = new System.Windows.Forms.TextBox();
            this.tb_m_cu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_cal = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_clear_mem = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_zero = new System.Windows.Forms.Button();
            this.gb_info.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_mini
            // 
            this.btn_mini.BackColor = System.Drawing.Color.Black;
            this.btn_mini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mini.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mini.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.btn_mini.Location = new System.Drawing.Point(637, 4);
            this.btn_mini.Name = "btn_mini";
            this.btn_mini.Size = new System.Drawing.Size(24, 23);
            this.btn_mini.TabIndex = 1;
            this.btn_mini.Text = "-";
            this.btn_mini.UseVisualStyleBackColor = false;
            this.btn_mini.Click += new System.EventHandler(this.btn_mini_Click);
            // 
            // gb_info
            // 
            this.gb_info.Controls.Add(this.label4);
            this.gb_info.Controls.Add(this.tb_sd_new);
            this.gb_info.Controls.Add(this.tb_sd_add);
            this.gb_info.Controls.Add(this.tb_sd_cu);
            this.gb_info.Controls.Add(this.tb_s_new);
            this.gb_info.Controls.Add(this.tb_s_add);
            this.gb_info.Controls.Add(this.tb_s_cu);
            this.gb_info.Controls.Add(this.tb_m_new);
            this.gb_info.Controls.Add(this.tb_m_add);
            this.gb_info.Controls.Add(this.tb_m_cu);
            this.gb_info.Controls.Add(this.label1);
            this.gb_info.Controls.Add(this.label6);
            this.gb_info.Controls.Add(this.label2);
            this.gb_info.Controls.Add(this.label5);
            this.gb_info.Controls.Add(this.label3);
            this.gb_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_info.ForeColor = System.Drawing.Color.Purple;
            this.gb_info.Location = new System.Drawing.Point(5, 32);
            this.gb_info.Name = "gb_info";
            this.gb_info.Size = new System.Drawing.Size(679, 183);
            this.gb_info.TabIndex = 6;
            this.gb_info.TabStop = false;
            this.gb_info.Text = "Infomation";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label4.Location = new System.Drawing.Point(210, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Currunt";
            // 
            // tb_sd_new
            // 
            this.tb_sd_new.BackColor = System.Drawing.Color.Black;
            this.tb_sd_new.Enabled = false;
            this.tb_sd_new.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_sd_new.ForeColor = System.Drawing.Color.Lime;
            this.tb_sd_new.Location = new System.Drawing.Point(540, 130);
            this.tb_sd_new.Name = "tb_sd_new";
            this.tb_sd_new.ReadOnly = true;
            this.tb_sd_new.Size = new System.Drawing.Size(100, 26);
            this.tb_sd_new.TabIndex = 5;
            this.tb_sd_new.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_sd_add
            // 
            this.tb_sd_add.BackColor = System.Drawing.Color.Black;
            this.tb_sd_add.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_sd_add.ForeColor = System.Drawing.Color.Lime;
            this.tb_sd_add.Location = new System.Drawing.Point(372, 130);
            this.tb_sd_add.Name = "tb_sd_add";
            this.tb_sd_add.Size = new System.Drawing.Size(100, 26);
            this.tb_sd_add.TabIndex = 5;
            this.tb_sd_add.Text = "0";
            this.tb_sd_add.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_sd_add.Click += new System.EventHandler(this.tb_sd_add_Click);
            // 
            // tb_sd_cu
            // 
            this.tb_sd_cu.BackColor = System.Drawing.Color.Black;
            this.tb_sd_cu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_sd_cu.ForeColor = System.Drawing.Color.Lime;
            this.tb_sd_cu.Location = new System.Drawing.Point(191, 135);
            this.tb_sd_cu.Name = "tb_sd_cu";
            this.tb_sd_cu.ReadOnly = true;
            this.tb_sd_cu.Size = new System.Drawing.Size(100, 26);
            this.tb_sd_cu.TabIndex = 5;
            this.tb_sd_cu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_s_new
            // 
            this.tb_s_new.BackColor = System.Drawing.Color.Black;
            this.tb_s_new.Enabled = false;
            this.tb_s_new.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_s_new.ForeColor = System.Drawing.Color.Lime;
            this.tb_s_new.Location = new System.Drawing.Point(540, 88);
            this.tb_s_new.Name = "tb_s_new";
            this.tb_s_new.ReadOnly = true;
            this.tb_s_new.Size = new System.Drawing.Size(100, 26);
            this.tb_s_new.TabIndex = 5;
            this.tb_s_new.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_s_add
            // 
            this.tb_s_add.BackColor = System.Drawing.Color.Black;
            this.tb_s_add.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_s_add.ForeColor = System.Drawing.Color.Lime;
            this.tb_s_add.Location = new System.Drawing.Point(372, 88);
            this.tb_s_add.Name = "tb_s_add";
            this.tb_s_add.Size = new System.Drawing.Size(100, 26);
            this.tb_s_add.TabIndex = 5;
            this.tb_s_add.Text = "0";
            this.tb_s_add.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_s_add.Click += new System.EventHandler(this.tb_s_add_Click);
            // 
            // tb_s_cu
            // 
            this.tb_s_cu.BackColor = System.Drawing.Color.Black;
            this.tb_s_cu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_s_cu.ForeColor = System.Drawing.Color.Lime;
            this.tb_s_cu.Location = new System.Drawing.Point(191, 93);
            this.tb_s_cu.Name = "tb_s_cu";
            this.tb_s_cu.ReadOnly = true;
            this.tb_s_cu.Size = new System.Drawing.Size(100, 26);
            this.tb_s_cu.TabIndex = 5;
            this.tb_s_cu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_m_new
            // 
            this.tb_m_new.BackColor = System.Drawing.Color.Black;
            this.tb_m_new.Enabled = false;
            this.tb_m_new.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_m_new.ForeColor = System.Drawing.Color.Lime;
            this.tb_m_new.Location = new System.Drawing.Point(540, 47);
            this.tb_m_new.Name = "tb_m_new";
            this.tb_m_new.ReadOnly = true;
            this.tb_m_new.Size = new System.Drawing.Size(100, 26);
            this.tb_m_new.TabIndex = 5;
            this.tb_m_new.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_m_add
            // 
            this.tb_m_add.BackColor = System.Drawing.Color.Black;
            this.tb_m_add.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_m_add.ForeColor = System.Drawing.Color.Lime;
            this.tb_m_add.Location = new System.Drawing.Point(372, 47);
            this.tb_m_add.Name = "tb_m_add";
            this.tb_m_add.Size = new System.Drawing.Size(100, 26);
            this.tb_m_add.TabIndex = 5;
            this.tb_m_add.Text = "0";
            this.tb_m_add.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_m_add.Click += new System.EventHandler(this.tb_m_add_Click);
            // 
            // tb_m_cu
            // 
            this.tb_m_cu.BackColor = System.Drawing.Color.Black;
            this.tb_m_cu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_m_cu.ForeColor = System.Drawing.Color.Lime;
            this.tb_m_cu.Location = new System.Drawing.Point(191, 52);
            this.tb_m_cu.Name = "tb_m_cu";
            this.tb_m_cu.ReadOnly = true;
            this.tb_m_cu.Size = new System.Drawing.Size(100, 26);
            this.tb_m_cu.TabIndex = 5;
            this.tb_m_cu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(24, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Movies";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label6.Location = new System.Drawing.Point(572, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "New";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(24, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Shows";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label5.Location = new System.Drawing.Point(405, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Add";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Location = new System.Drawing.Point(24, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Stage Dramas";
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Black;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.Red;
            this.btn_exit.Location = new System.Drawing.Point(666, 4);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(24, 23);
            this.btn_exit.TabIndex = 1;
            this.btn_exit.Text = "X";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_cal
            // 
            this.btn_cal.BackColor = System.Drawing.Color.Black;
            this.btn_cal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cal.ForeColor = System.Drawing.Color.Cyan;
            this.btn_cal.Location = new System.Drawing.Point(98, 221);
            this.btn_cal.Name = "btn_cal";
            this.btn_cal.Size = new System.Drawing.Size(92, 35);
            this.btn_cal.TabIndex = 7;
            this.btn_cal.Text = "Calculate";
            this.btn_cal.UseVisualStyleBackColor = false;
            this.btn_cal.Click += new System.EventHandler(this.btn_cal_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btn_zero);
            this.panel1.Controls.Add(this.btn_clear_mem);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.gb_info);
            this.panel1.Controls.Add(this.btn_reset);
            this.panel1.Controls.Add(this.btn_cal);
            this.panel1.Controls.Add(this.btn_mini);
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Location = new System.Drawing.Point(4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(693, 266);
            this.panel1.TabIndex = 8;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // btn_clear_mem
            // 
            this.btn_clear_mem.BackColor = System.Drawing.Color.Black;
            this.btn_clear_mem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear_mem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear_mem.ForeColor = System.Drawing.Color.Red;
            this.btn_clear_mem.Location = new System.Drawing.Point(528, 221);
            this.btn_clear_mem.Name = "btn_clear_mem";
            this.btn_clear_mem.Size = new System.Drawing.Size(133, 35);
            this.btn_clear_mem.TabIndex = 9;
            this.btn_clear_mem.Text = "Clear Memory";
            this.btn_clear_mem.UseVisualStyleBackColor = false;
            this.btn_clear_mem.Click += new System.EventHandler(this.btn_clear_mem_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Black;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.LawnGreen;
            this.btn_save.Location = new System.Drawing.Point(196, 221);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(92, 35);
            this.btn_save.TabIndex = 9;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Lime;
            this.label7.Location = new System.Drawing.Point(0, 1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Media Calculator by Dilshan";
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.Black;
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_reset.Location = new System.Drawing.Point(294, 221);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(92, 35);
            this.btn_reset.TabIndex = 7;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_zero
            // 
            this.btn_zero.BackColor = System.Drawing.Color.Black;
            this.btn_zero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_zero.ForeColor = System.Drawing.Color.Red;
            this.btn_zero.Location = new System.Drawing.Point(478, 221);
            this.btn_zero.Name = "btn_zero";
            this.btn_zero.Size = new System.Drawing.Size(44, 35);
            this.btn_zero.TabIndex = 10;
            this.btn_zero.Text = "0";
            this.btn_zero.UseVisualStyleBackColor = false;
            this.btn_zero.Click += new System.EventHandler(this.btn_zero_Click);
            // 
            // form_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(701, 275);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.form_home_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.form_home_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.form_home_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.form_home_MouseUp);
            this.gb_info.ResumeLayout(false);
            this.gb_info.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_cal;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.GroupBox gb_info;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_sd_new;
        private System.Windows.Forms.TextBox tb_sd_add;
        private System.Windows.Forms.TextBox tb_sd_cu;
        private System.Windows.Forms.TextBox tb_s_new;
        private System.Windows.Forms.TextBox tb_s_add;
        private System.Windows.Forms.TextBox tb_s_cu;
        private System.Windows.Forms.TextBox tb_m_new;
        private System.Windows.Forms.TextBox tb_m_add;
        private System.Windows.Forms.TextBox tb_m_cu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_mini;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_clear_mem;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_zero;
    }
}

