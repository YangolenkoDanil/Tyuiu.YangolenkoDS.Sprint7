﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
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
                    MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    openFileDialog_YDS.ShowDialog();
                    openFilePath = openFileDialog_YDS.FileName;
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
                    MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            column = dataGridViewDataBase_YDS.Columns.Count;
            rows = dataGridViewDataBase_YDS.Rows.Count;

            buttonSaveFile_YDS.Enabled = true;
            buttonDelete_YDS.Enabled = true;
            textBoxSearch_YDS.Enabled = true;
            buttonCancelChanges_YDS.Enabled = true;

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
        }


        private void textBoxSearch_YDS_TextChanged(object sender, EventArgs e)
        {
            string searchValue = textBoxSearch_YDS.Text.ToLower();

            foreach (DataGridViewRow row in dataGridViewDataBase_YDS.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().ToLower().Contains(searchValue))
                    {
                        cell.Style.BackColor = Color.Yellow;
                    }
                    else
                    {
                        cell.Style.BackColor = Color.White;
                    }
                }
            }
        }

        private void buttonStopSearch_YDS_Click(object sender, EventArgs e)
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
                    MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            column = dataGridViewDataBase_YDS.Columns.Count;
            rows = dataGridViewDataBase_YDS.Rows.Count;
        }

        private void dataGridViewDataBase_YDS_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
        }

        private void dataGridViewDataBase_YDS_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {           
        }

        private void dataGridViewDataBase_YDS_SelectionChanged(object sender, EventArgs e)
        {
            dataGridViewDataBase_YDS.ClearSelection();
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

