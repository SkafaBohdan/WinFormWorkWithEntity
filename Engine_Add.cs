using System;
using System.Windows.Forms;

namespace Laba_Entity
{
    public partial class Engine_Add : Form
    {
        AppContext db = new AppContext();
        public Engine_Add()
        {
            InitializeComponent();
        }

        private void button_engine_add_add_body_Click(object sender, EventArgs e)
        {
            Type_Body body = new Type_Body
            {
                NameBody = textBox_engine_add_body.Text,
            };
            db.Type_Bodies.Add(body);
            db.SaveChanges();
            this.Close();
        }

        private void button_engine_add_edit_body_Click(object sender, EventArgs e)
        {
            db.SaveChanges();
            this.Close();
        }

        private void button_engine_add_Add_eng_Click(object sender, EventArgs e)
        {
            Engine engine = new Engine
            {
                Type_Engine = textBox_engine_add_engine.Text,
            };
            db.Engines.Add(engine);
            db.SaveChanges();
            this.Close();

        }

        private void button_engine_add_edit_engine_Click(object sender, EventArgs e)
        {
            db.SaveChanges();
            this.Close();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string getEngine
        {
            get { return textBox_engine_add_engine.Text; }
            set { textBox_engine_add_engine.Text = value; }
        }
        public string getBody
        {
            get { return textBox_engine_add_body.Text; }
            set { textBox_engine_add_body.Text = value; }
        }
    }
}
