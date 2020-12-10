namespace Laba_Entity
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.comboBoxFilter1 = new System.Windows.Forms.ComboBox();
            this.buttonEngine = new System.Windows.Forms.Button();
            this.buttonBody = new System.Windows.Forms.Button();
            this.textBoxFilter = new System.Windows.Forms.TextBox();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonFilterCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(638, 217);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(665, 12);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(102, 23);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(665, 41);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(102, 23);
            this.buttonEdit.TabIndex = 2;
            this.buttonEdit.Text = "Редактировать";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(665, 70);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(102, 21);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // comboBoxFilter1
            // 
            this.comboBoxFilter1.FormattingEnabled = true;
            this.comboBoxFilter1.Location = new System.Drawing.Point(776, 28);
            this.comboBoxFilter1.Name = "comboBoxFilter1";
            this.comboBoxFilter1.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFilter1.TabIndex = 4;
            // 
            // buttonEngine
            // 
            this.buttonEngine.Location = new System.Drawing.Point(665, 122);
            this.buttonEngine.Name = "buttonEngine";
            this.buttonEngine.Size = new System.Drawing.Size(102, 22);
            this.buttonEngine.TabIndex = 5;
            this.buttonEngine.Text = "Двигателя";
            this.buttonEngine.UseVisualStyleBackColor = true;
            this.buttonEngine.Click += new System.EventHandler(this.buttonEngine_Click);
            // 
            // buttonBody
            // 
            this.buttonBody.Location = new System.Drawing.Point(665, 152);
            this.buttonBody.Name = "buttonBody";
            this.buttonBody.Size = new System.Drawing.Size(102, 22);
            this.buttonBody.TabIndex = 6;
            this.buttonBody.Text = "Кузова";
            this.buttonBody.UseVisualStyleBackColor = true;
            this.buttonBody.Click += new System.EventHandler(this.buttonBody_Click);
            // 
            // textBoxFilter
            // 
            this.textBoxFilter.Location = new System.Drawing.Point(776, 82);
            this.textBoxFilter.Name = "textBoxFilter";
            this.textBoxFilter.Size = new System.Drawing.Size(118, 20);
            this.textBoxFilter.TabIndex = 7;
            // 
            // buttonFilter
            // 
            this.buttonFilter.Location = new System.Drawing.Point(776, 122);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(118, 22);
            this.buttonFilter.TabIndex = 8;
            this.buttonFilter.Text = "Применить фильтр";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(773, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Фильтр по кузову";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(773, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Фильтр по модели";
            // 
            // buttonFilterCancel
            // 
            this.buttonFilterCancel.Location = new System.Drawing.Point(776, 152);
            this.buttonFilterCancel.Name = "buttonFilterCancel";
            this.buttonFilterCancel.Size = new System.Drawing.Size(118, 22);
            this.buttonFilterCancel.TabIndex = 11;
            this.buttonFilterCancel.Text = "Сбросить фильтр";
            this.buttonFilterCancel.UseVisualStyleBackColor = true;
            this.buttonFilterCancel.Click += new System.EventHandler(this.buttonFilterCancel_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 279);
            this.Controls.Add(this.buttonFilterCancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonFilter);
            this.Controls.Add(this.textBoxFilter);
            this.Controls.Add(this.buttonBody);
            this.Controls.Add(this.buttonEngine);
            this.Controls.Add(this.comboBoxFilter1);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Main";
            this.Text = "Avtosalon";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.ComboBox comboBoxFilter1;
        private System.Windows.Forms.Button buttonEngine;
        private System.Windows.Forms.Button buttonBody;
        private System.Windows.Forms.TextBox textBoxFilter;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonFilterCancel;
    }
}

