using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.YangolenkoDS.Sprint7.Project.V1.Lib;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tyuiu.YangolenkoDS.Sprint7.Project.V1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        public string openFilePath;
        private List<Product> LoadCSV(string csvFile)
        {
            var query = from l in File.ReadAllLines(csvFile)
                        let data = l.Split(';')
                        select new Product
                        {
                            Surname = data[0],
                            Name = data[1],
                            Patronymic = data[2],
                            PhoneNumber = data[3],
                            Brand = data[4],
                            Power = data[5],
                            Colour = data[6],
                            DriverID = data[7]
                        };
            return query.ToList();
        }


        private void panelDataBase_YDS_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonOpenFile_YDS_Click(object sender, EventArgs e)
        {
            openFileDialog_YDS.ShowDialog();
            openFilePath = openFileDialog_YDS.FileName;
            dataGridViewDataBase_YDS.DataSource = LoadCSV(openFilePath);
        }

        private void buttonSaveFile_YDS_Click(object sender, EventArgs e)
        {

        }

        private void buttonDelete_YDS_Click(object sender, EventArgs e)
        {
            dataGridViewDataBase_YDS.DataSource = null;
        }

        private void Search(object sender, EventArgs e)
        {
            (dataGridViewDataBase_YDS.DataSource as DataTable).DefaultView.RowFilter = string.Format("Name LIKE '%{0}%'", textBoxSearch_YDS.Text);

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void buttonHelp_YDS_Click(object sender, EventArgs e)
        {
            FormAbout fa = new FormAbout();
            fa.ShowDialog();
        }
    }
    public class Product
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string PhoneNumber { get; set; }
        public string Brand { get; set; }
        public string Power { get; set; }
        public string Colour { get; set; }
        public string DriverID { get; set; }
    }
}

