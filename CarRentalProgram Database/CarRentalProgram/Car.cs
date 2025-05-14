using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalProgram
{
    //This class is the overall structure of our car objects
    public class Car
    { 
        //Private fields to protect the class
       private int vehicleID;
       private string manufacturer;
       private string model;
       private int year;
       private int mileage;
       private decimal rentalCost;
       private string description;
       private string location;
       private string availablility;
       private string classification;
       private string image;

        
        //Car Constructor to create Car object
        public Car(int vehicleID, string manufacturer, string model, int year, int mileage, decimal rentalCost, string description, string location, string availablility, string classification, string image)
        {
            this.vehicleID = vehicleID;
            this.manufacturer = manufacturer;
            this.model = model;
            this.year = year;
            this.mileage = mileage;
            this.rentalCost = rentalCost;
            this.description = description;
            this.location = location;
            this.availablility = availablility;
            this.classification = classification;
            this.image = image;
        }

        
        //Getters and setters to access our private fields

        public int VehicleID
        {
            get { return vehicleID; }
            set { vehicleID = value; }
        }
        public string Manufacturer
        {
            get { return manufacturer; }
            set { manufacturer = value; }
        }
        public string Model
        {
            get { return model;  }
            set { model = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public int Mileage
        {
            get { return mileage; }
            set { mileage = value; }
        }
        public decimal RentalCost
        {
            get { return rentalCost; }
            set { rentalCost = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public string Location
        {
            get { return location; }
            set { location = value; }
        }
        public string Availability
        {
            get { return availablility; }
            set { availablility = value; }
        }
        public string Classification
        {
            get { return classification; }
            set { classification = value; }
        }
        public string Image
        {
            get { return image; }
            set { image = value; }
        }

        //ToString method to modify how our car is dispalyed in string format
        public override string ToString()
        {
            return $"{vehicleID}, {manufacturer}, {model}, {year}, {mileage}, {rentalCost}, {description}, {location}, {availablility}, {classification}, {image}";
        }

    }
}
