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
    public partial class Form_Add : Form
    {
        AppContext db = new AppContext();
        public Form_Add()
        {
            InitializeComponent();

            comboBoxEngine.DataSource = (db.Engines.Select(p => new { p.EngineID, p.Type_Engine })).ToList();
            comboBoxEngine.ValueMember = "EngineID";
            comboBoxEngine.DisplayMember = "Type_Engine";

            comboBoxBody.DataSource = (db.Type_Bodies.Select(p => new { p.Type_BodyID, p.NameBody })).ToList();
            comboBoxBody.ValueMember = "Type_BodyID";
            comboBoxBody.DisplayMember = "NameBody";

        }

        private void button1_Add_Click(object sender, EventArgs e)
        {
            Avto avto = new Avto
            {
                Model = textBoxModel.Text,
                Marka = textBoxMarka.Text,
                EngineID = getEngine,
                Type_BodyID = getBody,
                Count_Doors = Convert.ToInt32(CountDoors.Text),
                Color = textBoxColor.Text
            };
            db.Avtos.Add(avto);
            db.SaveChanges();
            this.Close();
        }

        private void button2_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public string getModel
        {
            get { return textBoxModel.Text; }
            set { textBoxModel.Text = value; }
        }

        public string getMarka
        {
            get { return textBoxMarka.Text; }
            set { textBoxMarka.Text = value; }
        }

        public string getColor
        {
            get { return textBoxColor.Text; }
            set { textBoxColor.Text = value; }
        }

        public int getCountDoors
        {
            get { return (int)CountDoors.Value; }
            set { CountDoors.Value = (int)value; }
        }

        public int getBody
        {
            get { return comboBoxBody.SelectedIndex + 1; }
            set { comboBoxBody.SelectedIndex = value - 1; }
        }

        public int getEngine
        {
            get { return comboBoxEngine.SelectedIndex + 1; }
            set { comboBoxEngine.SelectedIndex = value - 1; }
        }



        private void buttonUpdate_Click(object sender, EventArgs e)
        {

            db.SaveChanges();
            this.Close();

        }
    }
}
