using System;
namespace indexerr
{
    public class Employee
    {
        //Declare the properties
        public int ID { get; set; }
        public string Name { get; set; }
        public string Job { get; set; }
        public double Salary { get; set; }


        //Initialize the properties through constructor
        public Employee(int ID, string Name, string Job, int Salary)
        {
            this.ID = ID;
            this.Name = Name;
            this.Job = Job;
            this.Salary = Salary;
     
        }

        public object this [int index]
        {
            //The get accessor is used for returning a value
            get
            {
                if (index == 0)
                    return ID;
                else if (index == 1)
                    return Name;
                else if (index == 2)
                    return Job;
                else if (index == 3)
                    return Salary;
                else
                    return null;
            }
            
            // The set accessor is used to assigning a value
            set
            {
                if (index == 0)
                    ID = Convert.ToInt32(value);
                else if (index == 1)
                    Name = value.ToString();
                else if (index == 2)
                    Job = value.ToString();
                else if (index == 3)
                    Salary = Convert.ToDouble(value);
            }
        }
    }
}