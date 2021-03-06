﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GlobalOptimization
{
    public partial class Form1 : Form
    {
        private double alpha;
        private double betta;
        private double gamma;
        private double delta;
        private double left_range_x;
        private double right_range_x;
        private int num_of_iterations;
        private double accuracy;
        private double param_method;
        private struct Result
        {
            public double min_x;
            public double min_y;
            public double accuracy;
            public int stop_iteration;
            public string method;
            public override string ToString()
            {
                string str_res = method + ":" + Environment.NewLine +
                    "минимум: " + min_y.ToString() + ";" + Environment.NewLine
                    + "число проведенных испытаниий: " + stop_iteration.ToString() + ";" + Environment.NewLine
                    + "точность: " + accuracy.ToString();
                return str_res;
            }
        }
        private Result result;
        private class Point
        {
            public double x;
            public double y;
            public Point()
            {
                x = 0;
                y = 0;
            }
            public Point(double _x, double _y)
            {
                x = _x;
                y = _y;
            }
            public Point(Point _p)
            {
                x = _p.x;
                y = _p.y;
            }
            public static bool operator > (Point left, Point right)
            {
                return (left.y > right.y);
            }
            public static bool operator < (Point left, Point right)
            {
                return (left.y < right.y);
            }
            public static bool operator <= (Point left, Point right)
            {
                return (left.y <= right.y);
            }
            public static bool operator >= (Point left, Point right)
            {
                return (left.y >= right.y);
            }
        }
        public Form1()
        {
            InitializeComponent();
            initialize_plot_parameters();
            initialize_method_parameters();
        }
        private void initialize_plot_parameters()
        {
            alpha = double.Parse(alpha_textBox.Text, System.Globalization.CultureInfo.InvariantCulture);
            betta = double.Parse(betta_textBox.Text, System.Globalization.CultureInfo.InvariantCulture);
            gamma = double.Parse(gamma_textBox.Text, System.Globalization.CultureInfo.InvariantCulture);
            delta = double.Parse(delta_textBox.Text, System.Globalization.CultureInfo.InvariantCulture);
            left_range_x = double.Parse(range_left_textBox.Text, System.Globalization.CultureInfo.InvariantCulture);
            right_range_x = double.Parse(range_right_textBox.Text, System.Globalization.CultureInfo.InvariantCulture);
        }
        private void initialize_method_parameters()
        {

            num_of_iterations = int.Parse(iterations_textBox.Text);
            accuracy = double.Parse(accuracy_textBox.Text, System.Globalization.CultureInfo.InvariantCulture);
            param_method = double.Parse(method_param_textBox.Text, System.Globalization.CultureInfo.InvariantCulture);
        }
        private void plot_button_Click(object sender, EventArgs e)
        {
            try
            {
                initialize_plot_parameters();
            }
            catch (System.FormatException)
            {
                return;
            }
            plot_function();
        }

        public double function(double x)
        {
            return (alpha*Math.Sin(betta*x)+gamma*Math.Cos(delta*x));
        }

        private void plot_function()
        {
            plot_chart.ChartAreas[0].AxisX.Maximum = right_range_x;
            plot_chart.ChartAreas[0].AxisX.Minimum = left_range_x;
            plot_chart.Series[0].Points.Clear();
            double x = left_range_x;
            double step = 0.25;
            while (x < right_range_x)
            {
                plot_chart.Series[0].Points.AddXY(x, function(x));
                x += step;
            }
            plot_chart.Series[0].Points.AddXY(right_range_x, function(right_range_x));

          
        }
        
        //------------------------------------------------------------------------------------
        // Brute force Method
        private Result brute_force_method()
        {
            points_chart.ChartAreas[0].AxisX.Maximum = plot_chart.ChartAreas[0].AxisX.Maximum;
            points_chart.ChartAreas[0].AxisX.Minimum = plot_chart.ChartAreas[0].AxisX.Minimum;
            points_chart.Series[0].Points.Clear();
            points_chart.Series[0].Points.AddXY(left_range_x, 10);
            points_chart.Series[0].Points.AddXY(right_range_x, 10);
           

            double x = left_range_x;
            double y = function(x);
            result.min_x = x;
            result.min_y = y;
            result.stop_iteration = 0;
            if (y > function(right_range_x))
            {
                result.min_y = function(right_range_x);
                result.min_x = right_range_x;
            }
            result.accuracy = (right_range_x - left_range_x) / num_of_iterations;
            if (result.accuracy < accuracy)
                result.accuracy = accuracy;
            x += result.accuracy;
            while (x < right_range_x)
            {
                points_chart.Series[0].Points.AddXY(x, 10);
                y = function(x);
                if (y < result.min_y)
                {
                    result.min_y = y;
                    result.min_x = x;
                }
                result.stop_iteration++;
                x += result.accuracy;
            }
            
            return result;
        }

        //------------------------------------------------------------------------------------
        // Piyavsky Method

        private Result piyavsky_method()
        {
            points_chart.ChartAreas[0].AxisX.Maximum = right_range_x;
            points_chart.ChartAreas[0].AxisX.Minimum = left_range_x;
            points_chart.Series[1].Points.Clear();
            points_chart.Series[1].Points.AddXY(left_range_x, 6);
            points_chart.Series[1].Points.AddXY(right_range_x, 6);

            List<Point> points_list = new List<Point>();
            double r = param_method;
            double m = 1, maxM = 0, M;

            double R, maxR = 0;
            int maxIR = 0;

            Point left_range_point = new Point(left_range_x, function(left_range_x));
            Point right_range_point = new Point(right_range_x, function(right_range_x));
            points_list.Add(left_range_point);
            points_list.Add(right_range_point);

            result.min_y = left_range_point.y;
            result.min_x = left_range_point.x;
            if (left_range_point.y > right_range_point.y)
            {
                result.min_y = right_range_point.y;
                result.min_x = right_range_point.x;
            }

            for (int i = 1; i < num_of_iterations - 1; ++i)
            {
                points_list.Sort((left, right) => left.x.CompareTo(right.x));

                for (int j = 1; j <= i; ++j)
                {
                    M = (Math.Abs(points_list[j].y - points_list[j - 1].y)) / (points_list[j].x - points_list[j - 1].x);
                    if (M > maxM)
                    {
                        maxM = M;
                    }
                }

                if (maxM > 0)
                {
                    m = r * maxM;
                }

                maxR = 0;
                maxIR = 1;
                for (int j = 1; j <= i; ++j)
                {
                    R = (m * (points_list[j].x - points_list[j - 1].x) - (points_list[j].y + points_list[j - 1].y)) / 2;

                    if (R > maxR)
                    {
                        maxR = R;
                        maxIR = j;
                    }
                }

                result.accuracy = Math.Abs(points_list[maxIR].x - points_list[maxIR - 1].x);
                if (result.accuracy < accuracy)
                {
                    break;
                }

                Point newPoint = new Point();
                newPoint.x = 0.5 * (points_list[maxIR].x + points_list[maxIR - 1].x)
                           - 0.5 * (points_list[maxIR].y - points_list[maxIR - 1].y) / m;
                newPoint.y = function(newPoint.x);
                points_list.Add(newPoint);
                points_chart.Series[1].Points.AddXY(newPoint.x, 6);

                if (newPoint.y < result.min_y)
                {
                    result.min_y = newPoint.y;
                    result.min_x = newPoint.x;
                }
                result.stop_iteration = i;
            }

            return result;
        }

        //------------------------------------------------------------------------------------
        // Strongin Method
        private Result strongin_method()
        {
            points_chart.ChartAreas[0].AxisX.Maximum = right_range_x;
            points_chart.ChartAreas[0].AxisX.Minimum = left_range_x;
            points_chart.Series[2].Points.Clear();
            points_chart.Series[2].Points.AddXY(left_range_x, 2);
            points_chart.Series[2].Points.AddXY(right_range_x, 2);

            List<Point> points_list = new List<Point>();
            double r = param_method;
            double m = 1, maxM = 0, M;

            double R, maxR = 0;
            int maxIR = 0;

            Point left_range_point = new Point(left_range_x, function(left_range_x));
            Point right_range_point = new Point(right_range_x, function(right_range_x));
            points_list.Add(left_range_point);
            points_list.Add(right_range_point);

            result.min_y = left_range_point.y;
            result.min_x = left_range_point.x;
            if (left_range_point.y > right_range_point.y)
            {
                result.min_y = right_range_point.y;
                result.min_x = right_range_point.x;
            }

            for (int i = 1; i < num_of_iterations - 1; ++i)
            {
                points_list.Sort((left, right) => left.x.CompareTo(right.x));

                for (int j = 1; j <= i; ++j)
                {
                    M = (Math.Abs(points_list[j].y - points_list[j - 1].y)) / (points_list[j].x - points_list[j - 1].x);
                    if (M > maxM)
                    {
                        maxM = M;
                    }
                }

                if (maxM > 0)
                {
                    m = r * maxM;
                }

                maxR = 0;
                maxIR = 1;
                for (int j = 1; j <= i; ++j)
                {
                    R = m * (points_list[j].x - points_list[j - 1].x) + (Math.Pow((points_list[j].y - points_list[j - 1].y), 2))
                        / (m * (points_list[j].x - points_list[j - 1].x)) - 2 * (points_list[j].y + points_list[j - 1].y);

                    if (R > maxR)
                    {
                        maxR = R;
                        maxIR = j;
                    }
                }

                result.accuracy = Math.Abs(points_list[maxIR].x - points_list[maxIR - 1].x);
                if (result.accuracy < accuracy)
                {
                    break;
                }

                Point newPoint = new Point();
                newPoint.x = 0.5 * (points_list[maxIR].x + points_list[maxIR - 1].x)
                           - 0.5 * (points_list[maxIR].y - points_list[maxIR - 1].y) / m;
                newPoint.y = function(newPoint.x);
                points_list.Add(newPoint);
                points_chart.Series[2].Points.AddXY(newPoint.x, 2);

                if (newPoint.y < result.min_y)
                {
                    result.min_y = newPoint.y;
                    result.min_x = newPoint.x;
                }
                result.stop_iteration = i;
            }

            return result;
        }


        private void run_button_Click(object sender, EventArgs e)
        {
            try
            {
                initialize_plot_parameters();
                initialize_method_parameters();
            }
            catch (System.FormatException)
            {
                return;
            }
            plot_function();
            if (trivial_radioButton.Checked)
            {
                result.method = "Метод перебора";
                brute_force_method();
                result_textBox.AppendText(result.ToString());
                result_textBox.AppendText(Environment.NewLine);
            }
            else if (piyavsky_radioButton.Checked)
            {
                result.method = "Метод Пиявского";
               
                piyavsky_method();
                result_textBox.AppendText(result.ToString());
                result_textBox.AppendText(Environment.NewLine);
            }
            else if (strongin_radioButton.Checked)
            {
                result.method = "Метод Стронгина";
               
                strongin_method();
                result_textBox.AppendText(result.ToString());
                result_textBox.AppendText(Environment.NewLine);
            }
        }

        private void plot_chart_Click(object sender, EventArgs e)
        {

        }

        private void result_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void points_chart_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
