using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoursOfWorkLib
{
    public class TimeDataset
    {
        #region Constructors

        public TimeDataset()
        {

        }

        #endregion

        #region Properties

        private Int32 id;

        public Int32 Id
        {
            get { return id; }
            set { id = value; }
        }

        private Int32 calenderWeek;

        public Int32 CalenderWeek
        {
            get { return calenderWeek; }
            set { calenderWeek = value; }
        }

        private DateTime date;

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        private DateTime begin;

        public DateTime Begin
        {
            get { return begin; }
            set { begin = value; }
        }

        private DateTime end;

        public DateTime End
        {
            get { return end; }
            set { end = value; }
        }

        private TimeSpan totalTime;

        public TimeSpan TotalTime
        {
            get { return totalTime; }
            set { totalTime = value; }
        }

        private String comment;

        public String Comment
        {
            get { return comment; }
            set { comment = value; }
        }

        #endregion

        #region Methods

        #endregion
    }
}
