using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCMS.Model
{
    public class Enrollment
    {
        private int courseid;
        private string title;
        private string description;
        private TimeSpan coursetime;
        private int capacity;

        public int CourseId { get { return courseid; } set { courseid = value; } }
        public string Title { get { return title; } set { title = value; } }
        public string Description { get { return description; } set { description = value; } }
        public int Capacity { get { return capacity; } set { capacity = value; } }

        public TimeSpan Coursetime { get { return coursetime; } set { coursetime = value; } }

        public Enrollment() { }

        public Enrollment(int courseid, string title, string description, TimeSpan coursetime, int capacity)
        {
            this.courseid = courseid;
            this.title = title;
            this.description = description;
            this.coursetime = coursetime;
            this.capacity = capacity;
        }
    }
}
