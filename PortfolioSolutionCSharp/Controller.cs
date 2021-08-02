/**
  * File: Controller.cs
  *
  * Author:  Timothy B. Finn (tbf.lodi@gmail.com)
  * Date:     Spring 2021
  * Project:   Portfolio Project
  *
  * Summary of File:
  *
  *
  *
  */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlanManagerCSharp;
using RobotManagerCSharp;
using DetectorManagerCSharp;
using RunManagerCSharp;
using DBManagerCSharp;

namespace PortfolioSolutionCSharp
{
    public class Controller : IController
    {
        //inject model
        #region Constructors
        public Controller()
        {

        }
        public Controller(
            IModel model,
            IPlanManager planManager,
            IRobotManager robotManager,
            IDetectorManager detectorManager,
            IRunManager runManager,
            IDBManager dbManager
            )
        {
            m_model = model;
            m_planmanager = planManager;
            m_robotmanager = robotManager;
            m_detectormanager = detectorManager;
            m_runmanager = runManager;
            m_dbmanager = dbManager;
        }
        ~Controller()
        {

        }
        #endregion
        #region Properties

        #endregion
        #region Methods
        public bool LoadPlanView()
        {
            try
            {
                //	cast plan manager to class from void so I can use it.

                //IModel* model = (IModel*)m_model;
                //bool flag = model->LoadPlans();

                bool flag = m_model.LoadPlans();

                return true;
            }
            catch (Exception e)
            {
                return false;

            }
        }

        public bool LoadRobotView()
        {
            try
            {
                //	cast plan manager to class from void so I can use it.

                //IModel* model = (IModel*)m_model;
                //bool flag = model->LoadPlans();

                bool flag = m_model.LoadRobots();

                return true;
            }
            catch (Exception e)
            {
                return false;

            }
        }

        public bool LoadDetectorView()
        {
            try
            {
                //	cast plan manager to class from void so I can use it.

                //IModel* model = (IModel*)m_model;
                //bool flag = model->LoadPlans();

                bool flag = m_model.LoadDetectors();

                return true;
            }
            catch (Exception e)
            {
                return false;

            }
        }
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
        IModel m_model = null;
        IPlanManager m_planmanager = null;
        IRobotManager m_robotmanager = null;
        IDetectorManager m_detectormanager = null;
        IRunManager m_runmanager = null;
        IDBManager m_dbmanager = null;
        #endregion

    }
}
