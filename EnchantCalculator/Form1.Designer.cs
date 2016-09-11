using System.Collections.Generic;
using System.Windows.Forms;

namespace EnchantCalculator
{
    public partial class Form1
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
            this.comboBoxCountOfEnchant = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBoxOfWeapon = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBoxCountOfEnchant
            // 
            this.comboBoxCountOfEnchant.FormattingEnabled = true;
            this.comboBoxCountOfEnchant.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBoxCountOfEnchant.Items.AddRange(new object[] {
            "+0",
            "+1",
            "+2",
            "+3",
            "+4",
            "+5",
            "+6",
            "+7",
            "+8",
            "+9",
            "+10",
            "+11",
            "+12",
            "+13",
            "+14",
            "+15",
            "+16"});
            this.comboBoxCountOfEnchant.Location = new System.Drawing.Point(274, 37);
            this.comboBoxCountOfEnchant.Name = "comboBoxCountOfEnchant";
            this.comboBoxCountOfEnchant.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCountOfEnchant.TabIndex = 1;
            this.comboBoxCountOfEnchant.Text = "Уровень модификации";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(418, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(83, 106);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(289, 110);
            this.textBox1.TabIndex = 3;
            // 
            // comboBoxOfWeapon
            // 
            this.comboBoxOfWeapon.FormattingEnabled = true;
            this.comboBoxOfWeapon.Location = new System.Drawing.Point(21, 37);
            this.comboBoxOfWeapon.Name = "comboBoxOfWeapon";
            this.comboBoxOfWeapon.Size = new System.Drawing.Size(247, 21);
            this.comboBoxOfWeapon.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 267);
            this.Controls.Add(this.comboBoxOfWeapon);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxCountOfEnchant);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxCountOfEnchant;
        private Button button1;
        private TextBox textBox1;
        private ComboBox comboBoxOfWeapon;
    }
}

