using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalProgram
{
    public class Customer
    {

        //Private fields defining the Customer
        private string name;
        private string phoneNumber;
        private string email;
        private string licenseNumber;
        private string policyNumber;

        //Constructor to create customer object
        public Customer(string name, string phoneNumber, string email, string licenseNumber, string policyNumber)
        {
            this.name = name;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.licenseNumber = licenseNumber;
            this.policyNumber = policyNumber;
        }

        //Getters / Setters
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string LicenseNumber
        {
            get { return licenseNumber; }
            set { licenseNumber = value; }
        }

        public string PolicyNumber
        {
            get { return policyNumber; }
            set { policyNumber = value; }
        }

    }
}
