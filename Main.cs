using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Laba_Entity
{
    public partial class Main : Form
    {
        AppContext db = new AppContext();
        public Main()
        {
            InitializeComponent();
            add_data();

            comboBoxFilter1.DataSource = (db.Type_Bodies.Select(p => new { p.Type_BodyID, p.NameBody })).ToList();
            comboBoxFilter1.ValueMember = "Type_BodyID";
            comboBoxFilter1.DisplayMember = "NameBody";

            Refresh();
        }

        private void add_data()
        {
            if (db.Avtos.Any()) 
            {
                return;
            }
            else
            {
                Engine engine = new Engine();
                engine.EngineID = 1;
                engine.Type_Engine = "Дизель";
                Engine engine1 = new Engine();
                engine1.EngineID = 2;
                engine1.Type_Engine = "Бензин";
                Engine engine2 = new Engine();
                engine2.EngineID = 3;
                engine2.Type_Engine = "Газ";

                Type_Body body = new Type_Body();
                body.Type_BodyID = 1;
                body.NameBody = "Пикап";
                Type_Body body1 = new Type_Body();
                body1.Type_BodyID = 2;
                body1.NameBody = "Универсал";
                Type_Body body2 = new Type_Body();
                body2.Type_BodyID = 3;
                body2.NameBody = "Седан";

                db.Engines.Add(engine);
                db.Engines.Add(engine1);
                db.Engines.Add(engine2);

                db.Type_Bodies.Add(body);
                db.Type_Bodies.Add(body1);
                db.Type_Bodies.Add(body2);

                db.SaveChanges();
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Form_Add form = new Form_Add();
            form.buttonUpdate.Visible = false;
            form.button1_Add.Visible = true;
            form.ShowDialog();
            Refresh();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            int index;
            try { index = dataGridView1.SelectedRows[0].Index; }
            catch { index = 1; }
            
            int id;
            bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
            if (converted == false)
                return;

            Avto avto = db.Avtos.Find(id);

            Form_Add edit = new Form_Add();


            edit.getModel = avto.Model;
            edit.getMarka = avto.Marka;
            edit.getColor = avto.Color;
            edit.getCountDoors = avto.Count_Doors;
            edit.getEngine = avto.EngineID;
            edit.getBody = avto.Type_BodyID;

            edit.buttonUpdate.Visible = true;
            edit.button1_Add.Visible = false;
            edit.ShowDialog();

            avto.Model = edit.getModel;
            avto.Marka = edit.getMarka;
            avto.Color = edit.getColor;
            avto.Count_Doors = edit.getCountDoors;
            avto.EngineID = edit.getEngine;
            avto.Type_BodyID = edit.getBody;

            db.SaveChanges();
            Refresh();

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.SelectedRows[0].Index;
            int id = 0;
            bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
            if (converted == false)
                return;

            Avto avto = db.Avtos.Find(id);
            db.Avtos.Remove(avto);

            db.SaveChanges();
            Refresh();
        }

        private void Refresh()
        {
            dataGridView1.DataSource = (db.Avtos.Select(p => new
            {
                Id = p.Id,
                ModelName = p.Model,
                MarkaName = p.Marka,
                ColorAvto = p.Color,
                Doors = p.Count_Doors,
                Engine = p.Engines.Type_Engine,
                Body = p.TypesBodies.NameBody
            })).ToList();
        }

        private void buttonEngine_Click(object sender, EventArgs e)
        {
            Engine_Form engine = new Engine_Form();
            engine.dataGridView_body.Visible = false;
            engine.label_engine_body.Visible = false;
            engine.button_body_add.Visible = false;
            engine.button_body_edit.Visible = false;
            engine.button_body_delete.Visible = false;

            engine.ShowDialog();
        }

        private void buttonBody_Click(object sender, EventArgs e)
        {
            Engine_Form body = new Engine_Form();
            body.dataGridView_engine.Visible = false;
            body.label_engine_engine.Visible = false;
            body.button_engine_add.Visible = false;
            body.button_engine_edit.Visible = false;
            body.button_engine_delete.Visible = false;

            body.ShowDialog();
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {

            int id;
            bool result = int.TryParse(comboBoxFilter1.SelectedValue.ToString(), out id);

            var data = (db.Avtos.Where(p => p.Type_BodyID == id).Select(p => new
            {
                p.Id,
                p.Model,
                p.Marka,
                p.Color,
                CountDoors = p.Count_Doors,
                Engine = p.Engines.Type_Engine,
                Body = p.TypesBodies.NameBody
            })).ToList();
            dataGridView1.DataSource = data;

            if (textBoxFilter.Text.Length > 0 )
            {
                dataGridView1.DataSource = data.Where(p => p.Model.ToLower().StartsWith(textBoxFilter.Text.ToLower())).Select(p => new
                {
                    p.Id,
                    p.Model,
                    p.Marka,
                    p.Color,
                    p.CountDoors,
                    p.Engine,
                    p.Body
                }).ToList();

            }
        }

        private void buttonFilterCancel_Click(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
