using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using LiveCharts;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using LiveCharts.Defaults;
using Google.Protobuf.WellKnownTypes;
using LiveCharts.WinForms;
using LiveCharts.Wpf;
using System.Data.SqlTypes;
using System.Security.Policy;
using System.Windows.Ink;
using Org.BouncyCastle.Utilities;
//using System.Windows.Forms.DataVisualization.Charting;

namespace LoginScreen.UC
{
    public partial class UC_STATISTICS : UserControl
    {
        public UC_STATISTICS()
        {
            InitializeComponent();




        }

        


        List<double> money_1 = new List<double>() { -491, 382, 726, 457, 844, 1012, 1084, 645, 382, 395, 701, 371, 189, 463, 757, 184, 999, 856, 908, 539, 601, 751, 844, 528, -425, 811, 340, 1092, 501, 366, };
        List<double> money_2 = new List<double>() { 366, 549, 428, 574, 250, 809, 567, 429, 1036, 540, 800, 217, 358, 911, 1052, 591, 1093, 1031, 923, 531, 459, 690, 999, 253, 392, 470, 504, 798, 799, 976, };
        List<double> money_3 = new List<double>() { 976, 805, 857, 627, 968, 993, 742, 373, 118, 985, 775, 888, 391, 403, 756, 760, 226, 804, 325, 962, 622, 717, 730, 825, 117, 947, 815, 832, 602, 878, };

        List<string> dates_1 = new List<string>() { "1 Mar", "2 Mar", "3 Mar", "4 Mar", "5 Mar", "6 Mar", "7 Mar", "8 Mar", "9 Mar", "10 Mar", "11 Mar", "12 Mar", "13 Mar", "14 Mar", "15 Mar", "16 Mar", "17 Mar", "18 Mar", "19 Mar", "20 Mar", "21 Mar", "22 Mar", "23 Mar", "24 Mar", "25 Mar", "26 Mar", "27 Mar", "28 Mar", "29 Mar", "30 Mar", };
        List<string> dates_2 = new List<string>() { "1 Apr", "2 Apr", "3 Apr", "4 Apr", "5 Apr", "6 Apr", "7 Apr", "8 Apr", "9 Apr", "10 Apr", "11 Apr", "12 Apr", "13 Apr", "14 Apr", "15 Apr", "16 Apr", "17 Apr", "18 Apr", "19 Apr", "20 Apr", "21 Apr", "22 Apr", "23 Apr", "24 Apr", "25 Apr", "26 Apr", "27 Apr", "28 Apr", "29 Apr", "30 Apr", };
        List<string> dates_3 = new List<string>() { "1 May", "2 May", "3 May", "4 May", "5 May", "6 May", "7 May", "8 May", "9 May", "10 May", "11 May", "12 May", "13 May", "14 May", "15 May", "16 May", "17 May", "18 May", "19 May", "20 May", "21 May", "22 May", "23 May", "24 May", "25 May", "26 May", "27 May", "28 May", "29 May", "30 May", };

        List<double> shop1 = new List<double>() { 842, 320, 750, 472 };
        List<double> shop2 = new List<double>() { 179, 529, 911, 727 };
        List<double> shop3 = new List<double>() { 947, 244, 725, 282 };
        List<double> shop4 = new List<double>() { 842, 947, 529, 282 };

        List<List<double>> shopping = new List<List<double>>();
        public static List<string> data = new List<string>();
        

        private void UC_STATISTICS_Load(object sender, EventArgs e)
        {
            shopping.Add(shop1);
            shopping.Add(shop2);
            shopping.Add(shop3);
            shopping.Add(shop4);


            max_budget_txtbox.Hint = "Max Budget";
            spent_money_txtbox.Hint = "Sum spent";
            invoice_txtbox.Hint = "Money Cost";
            ///////////////////////////GAUGE///////////////////////////////////////

            ok = 1;
            budget.Value = 0;
            budget.Font = new Font("Bahnschrift", 20, FontStyle.Bold);
            spent_money_txtbox.Text = "2384";
            spent_money_txtbox.Enabled = false;
            
            ////////////////////////////CARTESIAN CHARTS///////////////////////////
            
            chart.BackColor = Color.FromArgb(250, 250, 251);

            SeriesCollection series = new SeriesCollection();
            series.Add(new LineSeries()
            {
                Title = " ",
                Values = new ChartValues<double>(money_3),
                Fill = System.Windows.Media.Brushes.Transparent,
                Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 117, 214)),
                //PointGeometry = null,
                PointGeometrySize = 15,
                StrokeThickness = 4,
                LineSmoothness = 0.2,
            });
            chart.Series = series;

