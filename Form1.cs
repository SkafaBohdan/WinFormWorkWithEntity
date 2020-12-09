using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba_Entity
{
    public partial class Form1 : Form
    {
        AppContext db = new AppContext();
        public Form1()
        {
            InitializeComponent();
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

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Form_Add form = new Form_Add();
            form.ShowDialog();

            //Engine engine = new Engine();
            //engine.EngineID = 1;
            //engine.Type_Engine = "Дизель";
            //Engine engine1 = new Engine();
            //engine1.EngineID = 2;
            //engine1.Type_Engine = "Бензин";
            //Engine engine2 = new Engine();
            //engine2.EngineID = 3;
            //engine2.Type_Engine = "Газ";

            //Type_Body body = new Type_Body();
            //body.Type_BodyID = 1;
            //body.NameBody = "Пикап";
            //Type_Body body1 = new Type_Body();
            //body1.Type_BodyID = 2;
            //body1.NameBody = "Универсал";
            //Type_Body body2 = new Type_Body();
            //body2.Type_BodyID = 3;
            //body2.NameBody = "Седан";

            //db.Engines.Add(engine);
            //db.Engines.Add(engine1);
            //db.Engines.Add(engine2);

            //db.Type_Bodies.Add(body);
            //db.Type_Bodies.Add(body1);
            //db.Type_Bodies.Add(body2);

            //db.SaveChanges();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.SelectedRows[0].Index;
            int id = 0;
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
    }
}
