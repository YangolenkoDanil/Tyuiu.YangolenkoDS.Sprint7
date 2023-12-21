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

using Tyuiu.YangolenkoDS.Sprint7.Project.V1;
using Tyuiu.YangolenkoDS.Sprint7.Project.V1.Lib;

namespace Tyuiu.YangolenkoDS.Sprint7.Project.V1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialog_YDS.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialog_YDS.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }

        DataService ds = new DataService();
        string path;
        string[,] array;
        int rows;

        private void panelDataBase_YDS_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonOpenFile_YDS_Click(object sender, EventArgs e)
        {
            try
            {
                FormMain formmain = new FormMain();
                openFileDialog_YDS.ShowDialog();
                path = openFileDialog_YDS.FileName;
                array = ds.GetMatrix(path);
                rows = array.GetUpperBound(0) + 1;
                dataGridViewDataBase_YDS.RowCount = rows;
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        dataGridViewDataBase_YDS.Rows[i].Cells[j].Value = array[i, j];
                    }
                }
            } 
            catch
            {
                MessageBox.Show("Выбран неверный файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

