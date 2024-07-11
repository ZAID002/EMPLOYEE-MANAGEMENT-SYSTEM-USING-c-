
namespace login_page_farzan
{
    partial class Homepage
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.textboxid1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.textboxfirstname1 = new System.Windows.Forms.TextBox();
            this.textboxlastname1 = new System.Windows.Forms.TextBox();
            this.textboxdep1 = new System.Windows.Forms.TextBox();
            this.textboxposition1 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.Location = new System.Drawing.Point(432, 143);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(557, 292);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(432, 455);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(203, 63);
            this.button5.TabIndex = 0;
            this.button5.Text = "SHOW DATA";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textboxid1
            // 
            this.textboxid1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxid1.Location = new System.Drawing.Point(222, 108);
            this.textboxid1.Multiline = true;
            this.textboxid1.Name = "textboxid1";
            this.textboxid1.Size = new System.Drawing.Size(199, 31);
            this.textboxid1.TabIndex = 2;
            this.textboxid1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label7.Location = new System.Drawing.Point(26, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(190, 31);
            this.label7.TabIndex = 0;
            this.label7.Text = "EMPLOYEE_ID";
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // textboxfirstname1
            // 
            this.textboxfirstname1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxfirstname1.Location = new System.Drawing.Point(222, 159);
            this.textboxfirstname1.Multiline = true;
            this.textboxfirstname1.Name = "textboxfirstname1";
            this.textboxfirstname1.Size = new System.Drawing.Size(199, 31);
            this.textboxfirstname1.TabIndex = 3;
            // 
            // textboxlastname1
            // 
            this.textboxlastname1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxlastname1.Location = new System.Drawing.Point(222, 222);
            this.textboxlastname1.Multiline = true;
            this.textboxlastname1.Name = "textboxlastname1";
            this.textboxlastname1.Size = new System.Drawing.Size(199, 31);
            this.textboxlastname1.TabIndex = 4;
            // 
            // textboxdep1
            // 
            this.textboxdep1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxdep1.Location = new System.Drawing.Point(222, 277);
            this.textboxdep1.Multiline = true;
            this.textboxdep1.Name = "textboxdep1";
            this.textboxdep1.Size = new System.Drawing.Size(199, 31);
            this.textboxdep1.TabIndex = 5;
            // 
            // textboxposition1
            // 
            this.textboxposition1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxposition1.Location = new System.Drawing.Point(222, 364);
            this.textboxposition1.Multiline = true;
            this.textboxposition1.Name = "textboxposition1";
            this.textboxposition1.Size = new System.Drawing.Size(199, 31);
            this.textboxposition1.TabIndex = 6;
            this.textboxposition1.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(222, 320);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(199, 31);
            this.textBox7.TabIndex = 7;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 26);
            this.label8.TabIndex = 8;
            this.label8.Text = "FIRST NAME";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(26, 222);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 26);
            this.label9.TabIndex = 9;
            this.label9.Text = "LAST NAME";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(27, 277);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(162, 31);
            this.label10.TabIndex = 10;
            this.label10.Text = "DEPARTMENT";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(27, 367);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 31);
            this.label11.TabIndex = 11;
            this.label11.Text = "POSITION";
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(27, 323);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 28);
            this.label12.TabIndex = 12;
            this.label12.Text = "SALARY";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(32, 438);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(129, 59);
            this.button6.TabIndex = 13;
            this.button6.Text = "ADD";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(641, 459);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(203, 59);
            this.button7.TabIndex = 20;
            this.button7.Text = "    UPDATE";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(239, 455);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(128, 59);
            this.button8.TabIndex = 15;
            this.button8.Text = "DELETE";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button9.Location = new System.Drawing.Point(459, 88);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(190, 49);
            this.button9.TabIndex = 21;
            this.button9.Text = "FETCH RECORD";
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Red;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(1048, 57);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(134, 31);
            this.label13.TabIndex = 22;
            this.label13.Text = "username";
            this.label13.Click += new System.EventHandler(this.label13_Click_3);
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.Control;
            this.label14.Location = new System.Drawing.Point(0, -1);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(1222, 46);
            this.label14.TabIndex = 23;
            this.label14.Text = "                      EMPLOYEE  MANAGEMENT SYSTEM";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // Homepage
            // 
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(1327, 631);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textboxposition1);
            this.Controls.Add(this.textboxdep1);
            this.Controls.Add(this.textboxlastname1);
            this.Controls.Add(this.textboxfirstname1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textboxid1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dataGridView2);
            this.Name = "Homepage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textboxposition;
        private System.Windows.Forms.TextBox textboxdep;
        private System.Windows.Forms.TextBox textboxlastname;
        private System.Windows.Forms.TextBox textboxfirstname;
        private System.Windows.Forms.TextBox textboxid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textboxsalary;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textboxid1;
        private System.Windows.Forms.Label label7;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.TextBox textboxfirstname1;
        private System.Windows.Forms.TextBox textboxlastname1;
        private System.Windows.Forms.TextBox textboxdep1;
        private System.Windows.Forms.TextBox textboxposition1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}