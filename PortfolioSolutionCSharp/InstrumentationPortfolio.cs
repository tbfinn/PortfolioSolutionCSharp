using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace PortfolioSolutionCSharp
{
    public partial class InstrumentationPortfolio : Form
    {
        public InstrumentationPortfolio()
        {
            InitializeComponent();
            PlanView f2 = new PlanView();
            f2.Show(dockPanel1, DockState.DockLeft);
            RobotView f3 = new RobotView();
            f3.Show(dockPanel1, DockState.DockLeft);
            DetectorView f4 = new DetectorView();
            f4.Show(dockPanel1, DockState.DockLeft);
            PropertiesWindow f5 = new PropertiesWindow();
            f5.Show(dockPanel1, DockState.DockRight);
            MainWindow1 f6 = new MainWindow1();
            f6.Show(dockPanel1, DockState.Document);
            MainWindow2 f7 = new MainWindow2();
            f7.Show(dockPanel1, DockState.Document);
            Output f8 = new Output();
            f8.Show(dockPanel1, DockState.DockBottom);
        }

        private void OnClick(object sender, EventArgs e)
        {
            if (sender.Equals(loadPlansToolStripMenuItem))
            {
                // Controller -> LoadPlanView
            }
            if (sender.Equals(loadRobotsToolStripMenuItem))
            {
                // Controller -> LoadRobotView

            }
            if (sender.Equals(loadDetectorsToolStripMenuItem))
            {
                // Controller -> LoadDetectorView

            }
        }
    }
}
