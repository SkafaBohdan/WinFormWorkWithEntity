namespace Laba_Entity
{
    partial class Engine_Add
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
            this.button_close = new System.Windows.Forms.Button();
            this.label_engine_add_body = new System.Windows.Forms.Label();
            this.label_engine_add_engine = new System.Windows.Forms.Label();
            this.textBox_engine_add_engine = new System.Windows.Forms.TextBox();
            this.textBox_engine_add_body = new System.Windows.Forms.TextBox();
            this.button_engine_add_Add_eng = new System.Windows.Forms.Button();
            this.button_engine_add_edit_engine = new System.Windows.Forms.Button();
            this.button_engine_add_edit_body = new System.Windows.Forms.Button();
            this.button_engine_add_add_body = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(27, 281);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(75, 23);
            this.button_close.TabIndex = 10;
            this.button_close.Text = "Close";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // label_engine_add_body
            // 
            this.label_engine_add_body.AutoSize = true;
            this.label_engine_add_body.Location = new System.Drawing.Point(24, 27);
            this.label_engine_add_body.Name = "label_engine_add_body";
            this.label_engine_add_body.Size = new System.Drawing.Size(31, 13);
            this.label_engine_add_body.TabIndex = 9;
            this.label_engine_add_body.Text = "Body";
            // 
            // label_engine_add_engine
            // 
            this.label_engine_add_engine.AutoSize = true;
            this.label_engine_add_engine.Location = new System.Drawing.Point(24, 151);
            this.label_engine_add_engine.Name = "label_engine_add_engine";
            this.label_engine_add_engine.Size = new System.Drawing.Size(40, 13);
            this.label_engine_add_engine.TabIndex = 8;
            this.label_engine_add_engine.Text = "Engine";
            // 
            // textBox_engine_add_engine
            // 
            this.textBox_engine_add_engine.Location = new System.Drawing.Point(97, 148);
            this.textBox_engine_add_engine.Name = "textBox_engine_add_engine";
            this.textBox_engine_add_engine.Size = new System.Drawing.Size(100, 20);
            this.textBox_engine_add_engine.TabIndex = 11;
            // 
            // textBox_engine_add_body
            // 
            this.textBox_engine_add_body.Location = new System.Drawing.Point(97, 24);
            this.textBox_engine_add_body.Name = "textBox_engine_add_body";
            this.textBox_engine_add_body.Size = new System.Drawing.Size(100, 20);
            this.textBox_engine_add_body.TabIndex = 12;
            // 
            // button_engine_add_Add_eng
            // 
            this.button_engine_add_Add_eng.Location = new System.Drawing.Point(52, 189);
            this.button_engine_add_Add_eng.Name = "button_engine_add_Add_eng";
            this.button_engine_add_Add_eng.Size = new System.Drawing.Size(75, 23);
            this.button_engine_add_Add_eng.TabIndex = 13;
            this.button_engine_add_Add_eng.Text = "Add";
            this.button_engine_add_Add_eng.UseVisualStyleBackColor = true;
            this.button_engine_add_Add_eng.Click += new System.EventHandler(this.button_engine_add_Add_eng_Click);
            // 
            // button_engine_add_edit_engine
            // 
            this.button_engine_add_edit_engine.Location = new System.Drawing.Point(152, 189);
            this.button_engine_add_edit_engine.Name = "button_engine_add_edit_engine";
            this.button_engine_add_edit_engine.Size = new System.Drawing.Size(75, 23);
            this.button_engine_add_edit_engine.TabIndex = 14;
            this.button_engine_add_edit_engine.Text = "Edit_save";
            this.button_engine_add_edit_engine.UseVisualStyleBackColor = true;
            this.button_engine_add_edit_engine.Click += new System.EventHandler(this.button_engine_add_edit_engine_Click);
            // 
            // button_engine_add_edit_body
            // 
            this.button_engine_add_edit_body.Location = new System.Drawing.Point(152, 59);
            this.button_engine_add_edit_body.Name = "button_engine_add_edit_body";
            this.button_engine_add_edit_body.Size = new System.Drawing.Size(75, 23);
            this.button_engine_add_edit_body.TabIndex = 16;
            this.button_engine_add_edit_body.Text = "Edit_save";
            this.button_engine_add_edit_body.UseVisualStyleBackColor = true;
            this.button_engine_add_edit_body.Click += new System.EventHandler(this.button_engine_add_edit_body_Click);
            // 
            // button_engine_add_add_body
            // 
            this.button_engine_add_add_body.Location = new System.Drawing.Point(52, 59);
            this.button_engine_add_add_body.Name = "button_engine_add_add_body";
            this.button_engine_add_add_body.Size = new System.Drawing.Size(75, 23);
            this.button_engine_add_add_body.TabIndex = 15;
            this.button_engine_add_add_body.Text = "Add";
            this.button_engine_add_add_body.UseVisualStyleBackColor = true;
            this.button_engine_add_add_body.Click += new System.EventHandler(this.button_engine_add_add_body_Click);
            // 
            // Engine_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 450);
            this.Controls.Add(this.button_engine_add_edit_body);
            this.Controls.Add(this.button_engine_add_add_body);
            this.Controls.Add(this.button_engine_add_edit_engine);
            this.Controls.Add(this.button_engine_add_Add_eng);
            this.Controls.Add(this.textBox_engine_add_body);
            this.Controls.Add(this.textBox_engine_add_engine);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.label_engine_add_body);
            this.Controls.Add(this.label_engine_add_engine);
            this.Name = "Engine_Add";
            this.Text = "Engine_Add";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_close;
        public System.Windows.Forms.Label label_engine_add_body;
        public System.Windows.Forms.Label label_engine_add_engine;
        public System.Windows.Forms.Button button_engine_add_Add_eng;
        public System.Windows.Forms.Button button_engine_add_edit_engine;
        public System.Windows.Forms.Button button_engine_add_edit_body;
        public System.Windows.Forms.Button button_engine_add_add_body;
        public System.Windows.Forms.TextBox textBox_engine_add_engine;
        public System.Windows.Forms.TextBox textBox_engine_add_body;
    }
}