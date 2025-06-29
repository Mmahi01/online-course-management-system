using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCMS.Model
{
    public class Course
    {
        private int courseId;
        private string title;
        private string description;
        private int intructorid;
        private TimeSpan time;
        private int capacityLimit;


        public int CourseId { get { return courseId; } set { courseId = value; } }
        public string Title { get { return title; } set { title = value; } }
        public string Description { get { return description; } set { description = value; } }
        public int IntructorId { get {return intructorid; } set { intructorid = value; } }
        public TimeSpan Time { get { return time; } set { time = value; } }
        public int CapacityLimit { get { return capacityLimit; } set { capacityLimit = value; } }
        public Course() { }

        public Course(int courseId, string title, string description, int intructorid, TimeSpan time, int capacityLimit)
        {
            this.courseId = courseId;
            this.title = title;
            this.description = description;
            this.intructorid = intructorid;
            this.time = time;
            this.capacityLimit = capacityLimit;
        }
    }
}
