using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;

namespace UTJ {
    public partial class statistics : Form {

        private db d = new db();

        public statistics() {
            InitializeComponent();

            Func<ChartPoint, string> labelpoint = charPoint =>
                string.Format("{0} ({1:P})", charPoint.Y, charPoint.Participation);

            int curso = d.countEnMarcha();
            int cancel = d.countCancelados();
            int suspanded = d.countSuspendidos();
            int completed = d.countCompletados();

            mainChart.Series = new SeriesCollection {
                new PieSeries {
                    Title = "Proyectos En proceso",
                    Values = new ChartValues<int> {curso},
                    PushOut = 15,
                    DataLabels = true,
                    LabelPoint = labelpoint
                },
                
                new PieSeries {
                    Title = "Proyectos Cancelados",
                    Values = new ChartValues<int> {cancel},
                    PushOut = 15,
                    DataLabels = true,
                    LabelPoint = labelpoint
                },
                new PieSeries {
                    Title = "Proyectos Suspendidos",
                    Values = new ChartValues<int> {suspanded},
                    PushOut = 15,
                    DataLabels = true,
                    LabelPoint = labelpoint
                },
                new PieSeries {
                    Title = "Proyectos Completados",
                    Values = new ChartValues<int> {completed},
                    PushOut = 15,
                    DataLabels = true,
                    LabelPoint = labelpoint
                }
            };

            mainChart.LegendLocation = LegendLocation.Bottom;
        }
    }
}
