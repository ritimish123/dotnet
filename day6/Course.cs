using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagementSystem
{
    abstract class Course
    {
        string id;
        string name;
        string duration;
        float fees;
        int seatsavaialble;

        public Course() { }
        public Course(string id, string name, string duration, float fees, int seatsavaialble)
        {
            this.id = id;
            this.name = name;
            this.duration = duration;
            this.fees = fees;
            this.seatsavaialble = seatsavaialble;
        }

        public string CourseId
        {
            get { return id; }
            set { id = value; }
        }

        public string CourseName
        {
            get { return name; }
            set { name = value; }
        }

        public string CourseDuration
        {
            get { return duration; }
            set { duration = value; }
        }

        public int SeatsAvaialble
        {
            get { return seatsavaialble; }
            set { seatsavaialble = value; }
        }

        public float Fees
        {
            get { return fees; }
            set { fees = value; }
        }


        public abstract void calculateMonthlyFee();

    }

    class DegreeCourse : Course
    {
        public enum level
        {
            Bachelors,
            Masters
        }
        public level courseLevel;
        public bool active;
        public DegreeCourse(string id, string name, string duration, float fees, int seatsavaialble, level courseLevel, bool active) : base(id, name, duration, fees, seatsavaialble)
        {
            this.courseLevel = courseLevel;
            this.active = active;
            calculateMonthlyFee();
        }

        public override void calculateMonthlyFee()
        {
            this.Fees = this.Fees + ((this.Fees * 10) / 100);
            
        }

        public override string ToString()
        {
            return string.Format("\n" + CourseId + "\t" + CourseName + "\t\t" + CourseDuration + "\t" + Fees + "\t" + SeatsAvaialble + "\n");
        }

    }
    class DiplomaCourse : Course
    {
        public enum type
        {
            professional,
            academic
        }
        public type courseType;
        public DiplomaCourse(string id, string name, string duration,  float fees, int seats, type courseType) : base(id, name, duration, fees, seats)
        {
            this.courseType = courseType;
            calculateMonthlyFee();
        }
        
        public override void calculateMonthlyFee()
        {
            if(this.courseType == type.professional)
            {
                this.Fees = this.Fees + ((this.Fees * 10 )/100);
            }
            else
            {
                this.Fees = this.Fees + ((this.Fees * 5) / 100);
            }
        }

        public override string ToString()
        {
           
            return  string.Format("\n" + CourseId + "\t" + CourseName + "\t\t" + CourseDuration + "\t" + Fees + "\t" + SeatsAvaialble +"\n");
        }

    }

}
