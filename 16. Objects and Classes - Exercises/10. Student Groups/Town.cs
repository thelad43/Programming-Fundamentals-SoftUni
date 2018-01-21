namespace _10.Student_Groups
{
    using System.Collections.Generic;

    public class Town
    {
        private string name;
        private int seatsCount;
        private List<Student> students;

        public Town()
        {
            this.Name = this.name;
            this.SeatsCount = this.seatsCount;
            this.Students = this.students;
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

        public int SeatsCount
        {
            get
            {
                return this.seatsCount;
            }
            set
            {
                this.seatsCount = value;
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