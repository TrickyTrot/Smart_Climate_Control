namespace GuiWinForms
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ConnectionPanel = new System.Windows.Forms.Panel();
            this.PortChek1 = new System.Windows.Forms.Label();
            this.PortLabel = new System.Windows.Forms.Label();
            this.DisconnectionButton = new System.Windows.Forms.Button();
            this.PortText = new System.Windows.Forms.TextBox();
            this.ConnectionButton = new System.Windows.Forms.Button();
            this.SetPanel = new System.Windows.Forms.Panel();
            this.ClearChart = new System.Windows.Forms.Button();
            this.TemperaturePlusMax = new System.Windows.Forms.Button();
            this.TemperatureMinusMax = new System.Windows.Forms.Button();
            this.Change = new System.Windows.Forms.Label();
            this.Switch = new System.Windows.Forms.Button();
            this.LightPlus = new System.Windows.Forms.Button();
            this.LightMinus = new System.Windows.Forms.Button();
            this.HumidityPlus = new System.Windows.Forms.Button();
            this.HumidityMinus = new System.Windows.Forms.Button();
            this.TemperaturePlus = new System.Windows.Forms.Button();
            this.TemperatureMinus = new System.Windows.Forms.Button();
            this.Light = new System.Windows.Forms.Label();
            this.Humidity = new System.Windows.Forms.Label();
            this.Temperature = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.humSet = new System.Windows.Forms.Label();
            this.Izmlabel = new System.Windows.Forms.Label();
            this.ligSet = new System.Windows.Forms.Label();
            this.Minlabel = new System.Windows.Forms.Label();
            this.Maxlabel = new System.Windows.Forms.Label();
            this.ligIzm = new System.Windows.Forms.Label();
            this.liglabel = new System.Windows.Forms.Label();
            this.humIzm = new System.Windows.Forms.Label();
            this.humlabel = new System.Windows.Forms.Label();
            this.temMax = new System.Windows.Forms.Label();
            this.temMin = new System.Windows.Forms.Label();
            this.temIzm = new System.Windows.Forms.Label();
            this.temlabel = new System.Windows.Forms.Label();
            this.IndicationsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ConnectionPanel.SuspendLayout();
            this.SetPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IndicationsChart)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConnectionPanel
            // 
            this.ConnectionPanel.Controls.Add(this.PortChek1);
            this.ConnectionPanel.Controls.Add(this.PortLabel);
            this.ConnectionPanel.Controls.Add(this.DisconnectionButton);
            this.ConnectionPanel.Controls.Add(this.PortText);
            this.ConnectionPanel.Controls.Add(this.ConnectionButton);
            this.ConnectionPanel.Location = new System.Drawing.Point(13, 21);
            this.ConnectionPanel.Name = "ConnectionPanel";
            this.ConnectionPanel.Size = new System.Drawing.Size(141, 198);
            this.ConnectionPanel.TabIndex = 0;
            // 
            // PortChek1
            // 
            this.PortChek1.AutoSize = true;
            this.PortChek1.ForeColor = System.Drawing.Color.Red;
            this.PortChek1.Location = new System.Drawing.Point(3, 53);
            this.PortChek1.Name = "PortChek1";
            this.PortChek1.Size = new System.Drawing.Size(83, 13);
            this.PortChek1.TabIndex = 5;
            this.PortChek1.Text = "Порт: ЗАКРЫТ";
            // 
            // PortLabel
            // 
            this.PortLabel.AutoSize = true;
            this.PortLabel.Location = new System.Drawing.Point(25, 10);
            this.PortLabel.Name = "PortLabel";
            this.PortLabel.Size = new System.Drawing.Size(78, 13);
            this.PortLabel.TabIndex = 4;
            this.PortLabel.Text = "Введите порт:";
            // 
            // DisconnectionButton
            // 
            this.DisconnectionButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DisconnectionButton.Location = new System.Drawing.Point(3, 126);
            this.DisconnectionButton.Name = "DisconnectionButton";
            this.DisconnectionButton.Size = new System.Drawing.Size(130, 50);
            this.DisconnectionButton.TabIndex = 2;
            this.DisconnectionButton.Text = "Отключиться";
            this.DisconnectionButton.UseVisualStyleBackColor = true;
            this.DisconnectionButton.Click += new System.EventHandler(this.DisconnectionButton_Click);
            // 
            // PortText
            // 
            this.PortText.Location = new System.Drawing.Point(3, 26);
            this.PortText.Name = "PortText";
            this.PortText.Size = new System.Drawing.Size(130, 20);
            this.PortText.TabIndex = 3;
            this.PortText.TextChanged += new System.EventHandler(this.PortText_TextChanged);
            // 
            // ConnectionButton
            // 
            this.ConnectionButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConnectionButton.Location = new System.Drawing.Point(3, 69);
            this.ConnectionButton.Name = "ConnectionButton";
            this.ConnectionButton.Size = new System.Drawing.Size(130, 50);
            this.ConnectionButton.TabIndex = 1;
            this.ConnectionButton.Text = "Подключиться";
            this.ConnectionButton.UseVisualStyleBackColor = true;
            this.ConnectionButton.Click += new System.EventHandler(this.ConnectionButten_Click);
            // 
            // SetPanel
            // 
            this.SetPanel.Controls.Add(this.ClearChart);
            this.SetPanel.Controls.Add(this.TemperaturePlusMax);
            this.SetPanel.Controls.Add(this.TemperatureMinusMax);
            this.SetPanel.Controls.Add(this.Change);
            this.SetPanel.Controls.Add(this.Switch);
            this.SetPanel.Controls.Add(this.LightPlus);
            this.SetPanel.Controls.Add(this.LightMinus);
            this.SetPanel.Controls.Add(this.HumidityPlus);
            this.SetPanel.Controls.Add(this.HumidityMinus);
            this.SetPanel.Controls.Add(this.TemperaturePlus);
            this.SetPanel.Controls.Add(this.TemperatureMinus);
            this.SetPanel.Controls.Add(this.Light);
            this.SetPanel.Controls.Add(this.Humidity);
            this.SetPanel.Controls.Add(this.Temperature);
            this.SetPanel.Location = new System.Drawing.Point(558, 247);
            this.SetPanel.Name = "SetPanel";
            this.SetPanel.Size = new System.Drawing.Size(200, 100);
            this.SetPanel.TabIndex = 1;
            // 
            // ClearChart
            // 
            this.ClearChart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearChart.Location = new System.Drawing.Point(107, 74);
            this.ClearChart.Name = "ClearChart";
            this.ClearChart.Size = new System.Drawing.Size(90, 23);
            this.ClearChart.TabIndex = 10;
            this.ClearChart.Text = "Отчистить";
            this.ClearChart.UseVisualStyleBackColor = true;
            this.ClearChart.Click += new System.EventHandler(this.ClearChart_Click);
            // 
            // TemperaturePlusMax
            // 
            this.TemperaturePlusMax.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.TemperaturePlusMax.Location = new System.Drawing.Point(151, 10);
            this.TemperaturePlusMax.Name = "TemperaturePlusMax";
            this.TemperaturePlusMax.Size = new System.Drawing.Size(30, 20);
            this.TemperaturePlusMax.TabIndex = 6;
            this.TemperaturePlusMax.Text = "+";
            this.TemperaturePlusMax.UseVisualStyleBackColor = true;
            this.TemperaturePlusMax.Click += new System.EventHandler(this.TemperaturePlusMax_Click);
            // 
            // TemperatureMinusMax
            // 
            this.TemperatureMinusMax.Cursor = System.Windows.Forms.Cursors.PanSouth;
            this.TemperatureMinusMax.Location = new System.Drawing.Point(115, 10);
            this.TemperatureMinusMax.Name = "TemperatureMinusMax";
            this.TemperatureMinusMax.Size = new System.Drawing.Size(30, 20);
            this.TemperatureMinusMax.TabIndex = 5;
            this.TemperatureMinusMax.Text = "-";
            this.TemperatureMinusMax.UseVisualStyleBackColor = true;
            this.TemperatureMinusMax.Click += new System.EventHandler(this.TemperatureMinusMax_Click);
            // 
            // Change
            // 
            this.Change.AutoSize = true;
            this.Change.Location = new System.Drawing.Point(131, 33);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(45, 13);
            this.Change.TabIndex = 2;
            this.Change.Text = "График";
            // 
            // Switch
            // 
            this.Switch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Switch.Location = new System.Drawing.Point(107, 49);
            this.Switch.Name = "Switch";
            this.Switch.Size = new System.Drawing.Size(90, 23);
            this.Switch.TabIndex = 9;
            this.Switch.Text = "Создать";
            this.Switch.UseVisualStyleBackColor = true;
            this.Switch.Click += new System.EventHandler(this.Switch_Click);
            // 
            // LightPlus
            // 
            this.LightPlus.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.LightPlus.Location = new System.Drawing.Point(70, 69);
            this.LightPlus.Name = "LightPlus";
            this.LightPlus.Size = new System.Drawing.Size(30, 20);
            this.LightPlus.TabIndex = 8;
            this.LightPlus.Text = "+";
            this.LightPlus.UseVisualStyleBackColor = true;
            this.LightPlus.Click += new System.EventHandler(this.LightPlus_Click);
            // 
            // LightMinus
            // 
            this.LightMinus.Cursor = System.Windows.Forms.Cursors.PanSouth;
            this.LightMinus.Location = new System.Drawing.Point(34, 69);
            this.LightMinus.Name = "LightMinus";
            this.LightMinus.Size = new System.Drawing.Size(30, 20);
            this.LightMinus.TabIndex = 7;
            this.LightMinus.Text = "-";
            this.LightMinus.UseVisualStyleBackColor = true;
            this.LightMinus.Click += new System.EventHandler(this.LightMinus_Click);
            // 
            // HumidityPlus
            // 
            this.HumidityPlus.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.HumidityPlus.Location = new System.Drawing.Point(70, 40);
            this.HumidityPlus.Name = "HumidityPlus";
            this.HumidityPlus.Size = new System.Drawing.Size(30, 20);
            this.HumidityPlus.TabIndex = 6;
            this.HumidityPlus.Text = "+";
            this.HumidityPlus.UseVisualStyleBackColor = true;
            this.HumidityPlus.Click += new System.EventHandler(this.HumidityPlus_Click);
            // 
            // HumidityMinus
            // 
            this.HumidityMinus.Cursor = System.Windows.Forms.Cursors.PanSouth;
            this.HumidityMinus.Location = new System.Drawing.Point(34, 40);
            this.HumidityMinus.Name = "HumidityMinus";
            this.HumidityMinus.Size = new System.Drawing.Size(30, 20);
            this.HumidityMinus.TabIndex = 5;
            this.HumidityMinus.Text = "-";
            this.HumidityMinus.UseVisualStyleBackColor = true;
            this.HumidityMinus.Click += new System.EventHandler(this.HumidityMinus_Click);
            // 
            // TemperaturePlus
            // 
            this.TemperaturePlus.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.TemperaturePlus.Location = new System.Drawing.Point(70, 10);
            this.TemperaturePlus.Name = "TemperaturePlus";
            this.TemperaturePlus.Size = new System.Drawing.Size(30, 20);
            this.TemperaturePlus.TabIndex = 4;
            this.TemperaturePlus.Text = "+";
            this.TemperaturePlus.UseVisualStyleBackColor = true;
            this.TemperaturePlus.Click += new System.EventHandler(this.TemperaturePlus_Click);
            // 
            // TemperatureMinus
            // 
            this.TemperatureMinus.Cursor = System.Windows.Forms.Cursors.PanSouth;
            this.TemperatureMinus.Location = new System.Drawing.Point(34, 10);
            this.TemperatureMinus.Name = "TemperatureMinus";
            this.TemperatureMinus.Size = new System.Drawing.Size(30, 20);
            this.TemperatureMinus.TabIndex = 3;
            this.TemperatureMinus.Text = "-";
            this.TemperatureMinus.UseVisualStyleBackColor = true;
            this.TemperatureMinus.Click += new System.EventHandler(this.TemperatureMinus_Click);
            // 
            // Light
            // 
            this.Light.AutoSize = true;
            this.Light.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Light.Location = new System.Drawing.Point(3, 69);
            this.Light.Name = "Light";
            this.Light.Size = new System.Drawing.Size(18, 20);
            this.Light.TabIndex = 2;
            this.Light.Text = "L";
            // 
            // Humidity
            // 
            this.Humidity.AutoSize = true;
            this.Humidity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Humidity.Location = new System.Drawing.Point(3, 39);
            this.Humidity.Name = "Humidity";
            this.Humidity.Size = new System.Drawing.Size(18, 20);
            this.Humidity.TabIndex = 2;
            this.Humidity.Text = "h";
            // 
            // Temperature
            // 
            this.Temperature.AutoSize = true;
            this.Temperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Temperature.Location = new System.Drawing.Point(3, 10);
            this.Temperature.Name = "Temperature";
            this.Temperature.Size = new System.Drawing.Size(14, 20);
            this.Temperature.TabIndex = 2;
            this.Temperature.Text = "t";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.humSet);
            this.panel1.Controls.Add(this.Izmlabel);
            this.panel1.Controls.Add(this.ligSet);
            this.panel1.Controls.Add(this.Minlabel);
            this.panel1.Controls.Add(this.Maxlabel);
            this.panel1.Controls.Add(this.ligIzm);
            this.panel1.Controls.Add(this.liglabel);
            this.panel1.Controls.Add(this.humIzm);
            this.panel1.Controls.Add(this.humlabel);
            this.panel1.Controls.Add(this.temMax);
            this.panel1.Controls.Add(this.temMin);
            this.panel1.Controls.Add(this.temIzm);
            this.panel1.Controls.Add(this.temlabel);
            this.panel1.Location = new System.Drawing.Point(558, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 198);
            this.panel1.TabIndex = 2;
            // 
            // humSet
            // 
            this.humSet.AutoSize = true;
            this.humSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.humSet.Location = new System.Drawing.Point(131, 106);
            this.humSet.Name = "humSet";
            this.humSet.Size = new System.Drawing.Size(22, 16);
            this.humSet.TabIndex = 5;
            this.humSet.Text = "65";
            // 
            // Izmlabel
            // 
            this.Izmlabel.AutoSize = true;
            this.Izmlabel.BackColor = System.Drawing.SystemColors.Control;
            this.Izmlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Izmlabel.ForeColor = System.Drawing.Color.Brown;
            this.Izmlabel.Location = new System.Drawing.Point(31, 41);
            this.Izmlabel.Name = "Izmlabel";
            this.Izmlabel.Size = new System.Drawing.Size(51, 18);
            this.Izmlabel.TabIndex = 9;
            this.Izmlabel.Text = "Текущ";
            // 
            // ligSet
            // 
            this.ligSet.AutoSize = true;
            this.ligSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ligSet.Location = new System.Drawing.Point(131, 143);
            this.ligSet.Name = "ligSet";
            this.ligSet.Size = new System.Drawing.Size(22, 16);
            this.ligSet.TabIndex = 4;
            this.ligSet.Text = "50";
            // 
            // Minlabel
            // 
            this.Minlabel.AutoSize = true;
            this.Minlabel.BackColor = System.Drawing.SystemColors.Control;
            this.Minlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Minlabel.ForeColor = System.Drawing.Color.Brown;
            this.Minlabel.Location = new System.Drawing.Point(108, 41);
            this.Minlabel.Name = "Minlabel";
            this.Minlabel.Size = new System.Drawing.Size(37, 18);
            this.Minlabel.TabIndex = 9;
            this.Minlabel.Text = "Мин";
            // 
            // Maxlabel
            // 
            this.Maxlabel.AutoSize = true;
            this.Maxlabel.BackColor = System.Drawing.SystemColors.Control;
            this.Maxlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Maxlabel.ForeColor = System.Drawing.Color.Brown;
            this.Maxlabel.Location = new System.Drawing.Point(151, 41);
            this.Maxlabel.Name = "Maxlabel";
            this.Maxlabel.Size = new System.Drawing.Size(36, 18);
            this.Maxlabel.TabIndex = 8;
            this.Maxlabel.Text = "Мах";
            // 
            // ligIzm
            // 
            this.ligIzm.AutoSize = true;
            this.ligIzm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ligIzm.Location = new System.Drawing.Point(43, 142);
            this.ligIzm.Name = "ligIzm";
            this.ligIzm.Size = new System.Drawing.Size(17, 16);
            this.ligIzm.TabIndex = 7;
            this.ligIzm.Text = "...";
            this.ligIzm.TextChanged += new System.EventHandler(this.LightText_Changed);
            // 
            // liglabel
            // 
            this.liglabel.AutoSize = true;
            this.liglabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.liglabel.Location = new System.Drawing.Point(15, 137);
            this.liglabel.Name = "liglabel";
            this.liglabel.Size = new System.Drawing.Size(20, 24);
            this.liglabel.TabIndex = 6;
            this.liglabel.Text = "L";
            // 
            // humIzm
            // 
            this.humIzm.AutoSize = true;
            this.humIzm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.humIzm.Location = new System.Drawing.Point(43, 103);
            this.humIzm.Name = "humIzm";
            this.humIzm.Size = new System.Drawing.Size(17, 16);
            this.humIzm.TabIndex = 5;
            this.humIzm.Text = "...";
            // 
            // humlabel
            // 
            this.humlabel.AutoSize = true;
            this.humlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.humlabel.Location = new System.Drawing.Point(15, 98);
            this.humlabel.Name = "humlabel";
            this.humlabel.Size = new System.Drawing.Size(21, 24);
            this.humlabel.TabIndex = 4;
            this.humlabel.Text = "h";
            // 
            // temMax
            // 
            this.temMax.AutoSize = true;
            this.temMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.temMax.Location = new System.Drawing.Point(160, 67);
            this.temMax.Name = "temMax";
            this.temMax.Size = new System.Drawing.Size(22, 16);
            this.temMax.TabIndex = 3;
            this.temMax.Text = "30";
            // 
            // temMin
            // 
            this.temMin.AutoSize = true;
            this.temMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.temMin.Location = new System.Drawing.Point(114, 67);
            this.temMin.Name = "temMin";
            this.temMin.Size = new System.Drawing.Size(22, 16);
            this.temMin.TabIndex = 2;
            this.temMin.Text = "20";
            // 
            // temIzm
            // 
            this.temIzm.AutoSize = true;
            this.temIzm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.temIzm.Location = new System.Drawing.Point(43, 64);
            this.temIzm.Name = "temIzm";
            this.temIzm.Size = new System.Drawing.Size(17, 16);
            this.temIzm.TabIndex = 1;
            this.temIzm.Text = "...";
            // 
            // temlabel
            // 
            this.temlabel.AutoSize = true;
            this.temlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.temlabel.Location = new System.Drawing.Point(15, 59);
            this.temlabel.Name = "temlabel";
            this.temlabel.Size = new System.Drawing.Size(14, 24);
            this.temlabel.TabIndex = 0;
            this.temlabel.Text = "t";
            // 
            // IndicationsChart
            // 
            this.IndicationsChart.BackColor = System.Drawing.SystemColors.Control;
            chartArea1.Name = "ChartArea1";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 100F;
            chartArea1.Position.Width = 96F;
            chartArea1.Position.X = 3F;
            this.IndicationsChart.ChartAreas.Add(chartArea1);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Left;
            legend1.Name = "Legend1";
            legend1.TitleBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.IndicationsChart.Legends.Add(legend1);
            this.IndicationsChart.Location = new System.Drawing.Point(159, 12);
            this.IndicationsChart.MinimumSize = new System.Drawing.Size(395, 423);
            this.IndicationsChart.Name = "IndicationsChart";
            series1.BorderColor = System.Drawing.Color.Red;
            series1.BorderWidth = 5;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.LabelBorderWidth = 10;
            series1.Legend = "Legend1";
            series1.Name = "Температура";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            series1.YValuesPerPoint = 7;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series2.BorderColor = System.Drawing.Color.Blue;
            series2.BorderWidth = 5;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Влажность";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            series2.YValuesPerPoint = 7;
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series3.BorderColor = System.Drawing.Color.Yellow;
            series3.BorderWidth = 5;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.LabelBorderWidth = 12;
            series3.Legend = "Legend1";
            series3.Name = "Освещённость";
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            series3.YValuesPerPoint = 7;
            series3.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.IndicationsChart.Series.Add(series1);
            this.IndicationsChart.Series.Add(series2);
            this.IndicationsChart.Series.Add(series3);
            this.IndicationsChart.Size = new System.Drawing.Size(395, 423);
            this.IndicationsChart.TabIndex = 3;
            this.IndicationsChart.Text = "Indications";
            this.IndicationsChart.Click += new System.EventHandler(this.IndicationsChart_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ConnectionPanel);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.SetPanel);
            this.panel2.Location = new System.Drawing.Point(-1, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(770, 437);
            this.panel2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 436);
            this.Controls.Add(this.IndicationsChart);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ConnectionPanel.ResumeLayout(false);
            this.ConnectionPanel.PerformLayout();
            this.SetPanel.ResumeLayout(false);
            this.SetPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IndicationsChart)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel ConnectionPanel;
        private System.Windows.Forms.Button DisconnectionButton;
        private System.Windows.Forms.TextBox PortText;
        private System.Windows.Forms.Button ConnectionButton;
        private System.Windows.Forms.Label PortLabel;
        private System.Windows.Forms.Panel SetPanel;
        private System.Windows.Forms.Label Humidity;
        private System.Windows.Forms.Label Temperature;
        private System.Windows.Forms.Label Light;
        private System.Windows.Forms.Button TemperaturePlus;
        private System.Windows.Forms.Button TemperatureMinus;
        private System.Windows.Forms.Button HumidityMinus;
        private System.Windows.Forms.Button HumidityPlus;
        private System.Windows.Forms.Button LightMinus;
        private System.Windows.Forms.Button Switch;
        private System.Windows.Forms.Button LightPlus;
        private System.Windows.Forms.Label Change;
        private System.Windows.Forms.Button TemperaturePlusMax;
        private System.Windows.Forms.Button TemperatureMinusMax;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label temlabel;
        private System.Windows.Forms.Label temMax;
        private System.Windows.Forms.Label temMin;
        private System.Windows.Forms.Label humlabel;
        private System.Windows.Forms.Label liglabel;
        private System.Windows.Forms.Label Maxlabel;
        private System.Windows.Forms.Label Minlabel;
        private System.Windows.Forms.Label Izmlabel;
        private System.Windows.Forms.Label humSet;
        private System.Windows.Forms.Label ligSet;
        private System.Windows.Forms.Label PortChek1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label temIzm;
        public System.Windows.Forms.Label humIzm;
        public System.Windows.Forms.Label ligIzm;
        private System.Windows.Forms.Button ClearChart;
        public System.Windows.Forms.DataVisualization.Charting.Chart IndicationsChart;
    }
}

