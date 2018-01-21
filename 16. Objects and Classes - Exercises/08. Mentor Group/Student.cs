using System;
using System.Collections.Generic;

namespace _08.Mentor_Group
{
    public class Student
    {
        private string name;
        private List<string> comments;
        private List<DateTime> attendanceDates;

        public Student()
        {
            this.Name = this.name;
            this.Comments = this.comments;
            this.AttendanceDates = this.attendanceDates;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public List<string> Comments
        {
            get
            {
                return this.comments;
            }
            set
            {
                this.comments = value;
            }
        }

        public List<DateTime> AttendanceDates
        {
            get
            {
                return this.attendanceDates;
            }
            set
            {
                this.attendanceDates = value;
            }
        }
    }
}