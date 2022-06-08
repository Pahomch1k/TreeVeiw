
namespace Dz_14_TreeVeiw
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
            this.LInKat = new System.Windows.Forms.Label();
            this.LInPodRat = new System.Windows.Forms.Label();
            this.LInName = new System.Windows.Forms.Label();
            this.bAdd = new System.Windows.Forms.Button();
            this.LKat = new System.Windows.Forms.Label();
            this.LPodKat = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bAddKat = new System.Windows.Forms.Button();
            this.bAddPodKat = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.bAddName = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // LInKat
            // 
            this.LInKat.AutoSize = true;
            this.LInKat.Location = new System.Drawing.Point(335, 41);
            this.LInKat.Name = "LInKat";
            this.LInKat.Size = new System.Drawing.Size(106, 13);
            this.LInKat.TabIndex = 0;
            this.LInKat.Text = "Введите категорию";
            // 
            // LInPodRat
            // 
            this.LInPodRat.AutoSize = true;
            this.LInPodRat.Location = new System.Drawing.Point(317, 155);
            this.LInPodRat.Name = "LInPodRat";
            this.LInPodRat.Size = new System.Drawing.Size(124, 13);
            this.LInPodRat.TabIndex = 1;
            this.LInPodRat.Text = "Введите подкатегорию";
            // 
            // LInName
            // 
            this.LInName.AutoSize = true;
            this.LInName.Location = new System.Drawing.Point(341, 268);
            this.LInName.Name = "LInName";
            this.LInName.Size = new System.Drawing.Size(100, 13);
            this.LInName.TabIndex = 2;
            this.LInName.Text = "Введите название";
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(412, 320);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(163, 23);
            this.bAdd.TabIndex = 3;
            this.bAdd.Text = "Добавить";
            this.bAdd.UseVisualStyleBackColor = true;
            // 
            // LKat
            // 
            this.LKat.AutoSize = true;
            this.LKat.Location = new System.Drawing.Point(381, 99);
            this.LKat.Name = "LKat";
            this.LKat.Size = new System.Drawing.Size(60, 13);
            this.LKat.TabIndex = 4;
            this.LKat.Text = "Категория";
            // 
            // LPodKat
            // 
            this.LPodKat.AutoSize = true;
            this.LPodKat.Location = new System.Drawing.Point(362, 213);
            this.LPodKat.Name = "LPodKat";
            this.LPodKat.Size = new System.Drawing.Size(79, 13);
            this.LPodKat.TabIndex = 5;
            this.LPodKat.Text = "Подкатегория";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(465, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 20);
            this.textBox1.TabIndex = 6;
            // 
            // bAddKat
            // 
            this.bAddKat.Location = new System.Drawing.Point(646, 39);
            this.bAddKat.Name = "bAddKat";
            this.bAddKat.Size = new System.Drawing.Size(41, 23);
            this.bAddKat.TabIndex = 7;
            this.bAddKat.Text = "Add";
            this.bAddKat.UseVisualStyleBackColor = true;
            this.bAddKat.Click += new System.EventHandler(this.bAddKat_Click);
            // 
            // bAddPodKat
            // 
            this.bAddPodKat.Location = new System.Drawing.Point(646, 150);
            this.bAddPodKat.Name = "bAddPodKat";
            this.bAddPodKat.Size = new System.Drawing.Size(41, 23);
            this.bAddPodKat.TabIndex = 9;
            this.bAddPodKat.Text = "Add";
            this.bAddPodKat.UseVisualStyleBackColor = true;
            this.bAddPodKat.Click += new System.EventHandler(this.bAddPodKat_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(465, 152);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(175, 20);
            this.textBox2.TabIndex = 8;
            // 
            // bAddName
            // 
            this.bAddName.Location = new System.Drawing.Point(646, 268);
            this.bAddName.Name = "bAddName";
            this.bAddName.Size = new System.Drawing.Size(41, 23);
            this.bAddName.TabIndex = 11;
            this.bAddName.Text = "Add";
            this.bAddName.UseVisualStyleBackColor = true;
            this.bAddName.Click += new System.EventHandler(this.bAddName_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(465, 268);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(175, 20);
            this.textBox3.TabIndex = 10;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(465, 96);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(175, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(465, 210);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(175, 21);
            this.comboBox2.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 486);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.bAddName);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.bAddPodKat);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.bAddKat);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LPodKat);
            this.Controls.Add(this.LKat);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.LInName);
            this.Controls.Add(this.LInPodRat);
            this.Controls.Add(this.LInKat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LInKat;
        private System.Windows.Forms.Label LInPodRat;
        private System.Windows.Forms.Label LInName;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Label LKat;
        private System.Windows.Forms.Label LPodKat;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bAddKat;
        private System.Windows.Forms.Button bAddPodKat;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button bAddName;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}

