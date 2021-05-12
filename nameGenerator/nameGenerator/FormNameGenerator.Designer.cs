
namespace nameGenerator
{
    partial class FormNameGenerator
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
            this.button_generate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textbox_name = new System.Windows.Forms.TextBox();
            this.lbl_count = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.toggleDark = new nameGenerator.Toggle();
            this.radioButton_lCase = new System.Windows.Forms.RadioButton();
            this.radioButton_uCase = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_generate
            // 
            this.button_generate.BackColor = System.Drawing.Color.MidnightBlue;
            this.button_generate.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_generate.ForeColor = System.Drawing.Color.AliceBlue;
            this.button_generate.Location = new System.Drawing.Point(12, 159);
            this.button_generate.Name = "button_generate";
            this.button_generate.Size = new System.Drawing.Size(300, 40);
            this.button_generate.TabIndex = 0;
            this.button_generate.Text = "İsim Üret";
            this.button_generate.UseVisualStyleBackColor = false;
            this.button_generate.Click += new System.EventHandler(this.button_generate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-277, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-334, -55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // textbox_name
            // 
            this.textbox_name.BackColor = System.Drawing.Color.AliceBlue;
            this.textbox_name.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textbox_name.ForeColor = System.Drawing.Color.MidnightBlue;
            this.textbox_name.Location = new System.Drawing.Point(12, 126);
            this.textbox_name.Name = "textbox_name";
            this.textbox_name.Size = new System.Drawing.Size(300, 27);
            this.textbox_name.TabIndex = 4;
            // 
            // lbl_count
            // 
            this.lbl_count.AutoSize = true;
            this.lbl_count.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_count.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_count.Location = new System.Drawing.Point(12, 12);
            this.lbl_count.Name = "lbl_count";
            this.lbl_count.Size = new System.Drawing.Size(120, 19);
            this.lbl_count.TabIndex = 5;
            this.lbl_count.Text = "Deneme sayısı: 0";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.AliceBlue;
            this.numericUpDown1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDown1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.numericUpDown1.Location = new System.Drawing.Point(119, 95);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(50, 23);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.Tag = "";
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.MidnightBlue;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.ForeColor = System.Drawing.Color.AliceBlue;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "bababa....",
            "ababab....",
            "abbab.....",
            "babbab"});
            this.comboBox1.Location = new System.Drawing.Point(119, 66);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox1.Size = new System.Drawing.Size(193, 23);
            this.comboBox1.TabIndex = 7;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl2.Location = new System.Drawing.Point(12, 95);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(96, 23);
            this.lbl2.TabIndex = 8;
            this.lbl2.Text = "Harf Sayısı:";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl1.Location = new System.Drawing.Point(12, 66);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(101, 23);
            this.lbl1.TabIndex = 9;
            this.lbl1.Text = "Format Seç:";
            // 
            // toggleDark
            // 
            this.toggleDark.BorderColor = System.Drawing.Color.AliceBlue;
            this.toggleDark.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toggleDark.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toggleDark.ForeColor = System.Drawing.Color.White;
            this.toggleDark.IsOn = false;
            this.toggleDark.Location = new System.Drawing.Point(266, 12);
            this.toggleDark.Name = "toggleDark";
            this.toggleDark.OffColor = System.Drawing.Color.DarkGray;
            this.toggleDark.OffText = "OFF";
            this.toggleDark.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.toggleDark.OnText = "ON";
            this.toggleDark.Size = new System.Drawing.Size(46, 25);
            this.toggleDark.TabIndex = 10;
            this.toggleDark.TextEnabled = true;
            this.toggleDark.Click += new System.EventHandler(this.ceLearningToggle1_Click);
            // 
            // radioButton_lCase
            // 
            this.radioButton_lCase.AutoSize = true;
            this.radioButton_lCase.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton_lCase.Location = new System.Drawing.Point(191, 95);
            this.radioButton_lCase.Name = "radioButton_lCase";
            this.radioButton_lCase.Size = new System.Drawing.Size(56, 19);
            this.radioButton_lCase.TabIndex = 12;
            this.radioButton_lCase.TabStop = true;
            this.radioButton_lCase.Text = "LCase";
            this.radioButton_lCase.UseVisualStyleBackColor = true;
            this.radioButton_lCase.CheckedChanged += new System.EventHandler(this.radioButton_lCase_CheckedChanged);
            // 
            // radioButton_uCase
            // 
            this.radioButton_uCase.AutoSize = true;
            this.radioButton_uCase.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton_uCase.Location = new System.Drawing.Point(253, 95);
            this.radioButton_uCase.Name = "radioButton_uCase";
            this.radioButton_uCase.Size = new System.Drawing.Size(59, 19);
            this.radioButton_uCase.TabIndex = 13;
            this.radioButton_uCase.TabStop = true;
            this.radioButton_uCase.Text = "UCase";
            this.radioButton_uCase.UseVisualStyleBackColor = true;
            this.radioButton_uCase.CheckedChanged += new System.EventHandler(this.radioButton_uCase_CheckedChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(324, 208);
            this.Controls.Add(this.radioButton_uCase);
            this.Controls.Add(this.radioButton_lCase);
            this.Controls.Add(this.toggleDark);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lbl_count);
            this.Controls.Add(this.textbox_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_generate);
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Name Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_generate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textbox_name;
        private System.Windows.Forms.Label lbl_count;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private Toggle toggleDark;
        private System.Windows.Forms.RadioButton radioButton_lCase;
        private System.Windows.Forms.RadioButton radioButton_uCase;
    }
}

