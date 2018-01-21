using System.Collections.Generic;

namespace _09.Teamwork_Projects
{
    public class Team
    {
        private string name;
        private string creatorName;
        private List<string> members;

        public Team()
        {
            this.Name = this.name;
            this.CreatorName = this.creatorName;
            this.Members = this.members;
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

        public string CreatorName
        {
            get
            {
                return this.creatorName;
            }
            set
            {
                this.creatorName = value;
            }
        }

        public List<string> Members
        {
            get
            {
                return this.members;
            }
            set
            {
                this.members = value;
            }
        }
    }
}