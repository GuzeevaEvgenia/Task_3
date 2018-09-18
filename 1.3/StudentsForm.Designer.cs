namespace _1._3
{
    partial class StudentsForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.DGV = new System.Windows.Forms.DataGridView();
            this.index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpnBtn = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.AvgBtn = new System.Windows.Forms.Button();
            this.InputN = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputN)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AllowUserToDeleteRows = false;
            this.DGV.AllowUserToResizeColumns = false;
            this.DGV.AllowUserToResizeRows = false;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.index,
            this.NAme});
            this.DGV.Location = new System.Drawing.Point(9, 88);
            this.DGV.Margin = new System.Windows.Forms.Padding(2);
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            this.DGV.RowHeadersVisible = false;
            this.DGV.RowTemplate.Height = 24;
            this.DGV.Size = new System.Drawing.Size(380, 447);
            this.DGV.TabIndex = 0;
            this.DGV.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DGV_MouseDoubleClick);
            // 
            // index
            // 
            this.index.Frozen = true;
            this.index.HeaderText = "#";
            this.index.Name = "index";
            this.index.ReadOnly = true;
            this.index.Width = 30;
            // 
            // NAme
            // 
            this.NAme.Frozen = true;
            this.NAme.HeaderText = "FIO";
            this.NAme.Name = "NAme";
            this.NAme.ReadOnly = true;
            this.NAme.Width = 480;
            // 
            // OpnBtn
            // 
            this.OpnBtn.Location = new System.Drawing.Point(9, 10);
            this.OpnBtn.Margin = new System.Windows.Forms.Padding(2);
            this.OpnBtn.Name = "OpnBtn";
            this.OpnBtn.Size = new System.Drawing.Size(74, 35);
            this.OpnBtn.TabIndex = 1;
            this.OpnBtn.Text = "открыть ";
            this.OpnBtn.UseVisualStyleBackColor = true;
            this.OpnBtn.Click += new System.EventHandler(this.OpnBtn_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "Файл данных (*.dat)|*.dat|Все файлы|*.*";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Файл данных (*.dat)|*.dat|Все файлы|*.*";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(9, 49);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(2);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(74, 35);
            this.SaveBtn.TabIndex = 2;
            this.SaveBtn.Text = "сохранить";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Location = new System.Drawing.Point(87, 49);
            this.RemoveBtn.Margin = new System.Windows.Forms.Padding(2);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(74, 35);
            this.RemoveBtn.TabIndex = 4;
            this.RemoveBtn.Text = "удалить";
            this.RemoveBtn.UseVisualStyleBackColor = true;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(87, 10);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(74, 35);
            this.AddBtn.TabIndex = 3;
            this.AddBtn.Text = "добавить";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // AvgBtn
            // 
            this.AvgBtn.Location = new System.Drawing.Point(169, 49);
            this.AvgBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AvgBtn.Name = "AvgBtn";
            this.AvgBtn.Size = new System.Drawing.Size(111, 35);
            this.AvgBtn.TabIndex = 5;
            this.AvgBtn.Text = "N самых молодых";
            this.AvgBtn.UseVisualStyleBackColor = true;
            this.AvgBtn.Click += new System.EventHandler(this.AvgBtn_Click);
            // 
            // InputN
            // 
            this.InputN.Location = new System.Drawing.Point(196, 19);
            this.InputN.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.InputN.Name = "InputN";
            this.InputN.Size = new System.Drawing.Size(84, 20);
            this.InputN.TabIndex = 6;
            this.InputN.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "N =";
            // 
            // StudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 546);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InputN);
            this.Controls.Add(this.AvgBtn);
            this.Controls.Add(this.RemoveBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.OpnBtn);
            this.Controls.Add(this.DGV);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StudentsForm";
            this.Text = "StudentsForm";
            this.Load += new System.EventHandler(this.StudentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Button OpnBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button RemoveBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn index;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAme;
        private System.Windows.Forms.Button AvgBtn;
        private System.Windows.Forms.NumericUpDown InputN;
        private System.Windows.Forms.Label label1;
    }
}

