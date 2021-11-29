namespace DrinkPercentages
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
            this.tbContainerSize = new System.Windows.Forms.TextBox();
            this.tbContainerCount = new System.Windows.Forms.TextBox();
            this.tbAlcoholPercentage = new System.Windows.Forms.TextBox();
            this.tbDrinkVolume = new System.Windows.Forms.TextBox();
            this.tbAlcoholVolume = new System.Windows.Forms.TextBox();
            this.bCalculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelErrors = new System.Windows.Forms.Label();
            this.comboBoxGlasses = new System.Windows.Forms.ComboBox();
            this.comboBoxAlcohols = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbContainerSize
            // 
            this.tbContainerSize.Location = new System.Drawing.Point(278, 12);
            this.tbContainerSize.Name = "tbContainerSize";
            this.tbContainerSize.Size = new System.Drawing.Size(100, 22);
            this.tbContainerSize.TabIndex = 0;
            // 
            // tbContainerCount
            // 
            this.tbContainerCount.Location = new System.Drawing.Point(278, 41);
            this.tbContainerCount.Name = "tbContainerCount";
            this.tbContainerCount.Size = new System.Drawing.Size(100, 22);
            this.tbContainerCount.TabIndex = 1;
            // 
            // tbAlcoholPercentage
            // 
            this.tbAlcoholPercentage.Location = new System.Drawing.Point(278, 71);
            this.tbAlcoholPercentage.Name = "tbAlcoholPercentage";
            this.tbAlcoholPercentage.Size = new System.Drawing.Size(100, 22);
            this.tbAlcoholPercentage.TabIndex = 2;
            // 
            // tbDrinkVolume
            // 
            this.tbDrinkVolume.Location = new System.Drawing.Point(278, 99);
            this.tbDrinkVolume.Name = "tbDrinkVolume";
            this.tbDrinkVolume.ReadOnly = true;
            this.tbDrinkVolume.Size = new System.Drawing.Size(100, 22);
            this.tbDrinkVolume.TabIndex = 3;
            // 
            // tbAlcoholVolume
            // 
            this.tbAlcoholVolume.Location = new System.Drawing.Point(278, 128);
            this.tbAlcoholVolume.Name = "tbAlcoholVolume";
            this.tbAlcoholVolume.ReadOnly = true;
            this.tbAlcoholVolume.Size = new System.Drawing.Size(100, 22);
            this.tbAlcoholVolume.TabIndex = 4;
            // 
            // bCalculate
            // 
            this.bCalculate.Location = new System.Drawing.Point(412, 128);
            this.bCalculate.Name = "bCalculate";
            this.bCalculate.Size = new System.Drawing.Size(121, 23);
            this.bCalculate.TabIndex = 5;
            this.bCalculate.Text = "Licz";
            this.bCalculate.UseVisualStyleBackColor = true;
            this.bCalculate.Click += new System.EventHandler(this.bCalculate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(384, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Rozmiar naczynia:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ilość naczyń:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Zawartość alkoholu na naczynie:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Całkowita objętość napojów:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(260, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Całkowita objętość alkoholu w napojach:";
            // 
            // labelErrors
            // 
            this.labelErrors.AutoSize = true;
            this.labelErrors.Location = new System.Drawing.Point(12, 159);
            this.labelErrors.Name = "labelErrors";
            this.labelErrors.Size = new System.Drawing.Size(0, 17);
            this.labelErrors.TabIndex = 12;
            // 
            // comboBoxGlasses
            // 
            this.comboBoxGlasses.FormattingEnabled = true;
            this.comboBoxGlasses.Location = new System.Drawing.Point(412, 12);
            this.comboBoxGlasses.Name = "comboBoxGlasses";
            this.comboBoxGlasses.Size = new System.Drawing.Size(121, 24);
            this.comboBoxGlasses.TabIndex = 13;
            this.comboBoxGlasses.SelectedIndexChanged += new System.EventHandler(this.comboBoxGlasses_SelectedIndexChanged);
            // 
            // comboBoxAlcohols
            // 
            this.comboBoxAlcohols.FormattingEnabled = true;
            this.comboBoxAlcohols.Location = new System.Drawing.Point(412, 71);
            this.comboBoxAlcohols.Name = "comboBoxAlcohols";
            this.comboBoxAlcohols.Size = new System.Drawing.Size(121, 24);
            this.comboBoxAlcohols.TabIndex = 14;
            this.comboBoxAlcohols.SelectedIndexChanged += new System.EventHandler(this.comboBoxAlcohols_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(384, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "ml";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(384, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "ml";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(384, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "ml";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 219);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxAlcohols);
            this.Controls.Add(this.comboBoxGlasses);
            this.Controls.Add(this.labelErrors);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bCalculate);
            this.Controls.Add(this.tbAlcoholVolume);
            this.Controls.Add(this.tbDrinkVolume);
            this.Controls.Add(this.tbAlcoholPercentage);
            this.Controls.Add(this.tbContainerCount);
            this.Controls.Add(this.tbContainerSize);
            this.Name = "Form1";
            this.Text = "Kalkulator zawartości alkoholu w rozmaitych naczyniach";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbContainerSize;
        private System.Windows.Forms.TextBox tbContainerCount;
        private System.Windows.Forms.TextBox tbAlcoholPercentage;
        private System.Windows.Forms.TextBox tbDrinkVolume;
        private System.Windows.Forms.TextBox tbAlcoholVolume;
        private System.Windows.Forms.Button bCalculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelErrors;
        private System.Windows.Forms.ComboBox comboBoxGlasses;
        private System.Windows.Forms.ComboBox comboBoxAlcohols;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

