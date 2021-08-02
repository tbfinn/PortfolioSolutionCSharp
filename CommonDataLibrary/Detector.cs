using System;
using System.Collections.Generic;
using System.Text;

namespace CommonDataLibrary
{
    public class Detector
    {
        #region Constructors
        public Detector(string name, DateTime timestamp)
        {
            Name = name;
            Timestamp = timestamp;
        }
        #endregion
        #region Properties
        // implicit property set/get
        public string Name
        {
            get; set;
        }


        // explicit property set/get
        private DateTime m_timestamp;
        public DateTime Timestamp
        {
            get
            {
                return m_timestamp;
            }
            set
            {
                m_timestamp = value;
            }
        }
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

        #endregion
    }
}
