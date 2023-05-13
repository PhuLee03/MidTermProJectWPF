using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewLogin
{
    public partial class Static_Form : Form
    {
        public Static_Form()
        {
            InitializeComponent();
        }
        private void Static_Form_Load(object sender, EventArgs e)
        {
            STUDENTS student = new STUDENTS();
            double total = Convert.ToDouble(student.totalStudent());
            double totalmale = Convert.ToDouble(student.totalMale());
            double totalfemale = Convert.ToDouble(student.totalFemale());
            double totalother = Convert.ToDouble(student.totalOther());
            double male_Percent = (totalmale / (total));
            double female_Percent = (totalfemale / (total));
            double other_Percent = (totalother / (total));
            Total_Label.Text = ("Students: " + total.ToString());
            Chartt.Series["Student Chart"].Points.AddXY(male_Percent.ToString("0.00" + "%"), male_Percent);
            Chartt.Series["Student Chart"].Points.AddXY(female_Percent.ToString("0.00" + "%"), female_Percent);
            Chartt.Series["Student Chart"].Points.AddXY(other_Percent.ToString("0.00" + "%"), other_Percent);
        }
    }
}
