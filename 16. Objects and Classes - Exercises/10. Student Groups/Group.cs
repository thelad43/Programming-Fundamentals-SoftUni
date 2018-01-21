namespace _10.Student_Groups
{
    using System.Collections.Generic;

    public class Group
    {
        private Town town;
        private List<Student> students;

        public Group()
        {
            this.Town = this.town;
            this.Students = this.students;
        }

        public Town Town
        {
            get
            {
                return this.town;
            }
            set
            {
                this.town = value;
            }
        }

        public List<Student> Students
        {
            get
            {
                return this.students;
            }
            set
            {
                this.students = value;
            }
        }
    }
}