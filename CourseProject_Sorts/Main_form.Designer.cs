namespace CourseProject_Sorts
{
    partial class Main_form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.lookTable2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown_percent = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_size = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton_o = new System.Windows.Forms.RadioButton();
            this.radioButton_ro = new System.Windows.Forms.RadioButton();
            this.radioButton_po = new System.Windows.Forms.RadioButton();
            this.radioButton_no = new System.Windows.Forms.RadioButton();
            this.sort_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.sortingDataTable = new System.Windows.Forms.DataGridView();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direct_ch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direct_in = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direct_mm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.lookTable1 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_percent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_size)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sortingDataTable)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.ItemSize = new System.Drawing.Size(70, 25);
            this.tabControl1.Location = new System.Drawing.Point(2, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(15, 3);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1056, 615);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.SeaShell;
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1048, 582);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Главная";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.lookTable2);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(540, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(492, 490);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Результат";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.SeaShell;
            this.button4.Location = new System.Drawing.Point(97, 260);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(298, 35);
            this.button4.TabIndex = 9;
            this.button4.Text = "Посмотреть график";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // lookTable2
            // 
            this.lookTable2.BackColor = System.Drawing.Color.SeaShell;
            this.lookTable2.Location = new System.Drawing.Point(97, 196);
            this.lookTable2.Name = "lookTable2";
            this.lookTable2.Size = new System.Drawing.Size(298, 35);
            this.lookTable2.TabIndex = 10;
            this.lookTable2.Text = "Посмотреть таблицу";
            this.lookTable2.UseVisualStyleBackColor = false;
            this.lookTable2.Click += new System.EventHandler(this.OpenTable);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numericUpDown_percent);
            this.groupBox1.Controls.Add(this.numericUpDown_size);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.radioButton_o);
            this.groupBox1.Controls.Add(this.radioButton_ro);
            this.groupBox1.Controls.Add(this.radioButton_po);
            this.groupBox1.Controls.Add(this.radioButton_no);
            this.groupBox1.Controls.Add(this.sort_btn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(17, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(492, 490);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ввод данных";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(68, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 19);
            this.label3.TabIndex = 20;
            this.label3.Text = "Процент упорядоченности:";
            // 
            // numericUpDown_percent
            // 
            this.numericUpDown_percent.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown_percent.Location = new System.Drawing.Point(302, 287);
            this.numericUpDown_percent.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_percent.Name = "numericUpDown_percent";
            this.numericUpDown_percent.Size = new System.Drawing.Size(120, 30);
            this.numericUpDown_percent.TabIndex = 19;
            this.numericUpDown_percent.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown_percent.DoubleClick += new System.EventHandler(this.numericUpDown_percent_DoubleClick);
            // 
            // numericUpDown_size
            // 
            this.numericUpDown_size.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown_size.Location = new System.Drawing.Point(370, 41);
            this.numericUpDown_size.Maximum = new decimal(new int[] {
            30000,
            0,
            0,
            0});
            this.numericUpDown_size.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_size.Name = "numericUpDown_size";
            this.numericUpDown_size.Size = new System.Drawing.Size(107, 30);
            this.numericUpDown_size.TabIndex = 18;
            this.numericUpDown_size.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_size.DoubleClick += new System.EventHandler(this.numericUpDown_size_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 45);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(358, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Укажите размер массива (от 10_000 до 30_000):";
            // 
            // radioButton_o
            // 
            this.radioButton_o.AutoSize = true;
            this.radioButton_o.Checked = true;
            this.radioButton_o.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_o.Location = new System.Drawing.Point(47, 146);
            this.radioButton_o.Name = "radioButton_o";
            this.radioButton_o.Size = new System.Drawing.Size(144, 23);
            this.radioButton_o.TabIndex = 2;
            this.radioButton_o.TabStop = true;
            this.radioButton_o.Text = "Упорядоченный";
            this.radioButton_o.UseVisualStyleBackColor = true;
            // 
            // radioButton_ro
            // 
            this.radioButton_ro.AutoSize = true;
            this.radioButton_ro.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_ro.Location = new System.Drawing.Point(47, 198);
            this.radioButton_ro.Name = "radioButton_ro";
            this.radioButton_ro.Size = new System.Drawing.Size(290, 23);
            this.radioButton_ro.TabIndex = 3;
            this.radioButton_ro.Text = "Упорядоченный в обратном порядке";
            this.radioButton_ro.UseVisualStyleBackColor = true;
            // 
            // radioButton_po
            // 
            this.radioButton_po.AutoSize = true;
            this.radioButton_po.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_po.Location = new System.Drawing.Point(47, 254);
            this.radioButton_po.Name = "radioButton_po";
            this.radioButton_po.Size = new System.Drawing.Size(212, 23);
            this.radioButton_po.TabIndex = 4;
            this.radioButton_po.Text = "Частично упорядоченный";
            this.radioButton_po.UseVisualStyleBackColor = true;
            // 
            // radioButton_no
            // 
            this.radioButton_no.AutoSize = true;
            this.radioButton_no.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_no.Location = new System.Drawing.Point(47, 350);
            this.radioButton_no.Name = "radioButton_no";
            this.radioButton_no.Size = new System.Drawing.Size(161, 23);
            this.radioButton_no.TabIndex = 5;
            this.radioButton_no.Text = "Неупорядоченный";
            this.radioButton_no.UseVisualStyleBackColor = true;
            // 
            // sort_btn
            // 
            this.sort_btn.BackColor = System.Drawing.Color.SeaShell;
            this.sort_btn.Location = new System.Drawing.Point(97, 413);
            this.sort_btn.Name = "sort_btn";
            this.sort_btn.Size = new System.Drawing.Size(298, 35);
            this.sort_btn.TabIndex = 6;
            this.sort_btn.Text = "Отсортировать";
            this.sort_btn.UseVisualStyleBackColor = false;
            this.sort_btn.Click += new System.EventHandler(this.sort_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(16, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Вид массива:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MistyRose;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(375, 526);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(298, 35);
            this.button2.TabIndex = 7;
            this.button2.Text = "Выйти";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.sortingDataTable);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1048, 582);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Таблица";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // sortingDataTable
            // 
            this.sortingDataTable.AllowUserToAddRows = false;
            this.sortingDataTable.AllowUserToDeleteRows = false;
            this.sortingDataTable.AllowUserToResizeColumns = false;
            this.sortingDataTable.AllowUserToResizeRows = false;
            this.sortingDataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sortingDataTable.BackgroundColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sortingDataTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.sortingDataTable.ColumnHeadersHeight = 74;
            this.sortingDataTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.type,
            this.size,
            this.direct_ch,
            this.direct_in,
            this.direct_mm});
            this.sortingDataTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sortingDataTable.EnableHeadersVisualStyles = false;
            this.sortingDataTable.Location = new System.Drawing.Point(3, 3);
            this.sortingDataTable.Margin = new System.Windows.Forms.Padding(4);
            this.sortingDataTable.Name = "sortingDataTable";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sortingDataTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.sortingDataTable.RowHeadersVisible = false;
            this.sortingDataTable.RowHeadersWidth = 51;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.sortingDataTable.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.sortingDataTable.RowTemplate.Height = 3;
            this.sortingDataTable.RowTemplate.ReadOnly = true;
            this.sortingDataTable.Size = new System.Drawing.Size(1042, 576);
            this.sortingDataTable.TabIndex = 1;
            // 
            // type
            // 
            this.type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.type.DefaultCellStyle = dataGridViewCellStyle2;
            this.type.HeaderText = "Вид массива";
            this.type.MinimumWidth = 6;
            this.type.Name = "type";
            this.type.ReadOnly = true;
            this.type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // size
            // 
            this.size.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.size.DefaultCellStyle = dataGridViewCellStyle3;
            this.size.HeaderText = "Размер";
            this.size.MinimumWidth = 6;
            this.size.Name = "size";
            this.size.ReadOnly = true;
            this.size.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // direct_ch
            // 
            this.direct_ch.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.direct_ch.DefaultCellStyle = dataGridViewCellStyle4;
            this.direct_ch.HeaderText = "Время прямым выбором";
            this.direct_ch.MinimumWidth = 6;
            this.direct_ch.Name = "direct_ch";
            this.direct_ch.ReadOnly = true;
            this.direct_ch.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // direct_in
            // 
            this.direct_in.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.direct_in.DefaultCellStyle = dataGridViewCellStyle5;
            this.direct_in.HeaderText = "Время прямым включением";
            this.direct_in.MinimumWidth = 6;
            this.direct_in.Name = "direct_in";
            this.direct_in.ReadOnly = true;
            this.direct_in.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // direct_mm
            // 
            this.direct_mm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.direct_mm.DefaultCellStyle = dataGridViewCellStyle6;
            this.direct_mm.FillWeight = 150F;
            this.direct_mm.HeaderText = "Время прямым выбором с запоминанием минимума и максимума";
            this.direct_mm.MinimumWidth = 6;
            this.direct_mm.Name = "direct_mm";
            this.direct_mm.ReadOnly = true;
            this.direct_mm.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.direct_mm.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.lookTable1);
            this.tabPage3.Controls.Add(this.chart1);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1048, 582);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Графики";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightYellow;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(721, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(298, 35);
            this.button1.TabIndex = 12;
            this.button1.Text = "Главная";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lookTable1
            // 
            this.lookTable1.BackColor = System.Drawing.Color.LightYellow;
            this.lookTable1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lookTable1.Location = new System.Drawing.Point(721, 216);
            this.lookTable1.Name = "lookTable1";
            this.lookTable1.Size = new System.Drawing.Size(298, 35);
            this.lookTable1.TabIndex = 11;
            this.lookTable1.Text = "Посмотреть таблицу";
            this.lookTable1.UseVisualStyleBackColor = false;
            this.lookTable1.Click += new System.EventHandler(this.OpenTable);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.SeaShell;
            chartArea1.AxisX.Title = "Размерность массива";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.IndianRed;
            chartArea1.AxisY.Title = "Время (тики)";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea1.AxisY.TitleForeColor = System.Drawing.Color.IndianRed;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Bottom;
            legend1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            legend1.IsTextAutoFit = false;
            legend1.MaximumAutoSize = 60F;
            legend1.Name = "legend";
            legend1.Title = "Сортировки";
            legend1.TitleFont = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            legend1.TitleSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.DotLine;
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 3);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series1.LabelBorderWidth = 3;
            series1.Legend = "legend";
            series1.Name = "Прямым выбором";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.LabelBorderWidth = 3;
            series2.Legend = "legend";
            series2.Name = "Прямым включением";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series3.LabelBorderWidth = 3;
            series3.Legend = "legend";
            series3.Name = "Прямым выбором с запоминанием максимума и минимума";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(1042, 579);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            title1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title1.ForeColor = System.Drawing.Color.IndianRed;
            title1.Name = "main";
            title1.Text = "График зависимости времени сортировок от размера массива";
            this.chart1.Titles.Add(title1);
            // 
            // Main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1061, 620);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Main_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сравнение сортировок прямого выбора";
            this.Load += new System.EventHandler(this.Main_form_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_percent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_size)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sortingDataTable)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RadioButton radioButton_no;
        private System.Windows.Forms.RadioButton radioButton_po;
        private System.Windows.Forms.RadioButton radioButton_ro;
        private System.Windows.Forms.RadioButton radioButton_o;
        private System.Windows.Forms.Button lookTable2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button sort_btn;
        private System.Windows.Forms.NumericUpDown numericUpDown_size;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView sortingDataTable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown_percent;
        private System.Windows.Forms.Button lookTable1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn size;
        private System.Windows.Forms.DataGridViewTextBoxColumn direct_ch;
        private System.Windows.Forms.DataGridViewTextBoxColumn direct_in;
        private System.Windows.Forms.DataGridViewTextBoxColumn direct_mm;
    }
}

