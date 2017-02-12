using System.Runtime.Serialization;

namespace EmployeesService
{
    [DataContract]
    public class Employee
    {
        private int id;
        private string firstName;
        private string lastName;
        private string department;
        private int salary;
        private string city;
        private string telephone;

        [DataMember(Order = 1)]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        [DataMember(Order = 2)]
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        [DataMember(Order = 3)]
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        [DataMember(Order = 4)]
        public string Department
        {
            get { return department; }
            set { department = value; }
        }

        [DataMember(Order = 5)]
        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        [DataMember(Order = 6)]
        public string City
        {
            get { return city; }
            set { city = value; }
        }

        [DataMember(Order = 7)]
        public string Telephone
        {
            get { return telephone; }
            set { telephone = value; }
        }
    }
}
