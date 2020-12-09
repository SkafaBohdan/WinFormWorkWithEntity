namespace Laba_Entity
{
    partial class Form_Add
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxEngine = new System.Windows.Forms.ComboBox();
            this.comboBoxBody = new System.Windows.Forms.ComboBox();
            this.button1_Add = new System.Windows.Forms.Button();
            this.button2_Cancel = new System.Windows.Forms.Button();
            this.textBoxColor = new System.Windows.Forms.TextBox();
            this.label4Model = new System.Windows.Forms.Label();
            this.label4Marka = new System.Windows.Forms.Label();
            this.textBoxMarka = new System.Windows.Forms.TextBox();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.labelCount = new System.Windows.Forms.Label();
            this.CountDoors = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.CountDoors)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Тип Двигателя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Тип кузова";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Цвет";
            // 
            // comboBoxEngine
            // 
            this.comboBoxEngine.FormattingEnabled = true;
            this.comboBoxEngine.Location = new System.Drawing.Point(123, 184);
            this.comboBoxEngine.Name = "comboBoxEngine";
            this.comboBoxEngine.Size = new System.Drawing.Size(110, 21);
            this.comboBoxEngine.TabIndex = 6;
            // 
            // comboBoxBody
            // 
            this.comboBoxBody.FormattingEnabled = true;
            this.comboBoxBody.Location = new System.Drawing.Point(123, 217);
            this.comboBoxBody.Name = "comboBoxBody";
            this.comboBoxBody.Size = new System.Drawing.Size(110, 21);
            this.comboBoxBody.TabIndex = 7;
            // 
            // button1_Add
            // 
            this.button1_Add.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button1_Add.Location = new System.Drawing.Point(65, 306);
            this.button1_Add.Name = "button1_Add";
            this.button1_Add.Size = new System.Drawing.Size(75, 23);
            this.button1_Add.TabIndex = 8;
            this.button1_Add.Text = "Add";
            this.button1_Add.UseVisualStyleBackColor = true;
            this.button1_Add.Click += new System.EventHandler(this.button1_Add_Click);
            // 
            // button2_Cancel
            // 
            this.button2_Cancel.Location = new System.Drawing.Point(158, 306);
            this.button2_Cancel.Name = "button2_Cancel";
            this.button2_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button2_Cancel.TabIndex = 9;
            this.button2_Cancel.Text = "Cancel";
            this.button2_Cancel.UseVisualStyleBackColor = true;
            this.button2_Cancel.Click += new System.EventHandler(this.button2_Cancel_Click);
            // 
            // textBoxColor
            // 
            this.textBoxColor.Location = new System.Drawing.Point(123, 80);
            this.textBoxColor.Name = "textBoxColor";
            this.textBoxColor.Size = new System.Drawing.Size(100, 20);
            this.textBoxColor.TabIndex = 11;
            // 
            // label4Model
            // 
            this.label4Model.AutoSize = true;
            this.label4Model.Location = new System.Drawing.Point(56, 12);
            this.label4Model.Name = "label4Model";
            this.label4Model.Size = new System.Drawing.Size(46, 13);
            this.label4Model.TabIndex = 12;
            this.label4Model.Text = "Модель";
            this.label4Model.Click += new System.EventHandler(this.label4_Click);
            // 
            // label4Marka
            // 
            this.label4Marka.AutoSize = true;
            this.label4Marka.Location = new System.Drawing.Point(62, 47);
            this.label4Marka.Name = "label4Marka";
            this.label4Marka.Size = new System.Drawing.Size(40, 13);
            this.label4Marka.TabIndex = 13;
            this.label4Marka.Text = "Марка";
            // 
            // textBoxMarka
            // 
            this.textBoxMarka.Location = new System.Drawing.Point(123, 47);
            this.textBoxMarka.Name = "textBoxMarka";
            this.textBoxMarka.Size = new System.Drawing.Size(100, 20);
            this.textBoxMarka.TabIndex = 14;
            // 
            // textBoxModel
            // 
            this.textBoxModel.Location = new System.Drawing.Point(123, 12);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(100, 20);
            this.textBoxModel.TabIndex = 15;
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(12, 137);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(105, 13);
            this.labelCount.TabIndex = 16;
            this.labelCount.Text = "Количетсво дверок";
            this.labelCount.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // CountDoors
            // 
            this.CountDoors.Location = new System.Drawing.Point(123, 137);
            this.CountDoors.Name = "CountDoors";
            this.CountDoors.Size = new System.Drawing.Size(110, 20);
            this.CountDoors.TabIndex = 17;
            // 
            // Form_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 397);
            this.Controls.Add(this.CountDoors);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.textBoxModel);
            this.Controls.Add(this.textBoxMarka);
            this.Controls.Add(this.label4Marka);
            this.Controls.Add(this.label4Model);
            this.Controls.Add(this.textBoxColor);
            this.Controls.Add(this.button2_Cancel);
            this.Controls.Add(this.button1_Add);
            this.Controls.Add(this.comboBoxBody);
            this.Controls.Add(this.comboBoxEngine);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_Add";
            this.Text = "Add";
            ((System.ComponentModel.ISupportInitialize)(this.CountDoors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxEngine;
        private System.Windows.Forms.ComboBox comboBoxBody;
        private System.Windows.Forms.Button button1_Add;
        private System.Windows.Forms.Button button2_Cancel;
        private System.Windows.Forms.TextBox textBoxColor;
        private System.Windows.Forms.Label label4Model;
        private System.Windows.Forms.Label label4Marka;
        private System.Windows.Forms.TextBox textBoxMarka;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.NumericUpDown CountDoors;
    }
}