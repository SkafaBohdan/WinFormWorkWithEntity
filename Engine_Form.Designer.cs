namespace Laba_Entity
{
    partial class Engine_Form
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
            this.label_engine_engine = new System.Windows.Forms.Label();
            this.label_engine_body = new System.Windows.Forms.Label();
            this.button_engine_add = new System.Windows.Forms.Button();
            this.button_engine_edit = new System.Windows.Forms.Button();
            this.button_engine_delete = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.dataGridView_body = new System.Windows.Forms.DataGridView();
            this.dataGridView_engine = new System.Windows.Forms.DataGridView();
            this.button_body_delete = new System.Windows.Forms.Button();
            this.button_body_edit = new System.Windows.Forms.Button();
            this.button_body_add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_body)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_engine)).BeginInit();
            this.SuspendLayout();
            // 
            // label_engine_engine
            // 
            this.label_engine_engine.AutoSize = true;
            this.label_engine_engine.Location = new System.Drawing.Point(33, 9);
            this.label_engine_engine.Name = "label_engine_engine";
            this.label_engine_engine.Size = new System.Drawing.Size(81, 13);
            this.label_engine_engine.TabIndex = 0;
            this.label_engine_engine.Text = "Тип двигателя";
            // 
            // label_engine_body
            // 
            this.label_engine_body.AutoSize = true;
            this.label_engine_body.Location = new System.Drawing.Point(33, 9);
            this.label_engine_body.Name = "label_engine_body";
            this.label_engine_body.Size = new System.Drawing.Size(64, 13);
            this.label_engine_body.TabIndex = 1;
            this.label_engine_body.Text = "Тип кузова";
            // 
            // button_engine_add
            // 
            this.button_engine_add.Location = new System.Drawing.Point(412, 36);
            this.button_engine_add.Name = "button_engine_add";
            this.button_engine_add.Size = new System.Drawing.Size(75, 23);
            this.button_engine_add.TabIndex = 4;
            this.button_engine_add.Text = "Добавить";
            this.button_engine_add.UseVisualStyleBackColor = true;
            this.button_engine_add.Click += new System.EventHandler(this.button_engine_add_Click);
            // 
            // button_engine_edit
            // 
            this.button_engine_edit.Location = new System.Drawing.Point(412, 77);
            this.button_engine_edit.Name = "button_engine_edit";
            this.button_engine_edit.Size = new System.Drawing.Size(75, 23);
            this.button_engine_edit.TabIndex = 5;
            this.button_engine_edit.Text = "Изменить";
            this.button_engine_edit.UseVisualStyleBackColor = true;
            this.button_engine_edit.Click += new System.EventHandler(this.button_engine_edit_Click);
            // 
            // button_engine_delete
            // 
            this.button_engine_delete.Location = new System.Drawing.Point(412, 121);
            this.button_engine_delete.Name = "button_engine_delete";
            this.button_engine_delete.Size = new System.Drawing.Size(75, 23);
            this.button_engine_delete.TabIndex = 6;
            this.button_engine_delete.Text = "Удалить";
            this.button_engine_delete.UseVisualStyleBackColor = true;
            this.button_engine_delete.Click += new System.EventHandler(this.button_engine_delete_Click);
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(412, 158);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(75, 23);
            this.button_close.TabIndex = 7;
            this.button_close.Text = "Закрыть";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // dataGridView_body
            // 
            this.dataGridView_body.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_body.Location = new System.Drawing.Point(12, 36);
            this.dataGridView_body.Name = "dataGridView_body";
            this.dataGridView_body.Size = new System.Drawing.Size(382, 145);
            this.dataGridView_body.TabIndex = 8;
            // 
            // dataGridView_engine
            // 
            this.dataGridView_engine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_engine.Location = new System.Drawing.Point(12, 36);
            this.dataGridView_engine.Name = "dataGridView_engine";
            this.dataGridView_engine.Size = new System.Drawing.Size(382, 145);
            this.dataGridView_engine.TabIndex = 9;
            // 
            // button_body_delete
            // 
            this.button_body_delete.Location = new System.Drawing.Point(412, 121);
            this.button_body_delete.Name = "button_body_delete";
            this.button_body_delete.Size = new System.Drawing.Size(75, 23);
            this.button_body_delete.TabIndex = 12;
            this.button_body_delete.Text = "Удалить";
            this.button_body_delete.UseVisualStyleBackColor = true;
            this.button_body_delete.Click += new System.EventHandler(this.button_body_delete_Click);
            // 
            // button_body_edit
            // 
            this.button_body_edit.Location = new System.Drawing.Point(412, 77);
            this.button_body_edit.Name = "button_body_edit";
            this.button_body_edit.Size = new System.Drawing.Size(75, 23);
            this.button_body_edit.TabIndex = 11;
            this.button_body_edit.Text = "Изменить";
            this.button_body_edit.UseVisualStyleBackColor = true;
            this.button_body_edit.Click += new System.EventHandler(this.button_body_edit_Click);
            // 
            // button_body_add
            // 
            this.button_body_add.Location = new System.Drawing.Point(412, 36);
            this.button_body_add.Name = "button_body_add";
            this.button_body_add.Size = new System.Drawing.Size(75, 23);
            this.button_body_add.TabIndex = 10;
            this.button_body_add.Text = "Добавить";
            this.button_body_add.UseVisualStyleBackColor = true;
            this.button_body_add.Click += new System.EventHandler(this.button_body_add_Click);
            // 
            // Engine_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 230);
            this.Controls.Add(this.button_body_delete);
            this.Controls.Add(this.button_body_edit);
            this.Controls.Add(this.button_body_add);
            this.Controls.Add(this.dataGridView_engine);
            this.Controls.Add(this.dataGridView_body);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_engine_delete);
            this.Controls.Add(this.button_engine_edit);
            this.Controls.Add(this.button_engine_add);
            this.Controls.Add(this.label_engine_body);
            this.Controls.Add(this.label_engine_engine);
            this.Name = "Engine_Form";
            this.Text = "Engine_Form";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_body)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_engine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button button_engine_add;
        public System.Windows.Forms.Button button_engine_edit;
        public System.Windows.Forms.Button button_engine_delete;
        private System.Windows.Forms.Button button_close;
        public System.Windows.Forms.Label label_engine_engine;
        public System.Windows.Forms.Label label_engine_body;
        public System.Windows.Forms.DataGridView dataGridView_body;
        public System.Windows.Forms.DataGridView dataGridView_engine;
        public System.Windows.Forms.Button button_body_delete;
        public System.Windows.Forms.Button button_body_edit;
        public System.Windows.Forms.Button button_body_add;
    }
}