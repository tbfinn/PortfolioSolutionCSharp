/**
  * File: IDBManager.cs
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
using CommonDataLibrary;

namespace DBManagerCSharp
{
    public interface IDBManager
    {
        #region Constructors

        #endregion
        #region Properties

        #endregion
        #region Methods
        //virtual std::vector<DataLibrary::CPlan> QueryPlans(void) = 0;
        //virtual std::vector<DataLibrary::CDetector> QueryDetectors(void) = 0;
        //virtual std::vector<DataLibrary::CRobot> QueryRobots(void) = 0;

        List<Plan> QueryPlans();
        List<Robot> QueryRobots();
        List<Detector> QueryDetectors();



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
