/**
  * File: IModel.cs
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
using System.Text;
using System.Threading.Tasks;

namespace PortfolioSolutionCSharp
{
    public interface IModel
    {
        #region Constructors

        #endregion
        #region Properties
        //virtual int get_PlanCount(void) = 0;
        //virtual DataLibrary::CPlan get_Plan(int index) = 0;

        //virtual int get_RobotCount(void) = 0;
        //virtual DataLibrary::CRobot get_Robot(int index) = 0;

        //virtual int get_DetectorCount(void) = 0;
        //virtual DataLibrary::CDetector get_Detector(int index) = 0;

        //virtual bool get_Dirty(void) = 0;
        //virtual void set_Dirty(bool) = 0;

        int PlanCount
        {
            get; set;
        }
        //public CommonDataLibrary::Plan Plan
        //{
        //    get; set;
        //}
        int RobotCount
        {
            get; set;
        }
        //public CommonDataLibrary::Robot Robot
        //{
        //    get; set;
        //}
        int DetectorCount
        {
            get; set;
        }
        //public CommonDataLibrary::Detector Detector
        //{
        //    get; set;
        //}
        bool Dirty
        {
            get; set;
        }
        #endregion
        #region Methods
        bool LoadPlans();
        bool LoadRobots();
        bool LoadDetectors();
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

        #endregion

    }
}
