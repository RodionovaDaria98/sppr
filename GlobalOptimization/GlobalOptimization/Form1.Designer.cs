namespace GlobalOptimization
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.plot_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.points_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.alpha_textBox = new System.Windows.Forms.TextBox();
            this.betta_textBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gamma_textBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.delta_textBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.range_left_textBox = new System.Windows.Forms.TextBox();
            this.range_right_textBox = new System.Windows.Forms.TextBox();
            this.trivial_radioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.strongin_radioButton = new System.Windows.Forms.RadioButton();
            this.piyavsky_radioButton = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.plot_button = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.method_param_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.accuracy_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.iterations_textBox = new System.Windows.Forms.TextBox();
            this.run_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.result_textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.plot_chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.points_chart)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // plot_chart
            // 
            chartArea3.Name = "ChartArea1";
            this.plot_chart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.plot_chart.Legends.Add(legend3);
            this.plot_chart.Location = new System.Drawing.Point(5, 34);
            this.plot_chart.Margin = new System.Windows.Forms.Padding(4);
            this.plot_chart.Name = "plot_chart";
            this.plot_chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Legend = "Legend1";
            series5.MarkerColor = System.Drawing.Color.White;
            series5.Name = "Функция";
            this.plot_chart.Series.Add(series5);
            this.plot_chart.Size = new System.Drawing.Size(710, 482);
            this.plot_chart.TabIndex = 0;
            this.plot_chart.Text = "chart1";
            this.plot_chart.Click += new System.EventHandler(this.plot_chart_Click);
            // 
            // points_chart
            // 
            chartArea4.Name = "ChartArea1";
            this.points_chart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.points_chart.Legends.Add(legend4);
            this.points_chart.Location = new System.Drawing.Point(5, 522);
            this.points_chart.Margin = new System.Windows.Forms.Padding(4);
            this.points_chart.Name = "points_chart";
            this.points_chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series6.Legend = "Legend1";
            series6.Name = "Перебор";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series7.Legend = "Legend1";
            series7.MarkerSize = 7;
            series7.Name = "Пиявский";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series8.Legend = "Legend1";
            series8.MarkerSize = 7;
            series8.Name = "Стронгин";
            this.points_chart.Series.Add(series6);
            this.points_chart.Series.Add(series7);
            this.points_chart.Series.Add(series8);
            this.points_chart.Size = new System.Drawing.Size(710, 188);
            this.points_chart.TabIndex = 1;
            this.points_chart.Text = "chart2";
            this.points_chart.Click += new System.EventHandler(this.points_chart_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(88, 49);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "F(x)=";
            // 
            // alpha_textBox
            // 
            this.alpha_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.alpha_textBox.Location = new System.Drawing.Point(134, 46);
            this.alpha_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.alpha_textBox.Name = "alpha_textBox";
            this.alpha_textBox.Size = new System.Drawing.Size(22, 22);
            this.alpha_textBox.TabIndex = 8;
            this.alpha_textBox.Text = "2";
            // 
            // betta_textBox
            // 
            this.betta_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.betta_textBox.Location = new System.Drawing.Point(207, 46);
            this.betta_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.betta_textBox.Name = "betta_textBox";
            this.betta_textBox.Size = new System.Drawing.Size(23, 22);
            this.betta_textBox.TabIndex = 10;
            this.betta_textBox.Text = "3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(164, 49);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "* sin";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // gamma_textBox
            // 
            this.gamma_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gamma_textBox.Location = new System.Drawing.Point(268, 46);
            this.gamma_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.gamma_textBox.Name = "gamma_textBox";
            this.gamma_textBox.Size = new System.Drawing.Size(23, 22);
            this.gamma_textBox.TabIndex = 12;
            this.gamma_textBox.Text = "3";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(238, 49);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "x + ";
            // 
            // delta_textBox
            // 
            this.delta_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delta_textBox.Location = new System.Drawing.Point(345, 46);
            this.delta_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.delta_textBox.Name = "delta_textBox";
            this.delta_textBox.Size = new System.Drawing.Size(26, 22);
            this.delta_textBox.TabIndex = 14;
            this.delta_textBox.Text = "5";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(298, 49);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 17);
            this.label9.TabIndex = 13;
            this.label9.Text = "* cos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(227, 82);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "x∈ [";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(302, 82);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = ",";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(358, 82);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "]";
            // 
            // range_left_textBox
            // 
            this.range_left_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.range_left_textBox.Location = new System.Drawing.Point(264, 79);
            this.range_left_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.range_left_textBox.Name = "range_left_textBox";
            this.range_left_textBox.Size = new System.Drawing.Size(30, 27);
            this.range_left_textBox.TabIndex = 18;
            this.range_left_textBox.Text = "0";
            // 
            // range_right_textBox
            // 
            this.range_right_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.range_right_textBox.Location = new System.Drawing.Point(319, 79);
            this.range_right_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.range_right_textBox.Name = "range_right_textBox";
            this.range_right_textBox.Size = new System.Drawing.Size(31, 27);
            this.range_right_textBox.TabIndex = 19;
            this.range_right_textBox.Text = "10";
            // 
            // trivial_radioButton
            // 
            this.trivial_radioButton.AutoSize = true;
            this.trivial_radioButton.Checked = true;
            this.trivial_radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.trivial_radioButton.ForeColor = System.Drawing.SystemColors.MenuText;
            this.trivial_radioButton.Location = new System.Drawing.Point(8, 44);
            this.trivial_radioButton.Margin = new System.Windows.Forms.Padding(4);
            this.trivial_radioButton.Name = "trivial_radioButton";
            this.trivial_radioButton.Size = new System.Drawing.Size(113, 24);
            this.trivial_radioButton.TabIndex = 20;
            this.trivial_radioButton.TabStop = true;
            this.trivial_radioButton.Text = "Перебора";
            this.trivial_radioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.strongin_radioButton);
            this.groupBox1.Controls.Add(this.piyavsky_radioButton);
            this.groupBox1.Controls.Add(this.trivial_radioButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.groupBox1.Location = new System.Drawing.Point(725, 221);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(156, 169);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Метод";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // strongin_radioButton
            // 
            this.strongin_radioButton.AutoSize = true;
            this.strongin_radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.strongin_radioButton.ForeColor = System.Drawing.SystemColors.MenuText;
            this.strongin_radioButton.Location = new System.Drawing.Point(8, 108);
            this.strongin_radioButton.Margin = new System.Windows.Forms.Padding(4);
            this.strongin_radioButton.Name = "strongin_radioButton";
            this.strongin_radioButton.Size = new System.Drawing.Size(120, 24);
            this.strongin_radioButton.TabIndex = 22;
            this.strongin_radioButton.Text = "Стронгина";
            this.strongin_radioButton.UseVisualStyleBackColor = true;
            // 
            // piyavsky_radioButton
            // 
            this.piyavsky_radioButton.AutoSize = true;
            this.piyavsky_radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.piyavsky_radioButton.ForeColor = System.Drawing.SystemColors.MenuText;
            this.piyavsky_radioButton.Location = new System.Drawing.Point(8, 76);
            this.piyavsky_radioButton.Margin = new System.Windows.Forms.Padding(4);
            this.piyavsky_radioButton.Name = "piyavsky_radioButton";
            this.piyavsky_radioButton.Size = new System.Drawing.Size(119, 24);
            this.piyavsky_radioButton.TabIndex = 21;
            this.piyavsky_radioButton.Text = "Пиявского";
            this.piyavsky_radioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.plot_button);
            this.groupBox2.Controls.Add(this.gamma_textBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.range_right_textBox);
            this.groupBox2.Controls.Add(this.alpha_textBox);
            this.groupBox2.Controls.Add(this.range_left_textBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.betta_textBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.delta_textBox);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox2.Location = new System.Drawing.Point(715, 34);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(406, 168);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Функция";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label11.Location = new System.Drawing.Point(378, 49);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 17);
            this.label11.TabIndex = 11;
            this.label11.Text = "x";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // plot_button
            // 
            this.plot_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.plot_button.ForeColor = System.Drawing.Color.Black;
            this.plot_button.Location = new System.Drawing.Point(158, 114);
            this.plot_button.Margin = new System.Windows.Forms.Padding(4);
            this.plot_button.Name = "plot_button";
            this.plot_button.Size = new System.Drawing.Size(133, 31);
            this.plot_button.TabIndex = 28;
            this.plot_button.Text = "Построить";
            this.plot_button.UseVisualStyleBackColor = true;
            this.plot_button.Click += new System.EventHandler(this.plot_button_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.method_param_textBox);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.accuracy_textBox);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.iterations_textBox);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox3.Location = new System.Drawing.Point(882, 221);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(239, 169);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Параметры";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(8, 123);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 20);
            this.label10.TabIndex = 17;
            this.label10.Text = "r =";
            // 
            // method_param_textBox
            // 
            this.method_param_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.method_param_textBox.Location = new System.Drawing.Point(61, 123);
            this.method_param_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.method_param_textBox.Name = "method_param_textBox";
            this.method_param_textBox.Size = new System.Drawing.Size(53, 26);
            this.method_param_textBox.TabIndex = 18;
            this.method_param_textBox.Text = "1.01";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(8, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Точность";
            // 
            // accuracy_textBox
            // 
            this.accuracy_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.accuracy_textBox.Location = new System.Drawing.Point(132, 76);
            this.accuracy_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.accuracy_textBox.Name = "accuracy_textBox";
            this.accuracy_textBox.Size = new System.Drawing.Size(99, 26);
            this.accuracy_textBox.TabIndex = 16;
            this.accuracy_textBox.Text = "0.001";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(7, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Число итераций";
            // 
            // iterations_textBox
            // 
            this.iterations_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iterations_textBox.Location = new System.Drawing.Point(146, 34);
            this.iterations_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.iterations_textBox.Name = "iterations_textBox";
            this.iterations_textBox.Size = new System.Drawing.Size(85, 26);
            this.iterations_textBox.TabIndex = 14;
            this.iterations_textBox.Text = "50";
            // 
            // run_button
            // 
            this.run_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.run_button.Location = new System.Drawing.Point(890, 398);
            this.run_button.Margin = new System.Windows.Forms.Padding(4);
            this.run_button.Name = "run_button";
            this.run_button.Size = new System.Drawing.Size(133, 31);
            this.run_button.TabIndex = 24;
            this.run_button.Text = "Рассчитать";
            this.run_button.UseVisualStyleBackColor = true;
            this.run_button.Click += new System.EventHandler(this.run_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cancel_button.Location = new System.Drawing.Point(960, 751);
            this.cancel_button.Margin = new System.Windows.Forms.Padding(4);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(133, 31);
            this.cancel_button.TabIndex = 25;
            this.cancel_button.Text = "Закрыть";
            this.cancel_button.UseVisualStyleBackColor = true;
            // 
            // result_textBox
            // 
            this.result_textBox.Location = new System.Drawing.Point(723, 476);
            this.result_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.result_textBox.Multiline = true;
            this.result_textBox.Name = "result_textBox";
            this.result_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.result_textBox.Size = new System.Drawing.Size(398, 234);
            this.result_textBox.TabIndex = 26;
            this.result_textBox.TextChanged += new System.EventHandler(this.result_textBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 795);
            this.Controls.Add(this.result_textBox);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.run_button);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.points_chart);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.plot_chart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Поиск глобального минимума";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.plot_chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.points_chart)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart plot_chart;
        private System.Windows.Forms.DataVisualization.Charting.Chart points_chart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox alpha_textBox;
        private System.Windows.Forms.TextBox betta_textBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox gamma_textBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox delta_textBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox range_left_textBox;
        private System.Windows.Forms.TextBox range_right_textBox;
        private System.Windows.Forms.RadioButton trivial_radioButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton strongin_radioButton;
        private System.Windows.Forms.RadioButton piyavsky_radioButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox method_param_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox accuracy_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox iterations_textBox;
        private System.Windows.Forms.Button run_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button plot_button;
        private System.Windows.Forms.TextBox result_textBox;
        private System.Windows.Forms.Label label11;
    }
}

