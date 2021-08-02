/**
  * File: Program.cs
  *
  * Author:  Timothy B. Finn (tbf.lodi@gmail.com)
  * Date:     Spring 2021
  * Project:   Portfolio Project
  *
  * Summary of File:
  *     Client component
  *
  *
  */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlanManagerCSharp;
using RobotManagerCSharp;
using DetectorManagerCSharp;
using RunManagerCSharp;
using DBManagerCSharp;


namespace PortfolioSolutionCSharp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            m_model = new Model();

            m_viewModel = new ViewModel();

            m_controller = new Controller(
                m_model,
                m_planmanager,
                m_robotmanager,
                m_detectormanager,
                m_runmanager,
                m_dbmanager);


            Application.Run(new InstrumentationPortfolio());



        }
        #region Constructors

        #endregion
        #region Properties

        #endregion
        #region Methods

        #endregion
        #region Events

        #endregion
        #region Event Handlers

        #endregion
        #region Functions

        #endregion
        #region Fields

        #endregion
        #region Attributes
        // injecting MVC components

        static IModel m_model = new Model();
        static IViewModel m_viewModel = new ViewModel();
        static IController m_controller = new Controller();

        // injecting external libraries

        static IPlanManager m_planmanager = new PlanManager();
        static IRobotManager m_robotmanager = new RobotManager();
        static IDetectorManager m_detectormanager = new DetectorManager();
        static IRunManager m_runmanager = new RunManager();
        static IDBManager m_dbmanager = new DBManager();

        #endregion
    }
}
