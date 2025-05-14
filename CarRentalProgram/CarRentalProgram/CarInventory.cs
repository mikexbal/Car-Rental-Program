
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
namespace CarRentalProgram
{

   public class CarInventory
   {
      //Private fields
      private List<Car> inventory = new List<Car>();
      private string filePath;

      //Access the txt file for the inventory
      public CarInventory()
      {
         filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "CarInventory.txt");
      }


        // Getter to access the inventory
        public List<Car> Inventory
        {
            get { return inventory; }
        }

        //Method to add cars to inventory
        public void AddCar(Car car)
        {
            inventory.Add(car);
        }

        //Method to remove cars from inventory !!NEVER USED!!
        public void RemoveCar(Car car)
        {
            inventory.Remove(car);
        }

        //Method to get cars listed available
        public List<Car> AvailableCars()
        {
            return inventory.FindAll(car => car.IsAvailable);
        }

        //Method to get cars listed rented cars
        public List<Car> RentedCars()
        {
            return inventory.FindAll(car => !car.IsAvailable); 
        }

        //Method to save inventory to txt file
        public void SaveInventory()
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var car in inventory)
                {
                    writer.WriteLine(car.ToString());
                }
            }
        }

        //Method to load inventory from txt file and load in listview
        public void LoadInventory()
        {
            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);
                inventory = lines.Select(Car.FromFile).ToList();
            }
        }
    }


}

