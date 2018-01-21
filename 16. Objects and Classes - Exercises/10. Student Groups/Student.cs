namespace _10.Student_Groups
{
    using System;

    public class Student
    {
        private string name;
        private string email;
        private DateTime registrationDate;

        public Student()
        {
            this.Name = this.name;
            this.Email = this.email;
            this.RegistrationDate = this.registrationDate;
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

        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                this.email = value;
            }
        }

        public DateTime RegistrationDate
        {
            get
            {
                return this.registrationDate;
            }
            set
            {
                this.registrationDate = value;
            }
        }
    }
}