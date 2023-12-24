namespace Tyuiu.YangolenkoDS.Sprint7.Project.V1
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelButtons_YDS = new System.Windows.Forms.Panel();
            this.buttonDelete_YDS = new System.Windows.Forms.Button();
            this.buttonOpenFile_YDS = new System.Windows.Forms.Button();
            this.buttonHelp_YDS = new System.Windows.Forms.Button();
            this.LabelTiitle_YDS = new System.Windows.Forms.Label();
            this.panelDataBase_YDS = new System.Windows.Forms.Panel();
            this.groupBoxDataBase_YDS = new System.Windows.Forms.GroupBox();
            this.panelSort_YDS = new System.Windows.Forms.Panel();
            this.groupBoxSort_YDS = new System.Windows.Forms.GroupBox();
            this.labelSeatch_YDS = new System.Windows.Forms.Label();
            this.toolTipHelp_YDS = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialog_YDS = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog_YDS = new System.Windows.Forms.SaveFileDialog();
            this.buttonSaveFile_YDS = new System.Windows.Forms.Button();
            this.dataGridViewDataBase_YDS = new System.Windows.Forms.DataGridView();
            this.textBoxSearch_YDS = new System.Windows.Forms.TextBox();
            this.buttonStopSearch_YDS = new System.Windows.Forms.Button();
            this.buttonCancelChanges_YDS = new System.Windows.Forms.Button();
            this.panelButtons_YDS.SuspendLayout();
            this.panelDataBase_YDS.SuspendLayout();
            this.groupBoxDataBase_YDS.SuspendLayout();
            this.panelSort_YDS.SuspendLayout();
            this.groupBoxSort_YDS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataBase_YDS)).BeginInit();
            this.SuspendLayout();
            // 
            // panelButtons_YDS
            // 
            this.panelButtons_YDS.BackColor = System.Drawing.Color.White;
            this.panelButtons_YDS.Controls.Add(this.buttonCancelChanges_YDS);
            this.panelButtons_YDS.Controls.Add(this.buttonDelete_YDS);
            this.panelButtons_YDS.Controls.Add(this.buttonOpenFile_YDS);
            this.panelButtons_YDS.Controls.Add(this.buttonSaveFile_YDS);
            this.panelButtons_YDS.Controls.Add(this.buttonHelp_YDS);
            this.panelButtons_YDS.Controls.Add(this.LabelTiitle_YDS);
            this.panelButtons_YDS.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons_YDS.Location = new System.Drawing.Point(0, 0);
            this.panelButtons_YDS.Name = "panelButtons_YDS";
            this.panelButtons_YDS.Size = new System.Drawing.Size(1418, 100);
            this.panelButtons_YDS.TabIndex = 0;
            // 
            // buttonDelete_YDS
            // 
            this.buttonDelete_YDS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete_YDS.Image = ((System.Drawing.Image)(resources.GetObject("buttonDelete_YDS.Image")));
            this.buttonDelete_YDS.Location = new System.Drawing.Point(1239, 12);
            this.buttonDelete_YDS.Name = "buttonDelete_YDS";
            this.buttonDelete_YDS.Size = new System.Drawing.Size(75, 70);
            this.buttonDelete_YDS.TabIndex = 4;
            this.toolTipHelp_YDS.SetToolTip(this.buttonDelete_YDS, "Удалить файл\r\nНажмите, чтобы удалить файл с приложения.");
            this.buttonDelete_YDS.UseVisualStyleBackColor = true;
            this.buttonDelete_YDS.Click += new System.EventHandler(this.buttonDelete_YDS_Click);
            // 
            // buttonOpenFile_YDS
            // 
            this.buttonOpenFile_YDS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpenFile_YDS.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_YDS.Image")));
            this.buttonOpenFile_YDS.Location = new System.Drawing.Point(1045, 12);
            this.buttonOpenFile_YDS.Name = "buttonOpenFile_YDS";
            this.buttonOpenFile_YDS.Size = new System.Drawing.Size(78, 70);
            this.buttonOpenFile_YDS.TabIndex = 3;
            this.toolTipHelp_YDS.SetToolTip(this.buttonOpenFile_YDS, "Открыть файл\r\nНажмите, чтобы выбрать и открыть нужный файл \r\nдля редактирования.");
            this.buttonOpenFile_YDS.UseVisualStyleBackColor = true;
            this.buttonOpenFile_YDS.Click += new System.EventHandler(this.buttonOpenFile_YDS_Click);
            // 
            // buttonHelp_YDS
            // 
            this.buttonHelp_YDS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_YDS.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp_YDS.Image")));
            this.buttonHelp_YDS.Location = new System.Drawing.Point(1331, 12);
            this.buttonHelp_YDS.Name = "buttonHelp_YDS";
            this.buttonHelp_YDS.Size = new System.Drawing.Size(75, 71);
            this.buttonHelp_YDS.TabIndex = 1;
            this.toolTipHelp_YDS.SetToolTip(this.buttonHelp_YDS, "Руководство\r\nНажмите, чтобы получить информацию о программе.");
            this.buttonHelp_YDS.UseVisualStyleBackColor = true;
            this.buttonHelp_YDS.Click += new System.EventHandler(this.buttonHelp_YDS_Click);
            // 
            // LabelTiitle_YDS
            // 
            this.LabelTiitle_YDS.AutoSize = true;
            this.LabelTiitle_YDS.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelTiitle_YDS.Location = new System.Drawing.Point(12, 21);
            this.LabelTiitle_YDS.Name = "LabelTiitle_YDS";
            this.LabelTiitle_YDS.Size = new System.Drawing.Size(633, 54);
            this.LabelTiitle_YDS.TabIndex = 0;
            this.LabelTiitle_YDS.Text = "Авторемонтная мастерская";
            // 
            // panelDataBase_YDS
            // 
            this.panelDataBase_YDS.BackColor = System.Drawing.Color.White;
            this.panelDataBase_YDS.Controls.Add(this.groupBoxDataBase_YDS);
            this.panelDataBase_YDS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDataBase_YDS.Location = new System.Drawing.Point(0, 100);
            this.panelDataBase_YDS.Name = "panelDataBase_YDS";
            this.panelDataBase_YDS.Size = new System.Drawing.Size(1218, 617);
            this.panelDataBase_YDS.TabIndex = 1;
            this.panelDataBase_YDS.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDataBase_YDS_Paint);
            // 
            // groupBoxDataBase_YDS
            // 
            this.groupBoxDataBase_YDS.Controls.Add(this.dataGridViewDataBase_YDS);
            this.groupBoxDataBase_YDS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDataBase_YDS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxDataBase_YDS.Location = new System.Drawing.Point(0, 0);
            this.groupBoxDataBase_YDS.Name = "groupBoxDataBase_YDS";
            this.groupBoxDataBase_YDS.Size = new System.Drawing.Size(1218, 617);
            this.groupBoxDataBase_YDS.TabIndex = 0;
            this.groupBoxDataBase_YDS.TabStop = false;
            this.groupBoxDataBase_YDS.Text = "База данных:";
            // 
            // panelSort_YDS
            // 
            this.panelSort_YDS.BackColor = System.Drawing.Color.White;
            this.panelSort_YDS.Controls.Add(this.groupBoxSort_YDS);
            this.panelSort_YDS.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelSort_YDS.Location = new System.Drawing.Point(1218, 100);
            this.panelSort_YDS.Name = "panelSort_YDS";
            this.panelSort_YDS.Size = new System.Drawing.Size(200, 617);
            this.panelSort_YDS.TabIndex = 2;
            // 
            // groupBoxSort_YDS
            // 
            this.groupBoxSort_YDS.Controls.Add(this.buttonStopSearch_YDS);
            this.groupBoxSort_YDS.Controls.Add(this.textBoxSearch_YDS);
            this.groupBoxSort_YDS.Controls.Add(this.labelSeatch_YDS);
            this.groupBoxSort_YDS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxSort_YDS.Location = new System.Drawing.Point(0, 0);
            this.groupBoxSort_YDS.Name = "groupBoxSort_YDS";
            this.groupBoxSort_YDS.Size = new System.Drawing.Size(200, 617);
            this.groupBoxSort_YDS.TabIndex = 0;
            this.groupBoxSort_YDS.TabStop = false;
            this.groupBoxSort_YDS.Text = "Изменение и сортировка данных";
            // 
            // labelSeatch_YDS
            // 
            this.labelSeatch_YDS.AutoSize = true;
            this.labelSeatch_YDS.Location = new System.Drawing.Point(6, 44);
            this.labelSeatch_YDS.Name = "labelSeatch_YDS";
            this.labelSeatch_YDS.Size = new System.Drawing.Size(50, 16);
            this.labelSeatch_YDS.TabIndex = 1;
            this.labelSeatch_YDS.Text = "Поиск:";
            // 
            // openFileDialog_YDS
            // 
            this.openFileDialog_YDS.FileName = "openFileDialog1";
            // 
            // buttonSaveFile_YDS
            // 
            this.buttonSaveFile_YDS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveFile_YDS.Image = ((System.Drawing.Image)(resources.GetObject("buttonSaveFile_YDS.Image")));
            this.buttonSaveFile_YDS.Location = new System.Drawing.Point(1140, 12);
            this.buttonSaveFile_YDS.Name = "buttonSaveFile_YDS";
            this.buttonSaveFile_YDS.Size = new System.Drawing.Size(78, 71);
            this.buttonSaveFile_YDS.TabIndex = 2;
            this.toolTipHelp_YDS.SetToolTip(this.buttonSaveFile_YDS, "Сохранить файл\r\nНажмите, чтобы сохранить файл.");
            this.buttonSaveFile_YDS.UseVisualStyleBackColor = true;
            this.buttonSaveFile_YDS.Click += new System.EventHandler(this.buttonSaveFile_YDS_Click);
            // 
            // dataGridViewDataBase_YDS
            // 
            this.dataGridViewDataBase_YDS.AllowUserToDeleteRows = false;
            this.dataGridViewDataBase_YDS.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewDataBase_YDS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDataBase_YDS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDataBase_YDS.Location = new System.Drawing.Point(3, 24);
            this.dataGridViewDataBase_YDS.Name = "dataGridViewDataBase_YDS";
            this.dataGridViewDataBase_YDS.RowHeadersVisible = false;
            this.dataGridViewDataBase_YDS.RowHeadersWidth = 51;
            this.dataGridViewDataBase_YDS.RowTemplate.Height = 24;
            this.dataGridViewDataBase_YDS.Size = new System.Drawing.Size(1212, 590);
            this.dataGridViewDataBase_YDS.TabIndex = 0;
            this.dataGridViewDataBase_YDS.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridViewDataBase_YDS_CellValidating);
            this.dataGridViewDataBase_YDS.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewDataBase_YDS_DataBindingComplete);
            this.dataGridViewDataBase_YDS.SelectionChanged += new System.EventHandler(this.dataGridViewDataBase_YDS_SelectionChanged);
            this.dataGridViewDataBase_YDS.SortCompare += new System.Windows.Forms.DataGridViewSortCompareEventHandler(this.dataGridViewDataBase_YDS_SortCompare);
            // 
            // textBoxSearch_YDS
            // 
            this.textBoxSearch_YDS.Location = new System.Drawing.Point(7, 64);
            this.textBoxSearch_YDS.Name = "textBoxSearch_YDS";
            this.textBoxSearch_YDS.Size = new System.Drawing.Size(181, 22);
            this.textBoxSearch_YDS.TabIndex = 11;
            this.textBoxSearch_YDS.TextChanged += new System.EventHandler(this.textBoxSearch_YDS_TextChanged);
            // 
            // buttonStopSearch_YDS
            // 
            this.buttonStopSearch_YDS.Location = new System.Drawing.Point(7, 93);
            this.buttonStopSearch_YDS.Name = "buttonStopSearch_YDS";
            this.buttonStopSearch_YDS.Size = new System.Drawing.Size(181, 35);
            this.buttonStopSearch_YDS.TabIndex = 12;
            this.buttonStopSearch_YDS.Text = "Прекратить поиск";
            this.buttonStopSearch_YDS.UseVisualStyleBackColor = true;
            this.buttonStopSearch_YDS.Click += new System.EventHandler(this.buttonStopSearch_YDS_Click);
            // 
            // buttonCancelChanges_YDS
            // 
            this.buttonCancelChanges_YDS.Image = ((System.Drawing.Image)(resources.GetObject("buttonCancelChanges_YDS.Image")));
            this.buttonCancelChanges_YDS.Location = new System.Drawing.Point(953, 12);
            this.buttonCancelChanges_YDS.Name = "buttonCancelChanges_YDS";
            this.buttonCancelChanges_YDS.Size = new System.Drawing.Size(77, 71);
            this.buttonCancelChanges_YDS.TabIndex = 5;
            this.toolTipHelp_YDS.SetToolTip(this.buttonCancelChanges_YDS, "Отменить изменения\r\nНажмите, чтобы отменить изменения в таблице.");
            this.buttonCancelChanges_YDS.UseVisualStyleBackColor = true;
            this.buttonCancelChanges_YDS.Click += new System.EventHandler(this.buttonCancelChanges_YDS_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 717);
            this.Controls.Add(this.panelDataBase_YDS);
            this.Controls.Add(this.panelSort_YDS);
            this.Controls.Add(this.panelButtons_YDS);
            this.MinimumSize = new System.Drawing.Size(1436, 764);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спритн 7 | Project | Вариант 1 | Янголенко Д. С.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelButtons_YDS.ResumeLayout(false);
            this.panelButtons_YDS.PerformLayout();
            this.panelDataBase_YDS.ResumeLayout(false);
            this.groupBoxDataBase_YDS.ResumeLayout(false);
            this.panelSort_YDS.ResumeLayout(false);
            this.groupBoxSort_YDS.ResumeLayout(false);
            this.groupBoxSort_YDS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataBase_YDS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelButtons_YDS;
        private System.Windows.Forms.Panel panelDataBase_YDS;
        private System.Windows.Forms.Panel panelSort_YDS;
        private System.Windows.Forms.Label LabelTiitle_YDS;
        private System.Windows.Forms.Button buttonHelp_YDS;
        private System.Windows.Forms.ToolTip toolTipHelp_YDS;
        private System.Windows.Forms.OpenFileDialog openFileDialog_YDS;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_YDS;
        private System.Windows.Forms.Button buttonOpenFile_YDS;
        private System.Windows.Forms.Button buttonDelete_YDS;
        private System.Windows.Forms.GroupBox groupBoxSort_YDS;
        private System.Windows.Forms.GroupBox groupBoxDataBase_YDS;
        private System.Windows.Forms.Label labelSeatch_YDS;
        private System.Windows.Forms.Button buttonSaveFile_YDS;
        private System.Windows.Forms.DataGridView dataGridViewDataBase_YDS;
        private System.Windows.Forms.TextBox textBoxSearch_YDS;
        private System.Windows.Forms.Button buttonStopSearch_YDS;
        private System.Windows.Forms.Button buttonCancelChanges_YDS;
    }
}

