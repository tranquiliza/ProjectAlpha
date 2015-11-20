using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterFaceProjectAlpha
{    
    public partial class Form_Measurement_1 : Form
    {
        Measurement_Interface_Controller MIC = new Measurement_Interface_Controller();
        int currentSheetID = 0;
        int currentMeasurementID;
        public Form_Measurement_1()
        {
            InitializeComponent();
            panel1.Visible = false;
            panel3.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MIC.newMeasurementSheet(textBox1.Text, textBox2.Text);
            currentSheetID = MIC.getCurrentID(textBox1.Text, textBox2.Text);
            label3.Text = "ID: " + currentSheetID;
            button1.Visible = false;
            panel1.Visible = true;
            panel3.Visible = true;
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
        }

        private void SelectMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            int matID = DropDown_Material.SelectedIndex + 1;
            DebugLabel1.Text = matID.ToString();
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            MIC.addMeasurement(DropDown_Material.SelectedIndex, Num_Length.Value, currentSheetID);
            Num_Length.Value = 0;
            listBox1.Items.Clear();
            foreach (Measurement item in MIC.getAllMeasurements(currentSheetID))
            {
                currentMeasurementID = item.getMeasurementID();
                listBox1.Items.Add(item.getListBoxInfo());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MIC.deleteMeasurement(currentMeasurementID, currentSheetID);
            listBox1.Items.Clear();
            foreach (Measurement item in MIC.getAllMeasurements(currentSheetID))
            {
                currentMeasurementID = item.getMeasurementID();
                listBox1.Items.Add(item.getListBoxInfo());
            }
        }
    }
}
