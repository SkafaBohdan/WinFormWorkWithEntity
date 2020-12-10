using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Laba_Entity
{
    public partial class Engine_Form : Form
    {
        AppContext db = new AppContext();
        public Engine_Form()
        {
            InitializeComponent();
            Refresh_Body();
            Refresh_Engine();
        }

        public void Refresh_Body()
        {
            dataGridView_body.DataSource = (db.Type_Bodies.Select(p => new
            {
                Id = p.Type_BodyID,
                BodyName = p.NameBody
            })).ToList();
        }
        public void Refresh_Engine()
        {
            dataGridView_engine.DataSource = (db.Engines.Select(p => new
            {
                Id = p.EngineID,
                BodyName = p.Type_Engine
            })).ToList();
        }
        private void button_engine_add_Click(object sender, EventArgs e)
        {
            Engine_Add engine = new Engine_Add();
            engine.label_engine_add_body.Visible = false;
            engine.button_engine_add_add_body.Visible = false;
            engine.button_engine_add_edit_body.Visible = false;
            engine.textBox_engine_add_body.Visible = false;
            engine.button_engine_add_edit_engine.Visible = false;

            engine.ShowDialog();
            Refresh_Engine();
        }

        private void button_engine_edit_Click(object sender, EventArgs e)
        {
            int index;
            try { index = dataGridView_engine.SelectedRows[0].Index; }
            catch { index = 0; }
            int id;
            bool converted = Int32.TryParse(dataGridView_engine[0, index].Value.ToString(), out id);
            if (converted == false)
                return;

            Engine engine = db.Engines.Find(id);
            Engine_Add edit = new Engine_Add();

            edit.getEngine = engine.Type_Engine;

            edit.label_engine_add_body.Visible = false;
            edit.button_engine_add_add_body.Visible = false;
            edit.button_engine_add_edit_body.Visible = false;
            edit.textBox_engine_add_body.Visible = false;
            edit.button_engine_add_Add_eng.Visible = false;

            edit.ShowDialog();

            engine.Type_Engine = edit.getEngine;

            db.SaveChanges();
            Refresh_Engine();
        }

        private void button_engine_delete_Click(object sender, EventArgs e)
        {
            int index = dataGridView_engine.SelectedRows[0].Index;
            int id = 0;
            bool converted = Int32.TryParse(dataGridView_engine[0, index].Value.ToString(), out id);
            if (converted == false)
                return;

            Engine engine = db.Engines.Find(id);
            db.Engines.Remove(engine);

            db.SaveChanges();
            Refresh_Engine();
        }

        private void button_body_add_Click(object sender, EventArgs e)
        {
            Engine_Add body = new Engine_Add();
            body.label_engine_add_engine.Visible = false;
            body.button_engine_add_Add_eng.Visible = false;
            body.button_engine_add_edit_engine.Visible = false;
            body.textBox_engine_add_engine.Visible = false;
            body.button_engine_add_edit_body.Visible = false;

            body.ShowDialog();
            Refresh_Body();
        }

        private void button_body_edit_Click(object sender, EventArgs e)
        {
            int index;
            try { index = dataGridView_body.SelectedRows[0].Index; }
            catch { index = 0; }
            int id;
            bool converted = Int32.TryParse(dataGridView_body[0, index].Value.ToString(), out id);
            if (converted == false)
                return;

            Type_Body body = db.Type_Bodies.Find(id);
            Engine_Add edit = new Engine_Add();

            edit.getBody = body.NameBody;

            edit.label_engine_add_engine.Visible = false;
            edit.button_engine_add_Add_eng.Visible = false;
            edit.button_engine_add_edit_engine.Visible = false;
            edit.textBox_engine_add_engine.Visible = false;
            edit.button_engine_add_add_body.Visible = false;

            edit.ShowDialog();

            body.NameBody = edit.getBody;

            db.SaveChanges();
            Refresh_Body();
        }

        private void button_body_delete_Click(object sender, EventArgs e)
        {
            int index = dataGridView_body.SelectedRows[0].Index;
            int id = 0;
            bool converted = Int32.TryParse(dataGridView_body[0, index].Value.ToString(), out id);
            if (converted == false)
                return;

            Type_Body body = db.Type_Bodies.Find(id);
            db.Type_Bodies.Remove(body);

            db.SaveChanges();
            Refresh_Body();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
