using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalProgram
{
   internal class CarRental
   {
     
      //private fields
      private Car car;
      private Customer customer;
      private DateTime rentalTime;
      private int days;

        //Constructuor to create rental object
        public CarRental(Car car, Customer customer, DateTime rentalTime, int days)
        {
            this.car = car;
            this.customer = customer;
            this.rentalTime = rentalTime;
            this.days = days;
        }

       //Fields to calcualte total cost
        public (decimal totalCost, decimal subtotal, decimal rentalTax, decimal stateSalesTax, decimal surcharge) CalculateTotal()
        {
            //Grab the Rental cost from object
            decimal rentalCostPerDay = car.RentalCost;

            //Calculate subtotal from rentalCost * amount of days
            decimal subtotal = rentalCostPerDay * days;

            //Calcualte the amount of taxes + daily surcharge
            decimal rentalTax = Math.Round(subtotal * 0.08875m, 2); 
            decimal stateSalesTax = Math.Round(subtotal * 0.04m, 2); 
            decimal surcharge = Math.Round(1.50m * days, 2); 

            //Calculate the total cost
            decimal totalCost = Math.Round(subtotal + rentalTax + stateSalesTax + surcharge, 2);

            return (totalCost, subtotal, rentalTax, stateSalesTax, surcharge); 
        }

    }
}
