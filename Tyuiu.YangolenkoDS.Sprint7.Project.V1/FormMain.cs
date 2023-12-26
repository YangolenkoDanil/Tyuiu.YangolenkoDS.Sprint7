using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
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
            openFileDialog_YDS.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialog_YDS.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }
        public string openFilePath;
        public int column, rows;
        bool issemicolon = true;
        private void panelDataBase_YDS_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonOpenFile_YDS_Click(object sender, EventArgs e)
        {
            dataGridViewDataBase_YDS.Rows.Clear();
            if (!issemicolon)
            {
                try
                {
                    dataGridViewDataBase_YDS.AllowUserToAddRows = false;
                    openFileDialog_YDS.ShowDialog();
                    openFilePath = openFileDialog_YDS.FileName;
                    column = File.ReadAllLines(openFilePath, Encoding.UTF8).Length + 1;


                    dataGridViewDataBase_YDS.ColumnCount = column;
                    using (var reader = new StreamReader(openFilePath))
                    {
                        while (!reader.EndOfStream)
                        {
                            var line = reader.ReadLine();
                            var values = line.Split(',');

                            dataGridViewDataBase_YDS.Rows.Add(values);
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Выбран неверный файл!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    openFileDialog_YDS.ShowDialog();
                    openFilePath = openFileDialog_YDS.FileName;
                    column = File.ReadAllLines(openFilePath, Encoding.UTF8).Length + 1;

                    dataGridViewDataBase_YDS.AllowUserToAddRows = false;
                    dataGridViewDataBase_YDS.ColumnCount = column;
                    using (var reader = new StreamReader(openFilePath))
                    {
                        while (!reader.EndOfStream)
                        {
                            var line = reader.ReadLine();
                            var values = line.Split(';');

                            dataGridViewDataBase_YDS.Rows.Add(values);
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Выбран неверный файл!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            column = dataGridViewDataBase_YDS.Columns.Count;
            rows = dataGridViewDataBase_YDS.Rows.Count;

            dataGridViewDataBase_YDS.Rows[0].Cells[0].Selected = false;

            buttonSaveFile_YDS.Enabled = true;
            buttonDelete_YDS.Enabled = true;
            textBoxSearch_YDS.Enabled = true;
            buttonCancelChanges_YDS.Enabled = true;
            textBoxAvg_YDS.Enabled = true;
            textBoxMax_YDS.Enabled = true;
            textBoxMin_YDS.Enabled = true;
            buttonStopMinMaxAvg_YDS.Enabled = true;
            buttonSearch_YDS.Enabled = true;
            buttonStartValues_YDS.Enabled = true;
            buttonAdd_YDS.Enabled = true;
            buttonDeleteRow_YDS.Enabled = true;
            buttonCharPie_YDS.Enabled = true;
            textBoxFiltr_YDS.Enabled = true;
            buttonFiltr_YDS.Enabled = true;
            buttonDeleteChart_YDS.Enabled = true;
            buttonCancelFiltr_YDS.Enabled = true;
            buttonStopSearch_YDS.Enabled = true;
        }


        private void buttonSaveFile_YDS_Click(object sender, EventArgs e)
        {
            if (!issemicolon)
            {
                try
                {
                    saveFileDialog_YDS.FileName = ".csv";
                    saveFileDialog_YDS.InitialDirectory = @":L";
                    if (saveFileDialog_YDS.ShowDialog() == DialogResult.OK)
                    {
                        string savepath = saveFileDialog_YDS.FileName;

                        if (File.Exists(savepath)) File.Delete(savepath);

                        int rows = dataGridViewDataBase_YDS.RowCount;
                        int columns = dataGridViewDataBase_YDS.ColumnCount;

                        StringBuilder strBuilder = new StringBuilder();

                        for (int i = 0; i < rows; i++)
                        {
                            for (int j = 0; j < columns; j++)
                            {
                                strBuilder.Append(dataGridViewDataBase_YDS.Rows[i].Cells[j].Value);

                                if (j != columns - 1) strBuilder.Append(",");
                            }
                            strBuilder.AppendLine();
                        }
                        File.WriteAllText(savepath, strBuilder.ToString(), Encoding.UTF8);
                        MessageBox.Show("Файл успешно сохранен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {
                    MessageBox.Show("Файл не сохранен", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    saveFileDialog_YDS.FileName = ".csv";
                    saveFileDialog_YDS.InitialDirectory = @":L";
                    if (saveFileDialog_YDS.ShowDialog() == DialogResult.OK)
                    {
                        string savepath = saveFileDialog_YDS.FileName;

                        if (File.Exists(savepath)) File.Delete(savepath);

                        int rows = dataGridViewDataBase_YDS.RowCount;
                        int columns = dataGridViewDataBase_YDS.ColumnCount;

                        StringBuilder strBuilder = new StringBuilder();

                        for (int i = 0; i < rows; i++)
                        {
                            for (int j = 0; j < columns; j++)
                            {
                                strBuilder.Append(dataGridViewDataBase_YDS.Rows[i].Cells[j].Value);

                                if (j != columns - 1) strBuilder.Append(";");
                            }
                            strBuilder.AppendLine();
                        }
                        File.WriteAllText(savepath, strBuilder.ToString(), Encoding.UTF8);
                        MessageBox.Show("Файл успешно сохранен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {
                    MessageBox.Show("Файл не сохранен", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void buttonDelete_YDS_Click(object sender, EventArgs e)
        {
            dataGridViewDataBase_YDS.Rows.Clear();

            buttonSaveFile_YDS.Enabled = false;
            buttonDelete_YDS.Enabled = false;
            textBoxSearch_YDS.Enabled = false;
            buttonCancelChanges_YDS.Enabled = false;
            textBoxAvg_YDS.Enabled = false;
            textBoxMax_YDS.Enabled = false;
            textBoxMin_YDS.Enabled = false;
            buttonStopMinMaxAvg_YDS.Enabled = false;
            buttonSearch_YDS.Enabled = false;
            buttonStartValues_YDS.Enabled = false;
            buttonAdd_YDS.Enabled = false;
            buttonDeleteRow_YDS.Enabled = false;
            buttonCharPie_YDS.Enabled = false;
            textBoxFiltr_YDS.Enabled = false;
            buttonFiltr_YDS.Enabled = false;
            buttonDeleteChart_YDS.Enabled = false;
            buttonCancelFiltr_YDS.Enabled = false;
            buttonStopSearch_YDS.Enabled = false;
        }

        private void buttonHelp_YDS_Click(object sender, EventArgs e)
        {
            FormAbout fa = new FormAbout();
            fa.ShowDialog();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            buttonSaveFile_YDS.Enabled = false;
            buttonDelete_YDS.Enabled = false;
            textBoxSearch_YDS.Enabled = false;
            buttonCancelChanges_YDS.Enabled = false;
            textBoxAvg_YDS.Enabled = false;
            textBoxMax_YDS.Enabled = false;
            textBoxMin_YDS.Enabled = false;
            buttonStopMinMaxAvg_YDS.Enabled = false;
            buttonSearch_YDS.Enabled = false;
            buttonStartValues_YDS.Enabled = false;
            buttonAdd_YDS.Enabled = false;
            buttonDeleteRow_YDS.Enabled = false;
            buttonCharPie_YDS.Enabled = false;
            textBoxFiltr_YDS.Enabled = false;
            buttonFiltr_YDS.Enabled = false;
            buttonDeleteChart_YDS.Enabled = false;
            buttonCancelFiltr_YDS.Enabled = false;
            buttonStopSearch_YDS.Enabled = false;
        }


        private void textBoxSearch_YDS_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonStopSearch_YDS_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    dataGridViewDataBase_YDS.Rows[i].Cells[j].Style.BackColor = Color.White;
                }
            }
            try
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < column; j++)
                    {
                        if (dataGridViewDataBase_YDS.Rows[i].Cells[j].Value != null && dataGridViewDataBase_YDS.Rows[i].Cells[j].Value.ToString().ToLower().Contains(textBoxSearch_YDS.Text.ToLower()))
                        {
                            dataGridViewDataBase_YDS.Rows[i].Cells[j].Style.BackColor = Color.LightGreen;
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Что-то пошло не так", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancelChanges_YDS_Click(object sender, EventArgs e)
        {
            dataGridViewDataBase_YDS.Rows.Clear();
            if (!issemicolon)
            {
                try
                {
                    column = File.ReadAllLines(openFilePath, Encoding.UTF8).Length + 1;


                    dataGridViewDataBase_YDS.ColumnCount = column;
                    using (var reader = new StreamReader(openFilePath))
                    {
                        while (!reader.EndOfStream)
                        {
                            var line = reader.ReadLine();
                            var values = line.Split(',');

                            dataGridViewDataBase_YDS.Rows.Add(values);
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Что-то пошло не так", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    column = File.ReadAllLines(openFilePath, Encoding.UTF8).Length + 1;


                    dataGridViewDataBase_YDS.ColumnCount = column;
                    using (var reader = new StreamReader(openFilePath))
                    {
                        while (!reader.EndOfStream)
                        {
                            var line = reader.ReadLine();
                            var values = line.Split(';');

                            dataGridViewDataBase_YDS.Rows.Add(values);
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Что-то пошло не так", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            column = dataGridViewDataBase_YDS.Columns.Count;
            rows = dataGridViewDataBase_YDS.Rows.Count;

            dataGridViewDataBase_YDS.Rows[0].Cells[0].Selected = false;
        }

        private void dataGridViewDataBase_YDS_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
        }

        private void dataGridViewDataBase_YDS_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {           
        }

        private void dataGridViewDataBase_YDS_SelectionChanged(object sender, EventArgs e)
        {
        }



        private void buttonStopMinMaxAvg_YDS_Click(object sender, EventArgs e)
        {
            textBoxAvg_YDS.Text = null;
            textBoxMax_YDS.Text = null;
            textBoxMin_YDS.Text = null;
        }

        private void buttonStartValues_YDS_Click(object sender, EventArgs e)
        {

            DataService ds = new DataService();
            try
            {
                int[] PowerCol = new int[rows - 1];
                int k = 1;
                for (int i = 0; i < PowerCol.Length; i++)
                {
                    PowerCol[i] = Convert.ToInt32(dataGridViewDataBase_YDS.Rows[k].Cells[5].Value.ToString());
                    k++;
                }
                textBoxMax_YDS.Text = ds.GetMaxValue(PowerCol).ToString();
                textBoxMin_YDS.Text = ds.GetMinValue(PowerCol).ToString();
                textBoxAvg_YDS.Text = ds.GetAvgValue(PowerCol).ToString();
            }
            catch
            {
                MessageBox.Show("Что-то пошло не так", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
        }

        private void buttonAdd_YDS_Click(object sender, EventArgs e)
        {
            dataGridViewDataBase_YDS.Rows.Add();
            rows++;

        }

        private void buttonDeleteRow_YDS_Click(object sender, EventArgs e)
        {
            dataGridViewDataBase_YDS.Rows.RemoveAt(dataGridViewDataBase_YDS.Rows.Count - 1);
            rows--;
        }

        private void buttonCharPie_YDS_Click(object sender, EventArgs e)
        {
            try
            {
                chartPower_YDS.Series[0].Points.Clear();
                string[] Brand = new string[rows - 1];
                int[] PowerCol = new int[rows - 1];
                int k = 1;
                int n = 1;
                for (int i = 0; i < PowerCol.Length; i++)
                {
                    PowerCol[i] = Convert.ToInt32(dataGridViewDataBase_YDS.Rows[k].Cells[5].Value.ToString());
                    k++;
                }
                for (int i = 0; i < Brand.Length; i++)
                {
                    Brand[i] = dataGridViewDataBase_YDS.Rows[n].Cells[4].Value.ToString();
                    n++;
                }
                string[] Brand1 = Brand.Distinct().ToArray();
                int[] PowerCol1 = PowerCol.Distinct().ToArray();
                for (int i = 0; i < PowerCol1.Length; i++)
                {
                    chartPower_YDS.Series[0].Points.AddXY(Brand1[i], Convert.ToString(PowerCol1[i]));
                }
            }
            catch
            {
                MessageBox.Show("Не удалось построить диаграмму", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
        }

        private void buttonDeleteChart_YDS_Click(object sender, EventArgs e)
        {
            chartPower_YDS.Series[0].Points.Clear();
        }

        private void checkBoxTochZap_YDS_CheckedChanged(object sender, EventArgs e)
        {
            if (issemicolon)
            {
                issemicolon = false;
            }
            else
            {
                issemicolon = true;
            }
        }

        private void buttonFiltr_YDS_Click(object sender, EventArgs e)
        {

            dataGridViewDataBase_YDS.ClearSelection();

            try
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < column; j++)
                    {
                        if (dataGridViewDataBase_YDS.Rows[i].Cells[j].Value != null && dataGridViewDataBase_YDS.Rows[i].Cells[j].Value.ToString().ToLower().Contains(textBoxFiltr_YDS.Text.ToLower()))
                        {
                            dataGridViewDataBase_YDS.Rows[i].Selected = true;
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Что-то пошло не так", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
        }

        private void textBoxFiltr_YDS_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCancelFiltr_YDS_Click(object sender, EventArgs e)
        {
            dataGridViewDataBase_YDS.ClearSelection();
            textBoxFiltr_YDS.Text = null;
        }

        private void buttonStopSearch_YDS_Click_1(object sender, EventArgs e)
        {
            textBoxSearch_YDS.Text = null;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    dataGridViewDataBase_YDS.Rows[i].Cells[j].Style.BackColor = Color.White;
                }
            }
        }

        private void dataGridViewDataBase_YDS_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
        {
            int so = 1;
            if (dataGridViewDataBase_YDS.SortOrder == SortOrder.Ascending)
            {
                so = -1;
            }
            if (e.RowIndex1 == 0)
            {
                e.SortResult = so;
                e.Handled = true;
            }
            if (e.RowIndex2 == 0)
            {
                e.SortResult = -so;
                e.Handled = true;
            }
        }
    }
}

