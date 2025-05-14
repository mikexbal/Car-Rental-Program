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
       private string vehicleID;
       private string manufacturer;
       private string model;
       private int year;
       private int mileage;
       private decimal rentalCost;
       private string description;
       private string location;
       private bool isAvailable;
       private string classification;
       private string image;

        
        //Car Constructor to create Car object
        public Car(string vehicleID, string manufacturer, string model, int year, int mileage, decimal rentalCost, string description, string location, bool isAvailable, string classification, string image)
        {
            this.vehicleID = vehicleID;
            this.manufacturer = manufacturer;
            this.model = model;
            this.year = year;
            this.mileage = mileage;
            this.rentalCost = rentalCost;
            this.description = description;
            this.location = location;
            this.isAvailable = isAvailable;
            this.classification = classification;
            this.image = image;
        }

        
        //Getters and setters to access our private fields

        public string VehicleID
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
        public bool IsAvailable
        {
            get { return isAvailable; }
            set { isAvailable = value; }
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
            return $"{vehicleID}, {manufacturer}, {model}, {year}, {mileage}, {rentalCost}, {description}, {location}, {IsAvailable}, {classification}, {image}";
        }

        //Method to return our car back to a string from the file
        public static Car FromFile(string carString)
        {
            
            string[] carData = carString.Split(',');
            //Split the car info into seperate strings

            //Creates the cars and allows us to load them back into inventory
            return new Car(
                vehicleID: carData[0].Trim(),                                
                manufacturer: carData[1].Trim(),                        
                model: carData[2].Trim(),                               
                year: int.Parse(carData[3]),                     
                mileage: int.Parse(carData[4]),                  
                rentalCost: decimal.Parse(carData[5]),          
                description: carData[6].Trim(),                         
                location: carData[7].Trim(),
                isAvailable: bool.Parse(carData[8]),             
                classification: carData[9].Trim(),                       
                image: carData[10].Trim()                               
            );
        }


    }
}
