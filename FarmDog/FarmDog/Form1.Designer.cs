namespace FarmDog
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
            this.btnAddDog = new System.Windows.Forms.Button();
            this.checkBoxHealth = new System.Windows.Forms.CheckBox();
            this.checkBoxHunger = new System.Windows.Forms.CheckBox();
            this.dogsList = new System.Windows.Forms.ListBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.trackBarAge = new System.Windows.Forms.TrackBar();
            this.btnSetDefaultList = new System.Windows.Forms.Button();
            this.btnInit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dogsNumber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAge)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddDog
            // 
            this.btnAddDog.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.btnAddDog.Location = new System.Drawing.Point(44, 240);
            this.btnAddDog.Name = "btnAddDog";
            this.btnAddDog.Size = new System.Drawing.Size(243, 30);
            this.btnAddDog.TabIndex = 0;
            this.btnAddDog.Text = "ДОБАВИТЬ СОБАКУ";
            this.btnAddDog.UseVisualStyleBackColor = true;
            this.btnAddDog.Click += new System.EventHandler(this.btnAddDog_Click);
            // 
            // checkBoxHealth
            // 
            this.checkBoxHealth.AutoSize = true;
            this.checkBoxHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.checkBoxHealth.Location = new System.Drawing.Point(181, 184);
            this.checkBoxHealth.Name = "checkBoxHealth";
            this.checkBoxHealth.Size = new System.Drawing.Size(106, 21);
            this.checkBoxHealth.TabIndex = 1;
            this.checkBoxHealth.Text = "ЗДОРОВАЯ";
            this.checkBoxHealth.UseVisualStyleBackColor = true;
            // 
            // checkBoxHunger
            // 
            this.checkBoxHunger.AutoSize = true;
            this.checkBoxHunger.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.checkBoxHunger.Location = new System.Drawing.Point(44, 184);
            this.checkBoxHunger.Name = "checkBoxHunger";
            this.checkBoxHunger.Size = new System.Drawing.Size(107, 21);
            this.checkBoxHunger.TabIndex = 2;
            this.checkBoxHunger.Text = "ГОЛОДНАЯ";
            this.checkBoxHunger.UseVisualStyleBackColor = true;
            // 
            // dogsList
            // 
            this.dogsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.dogsList.FormattingEnabled = true;
            this.dogsList.ItemHeight = 17;
            this.dogsList.Location = new System.Drawing.Point(357, 86);
            this.dogsList.Name = "dogsList";
            this.dogsList.Size = new System.Drawing.Size(416, 361);
            this.dogsList.TabIndex = 3;
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.textBoxName.Location = new System.Drawing.Point(44, 59);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(243, 23);
            this.textBoxName.TabIndex = 4;
            // 
            // trackBarAge
            // 
            this.trackBarAge.Location = new System.Drawing.Point(44, 114);
            this.trackBarAge.Maximum = 14;
            this.trackBarAge.Minimum = 1;
            this.trackBarAge.Name = "trackBarAge";
            this.trackBarAge.Size = new System.Drawing.Size(243, 45);
            this.trackBarAge.TabIndex = 5;
            this.trackBarAge.Value = 1;
            // 
            // btnSetDefaultList
            // 
            this.btnSetDefaultList.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.btnSetDefaultList.Location = new System.Drawing.Point(44, 290);
            this.btnSetDefaultList.Name = "btnSetDefaultList";
            this.btnSetDefaultList.Size = new System.Drawing.Size(243, 62);
            this.btnSetDefaultList.TabIndex = 6;
            this.btnSetDefaultList.Text = "ПРЕДУСТАНОВЛЕННЫЙ СПИСОК";
            this.btnSetDefaultList.UseVisualStyleBackColor = true;
            this.btnSetDefaultList.Click += new System.EventHandler(this.btnSetDefaultList_Click);
            // 
            // btnInit
            // 
            this.btnInit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.btnInit.Location = new System.Drawing.Point(44, 417);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(243, 30);
            this.btnInit.TabIndex = 7;
            this.btnInit.Text = "ЗАПУСТИТЬ ПРОГРАММУ";
            this.btnInit.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(41, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "КЛИЧКА";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(41, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "ВОЗРАСТ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(50, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(263, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "14";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(166, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "8";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(67, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(354, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "СПИСОК СОБАК";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(354, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Количество:";
            // 
            // dogsNumber
            // 
            this.dogsNumber.AutoSize = true;
            this.dogsNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.dogsNumber.Location = new System.Drawing.Point(454, 59);
            this.dogsNumber.Name = "dogsNumber";
            this.dogsNumber.Size = new System.Drawing.Size(17, 17);
            this.dogsNumber.TabIndex = 16;
            this.dogsNumber.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 566);
            this.Controls.Add(this.dogsNumber);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInit);
            this.Controls.Add(this.btnSetDefaultList);
            this.Controls.Add(this.trackBarAge);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.dogsList);
            this.Controls.Add(this.checkBoxHunger);
            this.Controls.Add(this.checkBoxHealth);
            this.Controls.Add(this.btnAddDog);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddDog;
        private System.Windows.Forms.CheckBox checkBoxHealth;
        private System.Windows.Forms.CheckBox checkBoxHunger;
        private System.Windows.Forms.ListBox dogsList;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TrackBar trackBarAge;
        private System.Windows.Forms.Button btnSetDefaultList;
        private System.Windows.Forms.Button btnInit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label dogsNumber;
    }
}

