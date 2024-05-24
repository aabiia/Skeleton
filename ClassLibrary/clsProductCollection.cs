using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace ClassLibrary
{
    public class clsProductCollection

    {

        List<clsStock> mProductList = new List<clsStock>();

        public List<clsStock> ProductList
        {
            get
            {
                return mProductList;
            }

            set
            {
                mProductList = value;
            }

        }

        public int Count
        {
            get
            {
                return mProductList.Count;
            }

            set
            {


            }

        }

        public clsStock ThisProduct { get; set; }

        public clsProductCollection()
        {
            // Call method to retrieve products from the database
            RetrieveProductsFromDatabase();
        }

        private void RetrieveProductsFromDatabase()
        {
            // Clear existing product list
            mProductList.Clear();

            // Connection string to the database
            string connectionString = "Data Source=v00egd00002l.lec-admin.dmu.ac.uk;User ID=p2750500;Password=teamskincare1001;Connect Timeout=30;Encrypt=True";

            // Stored procedure name
            string storedProcedure = "sproc_tblProduct_SelectAll"; // Assuming this is the stored procedure name

            // Create connection
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Create command
                using (SqlCommand command = new SqlCommand(storedProcedure, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    try
                    {
                        // Open connection
                        connection.Open();

                        // Execute the command
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Loop through the result set
                            while (reader.Read())
                            {
                                // Create new clsStock object for each record
                                clsStock product = new clsStock();

                                // Populate properties from database columns
                                product.Product_ID = Convert.ToInt32(reader["Product_ID"]);
                                product.Product_Name = reader["Product_Name"].ToString();
                                product.Prod_Description = reader["Prod_Description"].ToString();
                                product.Prod_Price = Convert.ToSingle(reader["Prod_Price"]);
                                product.Prod_Quantity = Convert.ToInt32(reader["Prod_Quantity"]);
                                product.Date_Added = Convert.ToDateTime(reader["Date_Added"]);
                                product.Supplier_ID = Convert.ToInt32(reader["Supplier_ID"]);

                                // Add product to the list
                                mProductList.Add(product);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // Handle exception (e.g., log error)
                        throw new Exception("Error retrieving products from database: " + ex.Message);
                    }
                }
            }
        }


    }


}
