/**
  * File: Model.cs
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
using DBManagerCSharp;

namespace PortfolioSolutionCSharp
{
    public class Model : IModel
    {
        //inject viewmodel

        #region Constructors
        public Model()
        {

        }
        public Model(IViewModel viewModel, IDBManager dBManager)
        {
            m_viewModel = viewModel;

            m_dBManager = dBManager;

            //m_pDbManager = pDbManager;
            //OutputDebugStringW(L"SETTING UP TIMER\n");

            //m_timer.Tick += [this]() {
            //    m_counter++;
            //    if (m_dirty)
            //    {
            //        m_dirty = false;
            //        m_timer.Pause();
            //        OutputDebugStringW(L"CALLING REGISTERED CLIENT.\n");
            //        DataChange(m_counter);
            //        OutputDebugStringW(L"CALLED REGISTERED CLIENT.\n");
            //        m_timer.Resume();
            //    }
            //    OutputDebugStringW(L"TICK\n");
            //};
            //m_timer.Start(1000); // 1 seconds interval
        }
        ~Model()
        {
            //m_timer.Stop();

        }
        #endregion
        #region Properties
        public int PlanCount
        {
            get; set;
        }
        public int RobotCount
        {
            get; set;
        }

        public int DetectorCount
        {
            get; set;
        }
        public bool Dirty
        {
            get; set;
        }



        #endregion
        #region Methods
        //bool Model::LoadPlans(void)
        //{
        //    bool rt = false;

        //    //	retrieve a list of plans in the database
        //    std::vector<DataLibrary::CPlan> p = static_cast<CDBManager*>(m_pDbManager)->QueryPlans();

        //    m_pPlans.clear();

        //    //	copy the list to a local container
        //    for (auto i = 0; i < static_cast<int>(p.size()); i++)
        //    {
        //        DataLibrary::CPlan plan(p[i]);
        //        m_pPlans.push_back(plan);
        //    }
        //    rt = m_dirty = true;
        //    return rt;
        //}

        public bool LoadPlans()
        {
            bool rt = false;

            // retrieve a list of plans in the database


            // copy the list to a local container

            rt = m_dirty = true;
            return rt;
        }
        //bool Model::LoadRobots(void)
        //{
        //    bool rt = false;

        //    //	retrieve a list of plans in the database
        //    std::vector<DataLibrary::CRobot> p = static_cast<CDBManager*>(m_pDbManager)->QueryRobots();

        //    m_pRobots.clear();

        //    //	copy the list to a local container
        //    for (auto i = 0; i < static_cast<int>(p.size()); i++)
        //    {
        //        DataLibrary::CRobot robot(p[i]);
        //        m_pRobots.push_back(robot);
        //    }
        //    rt = m_dirty = true;
        //    return rt;
        //}
        public bool LoadRobots()
        {
            return true;
        }
        //bool Model::LoadDetectors(void)
        //{
        //    bool rt = false;

        //    //	retrieve a list of plans in the database
        //    std::vector<DataLibrary::CDetector> p = static_cast<CDBManager*>(m_pDbManager)->QueryDetectors();

        //    m_pDetectors.clear();

        //    //	copy the list to a local container
        //    for (auto i = 0; i < static_cast<int>(p.size()); i++)
        //    {
        //        DataLibrary::CDetector detector(p[i]);
        //        m_pDetectors.push_back(detector);
        //    }
        //    rt = m_dirty = true;
        //    return rt;
        //}

        public bool LoadDetectors()
        {
            return true;
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
        IViewModel m_viewModel = null;

        IDBManager m_dBManager = null;

        bool m_dirty = false;

        #endregion
    }
}