            chart.AxisX.Add(new Axis
            {
                Title = "Time",
                Labels = dates_3,
                
                Separator = new Separator // force the separator step to 1, so it always display all labels
                {
                    Step = 1,
                    IsEnabled = false //disable it to make it invisible.
                },
                LabelsRotation = 15
            });
          
            chart.AxisY.Add(new Axis
            {
                MaxRange = 1000,
                MaxValue = 1500,
                MinValue = -1000,
                LabelFormatter = value => value + " RON"
            });
               
            ///////////////////////////PIECHART///////////////////////////////////////

            
            pieChart1.BackColor = Color.FromArgb(250, 250, 251);
            pieChart1.ForeColor = Color.FromArgb(250, 250, 251);
            Func<ChartPoint, string> labelPoint = chartPoint =>
            string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);
            pieChart1.Series = new SeriesCollection
            {
                new PieSeries
                {
                    //2384
                    Title = "Shopping",
                    Values = new ChartValues<double> {shopping[month_cbbox.SelectedIndex][0] },
                    //PushOut = 15,
                    DataLabels = true,
                    LabelPoint = labelPoint,
                    Fill = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(0,218, 177)), //#00DAB1
                },
                new PieSeries
                {
                    Title = "Transport",
                    Values = new ChartValues<double> {shopping[month_cbbox.SelectedIndex][1] },
                    DataLabels = true,
                    LabelPoint = labelPoint,
                    Fill = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(166, 111, 204)), //
                },
                new PieSeries
                {
                    Title = "Food",
                    Values = new ChartValues<double> { shopping[month_cbbox.SelectedIndex][2] },
                    DataLabels = true,
                    LabelPoint = labelPoint,
                    Fill = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 117, 214)),
                },
                new PieSeries
                {
                    Title = "Miscellaneous",
                    Values = new ChartValues<double> { shopping[month_cbbox.SelectedIndex][3] },
                    DataLabels = true,
                    LabelPoint = labelPoint,
                    Fill = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 121, 153)),
                }
            };

            pieChart1.LegendLocation = LegendLocation.Bottom;
        }

        private void month_cbbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(month_cbbox.SelectedIndex == 0)
            {
               


                chart.AxisX.Clear();
                chart.AxisY.Clear();
                chart.Series.Clear();
                SeriesCollection series = new SeriesCollection();
                series.Add(new LineSeries()
                {
                    Title = " ",
                    Values = new ChartValues<double>(money_3),
                    Fill = System.Windows.Media.Brushes.Transparent,
                    Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 117, 214)),
                    //PointGeometry = null,
                    PointGeometrySize = 15,
                    StrokeThickness = 4,
                    LineSmoothness = 0.2,
                });
                chart.Series = series;

                chart.AxisX.Add(new Axis
                {
                    Title = "Time",
                    Labels = dates_3,

                    Separator = new Separator // force the separator step to 1, so it always display all labels
                    {
                        Step = 1,
                        IsEnabled = false //disable it to make it invisible.
                    },
                    LabelsRotation = 15
                });

                chart.AxisY.Add(new Axis
                {
                    MaxRange = 1000,
                    MaxValue = 1500,
                    MinValue = -1000,
                    LabelFormatter = value => value + " RON"
                });
            }else if (month_cbbox.SelectedIndex == 1)
            {
               


                chart.AxisX.Clear();
                chart.AxisY.Clear();
                chart.Series.Clear();

                SeriesCollection series = new SeriesCollection();
                series.Add(new LineSeries()
                {
                    Title = " ",
                    Values = new ChartValues<double>(money_2),
                    Fill = System.Windows.Media.Brushes.Transparent,
                    Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 117, 214)),
                    //PointGeometry = null,
                    PointGeometrySize = 15,
                    StrokeThickness = 4,
                    LineSmoothness = 0.2,
                });
                chart.Series = series;

                chart.AxisX.Add(new Axis
                {
                    Title = "Time",
                    Labels = dates_2,

                    Separator = new Separator // force the separator step to 1, so it always display all labels
                    {
                        Step = 1,
                        IsEnabled = false //disable it to make it invisible.
                    },
                    LabelsRotation = 15
                });

                chart.AxisY.Add(new Axis
                {
                    MaxRange = 1000,
                    MaxValue = 1500,
                    MinValue = -1000,
                    LabelFormatter = value => value + " RON"
                });
            }else if (month_cbbox.SelectedIndex == 2)
            {
                


                chart.AxisX.Clear();
                chart.AxisY.Clear();
                chart.Series.Clear();

                SeriesCollection series = new SeriesCollection();
                series.Add(new LineSeries()
                {
                    Title = " ",
                    Values = new ChartValues<double>(money_3),
                    Fill = System.Windows.Media.Brushes.Transparent,
                    Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 117, 214)),
                    //PointGeometry = null,
                    PointGeometrySize = 15,
                    StrokeThickness = 4,
                    LineSmoothness = 0.2,
                });
                chart.Series = series;

                chart.AxisX.Add(new Axis
                {
                    Title = "Time",
                    Labels = dates_3,

                    Separator = new Separator // force the separator step to 1, so it always display all labels
                    {
                        Step = 1,
                        IsEnabled = false //disable it to make it invisible.
                    },
                    LabelsRotation = 15
                });

                chart.AxisY.Add(new Axis
                {
                    MaxRange = 1000,
                    MaxValue = 1500,
                    MinValue = -1000,
                    LabelFormatter = value => value + " RON"
                });
            }

            pieChart1.BackColor = Color.FromArgb(250, 250, 251);
            pieChart1.ForeColor = Color.FromArgb(250, 250, 251);
            Func<ChartPoint, string> labelPoint = chartPoint =>
            string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);
            pieChart1.Series = new SeriesCollection
            {
                new PieSeries
                {
                    //2384
                    Title = "Shopping",
                    Values = new ChartValues<double> {shopping[month_cbbox.SelectedIndex][0] },
                    //PushOut = 15,
                    DataLabels = true,
                    LabelPoint = labelPoint,
                    Fill = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(0,218, 177)), //#00DAB1
                },
                new PieSeries
                {
                    Title = "Transport",
                    Values = new ChartValues<double> {shopping[month_cbbox.SelectedIndex][1] },
                    DataLabels = true,
                    LabelPoint = labelPoint,
                    Fill = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(166, 111, 204)), //
                },
                new PieSeries
                {
                    Title = "Food",
                    Values = new ChartValues<double> { shopping[month_cbbox.SelectedIndex][2] },
                    DataLabels = true,
                    LabelPoint = labelPoint,
                    Fill = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 117, 214)),
                },
                new PieSeries
                {
                    Title = "Miscellaneous",
                    Values = new ChartValues<double> { shopping[month_cbbox.SelectedIndex][3] },
                    DataLabels = true,
                    LabelPoint = labelPoint,
                    Fill = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 121, 153)),
                }
            };



        }
        int max_budget, invoice, spent, aux, ok, savings, b_text;
        
        //good code
        private void maxbdt_button_Click(object sender, EventArgs e)
        {
            

            if (max_budget_txtbox.Text != "")
            {
                max_budget = Convert.ToInt32(max_budget_txtbox.Text.ToString());
                var time = DateTime.Now;
                time = time.AddMonths(1);
                if (ok == 1 && max_budget >= 2384)
                {
                    max_budget = Convert.ToInt32(max_budget_txtbox.Text.ToString()); ok = 0;
                    max_budget_txtbox.Enabled = false;
                    maxbdt_button.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Monthly Budget Already set, try again in " + time.ToString("dd MMMM"));
                }

                spent = Convert.ToInt32(spent_money_txtbox.Text.ToString());//Convert.ToInt32(spent_money_txtbox.Text.ToString()); 
                b_text = ((spent * 100) / max_budget);
                budget.Text = b_text.ToString() + "%";

                savings = max_budget - spent;
                save_label.Text = "Savings = " + savings.ToString() + " RON";
             
                aux = ((spent * 100) / max_budget);
                              
                budget.Value = Convert.ToInt32(aux);
                budget.Update();
            }
        }

        private void budget_button_Click(object sender, EventArgs e)
        {
            if (max_budget_txtbox.Enabled == false)
            {
               
                spent = Convert.ToInt32(spent_money_txtbox.Text.ToString());//Convert.ToInt32(spent_money_txtbox.Text.ToString());                  
                invoice = Convert.ToInt32(invoice_txtbox.Text.ToString());
                //b_text = ((spent * 100) / max_budget);
                budget.Text = b_text.ToString() + "%";                                               

                if(savings - invoice < 0 || invoice > max_budget-spent || aux + (invoice * 100 / max_budget) > 100)
                {
                    MessageBox.Show("Nu mai exista monetar, saraca lipit");
                }
                else
                {
                    b_text = b_text + ((invoice * 100) / max_budget);
                    budget.Text = b_text.ToString() + "%";

                    aux = aux + (invoice * 100 / max_budget);
                    budget.Value = Convert.ToInt32(aux);

                    savings = savings - invoice;
                    save_label.Text = "Savings = " + savings.ToString() + " RON";
                }
            }            
            budget.Update();

        }



    }
}
