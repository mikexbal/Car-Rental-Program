using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace CarRentalProgram
{
    internal class InventoryManagement
    {
        // Connection string to the database
        private string strConnection;
        private OleDbConnection connection;
        private Car car;

        // Constructor that initializes the connection string
        public InventoryManagement()
        {
            strConnection = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
                            @"Data Source=C:\Mac\Home\Downloads\CarRental.accdb;" +
                            "Persist Security Info=False;";
            connection = new OleDbConnection(strConnection);
        }

        // Method to open the database connection
        internal void OpenConnection()
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open();
                    Console.WriteLine("Connection opened successfully!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error opening connection: " + ex.Message);
            }
        }

        // Method to close the database connection
        internal void CloseConnection()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                    Console.WriteLine("Connection closed successfully!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error closing connection: " + ex.Message);
            }
        }

        // Method to get Data from DB
        internal DataTable GetInventory()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT * FROM Cars"; // Replace with your table name or query

            try
            {
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, connection);
                dataAdapter.Fill(dataTable);
                Console.WriteLine($"Fetched {dataTable.Rows.Count} rows from the database.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error fetching inventory: " + ex.Message);
            }

            return dataTable;
        }

        // Method to add a car to the database
        internal void AddCar(Car car)
        {

            connection = new OleDbConnection(strConnection);
           

            string query = "INSERT INTO Cars (VIN, Manufacturer, Model, CarYear, Mileage, RentalCost, " +
                           "Description, Location, Availability, Classification, Image) " +
                           "VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";
           
            using (connection)
            {
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {

                    try
                    {
                        connection.Open();

                        command.Parameters.AddWithValue("?", car.VehicleID);
                        command.Parameters.AddWithValue("?", car.Manufacturer);
                        command.Parameters.AddWithValue("?", car.Model);
                        command.Parameters.AddWithValue("?", car.Year);
                        command.Parameters.AddWithValue("?", car.Mileage);
                        command.Parameters.AddWithValue("?", car.RentalCost);
                        command.Parameters.AddWithValue("?", car.Location);
                        command.Parameters.AddWithValue("?", car.Availability);
                        command.Parameters.AddWithValue("?", car.Classification);
                        command.Parameters.AddWithValue("?", car.Image);


                        command.ExecuteNonQuery();

                        MessageBox.Show("Car successfully added to the database.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    finally
                    {
                        CloseConnection();
                    }
                }
            }
        }

        internal void DeleteCar(Car car)
        {
            //Grab selected car from datagridview and pass it here
            //Query = DELETE FROM table_name WHERE condition;
            //DELETE FROM Cars WHERE VIN = (car.VehicleID)
            //MessageBox.Show("Car successfully removed)



        }

    }
}
