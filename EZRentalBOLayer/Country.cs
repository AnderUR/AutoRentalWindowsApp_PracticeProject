using EZRentalDALayer;
using System;
using System.Collections.Generic;
using System.IO;

namespace EZRentalBOLayer
{
    public class Country
    {
        #region "PUBLIC INSTANCE & STATIC PROPERTIES DECLRATIONS"
        public int CountryID { get; set; }
        public string CountryCode2 { get; set; }
        public string CountryCode3 { get; set; }
        public string CountryName { get; set; }
        public int NumericCode { get; set; }
        #endregion

        #region "CONSTRUCTORS, FINALIZER/DESTRUCTOR METHODS DECLARATIONS"
        public Country()
        {
            this.CountryID = 0;
            this.CountryCode2 = "";
            this.CountryCode3 = "";
            this.CountryName = "";
            this.NumericCode = 0;
        }

        public Country(int countryID, string countryCode2, string countryCode3, string countryName, int numericCode)
        {
            this.CountryID = countryID;
            this.CountryCode2 = countryCode2;
            this.CountryCode3 = countryCode3;
            this.CountryName = countryName;
            this.NumericCode = numericCode;
        }

        ~Country() { }
        #endregion

        #region "PUBLIC INSTANCE & STATIC METHODS"
        //Method writes all the object's data to a Network_Printer.txt file
        public void Print()
        {
            try
            {
                using (StreamWriter objPrinterFile = new StreamWriter("Network_Printer.txt", true))
                {
                    objPrinterFile.WriteLine("Country information: ");
                    objPrinterFile.WriteLine("Country ID = {0}", CountryID);
                    objPrinterFile.WriteLine("Country Code 2 = {0}", CountryCode2);
                    objPrinterFile.WriteLine("Country Code 3 = {0}", CountryCode3);
                    objPrinterFile.WriteLine("Country Name = {0}", CountryName);
                    objPrinterFile.WriteLine("Numeric Code = {0}", NumericCode);
                    objPrinterFile.WriteLine();

                    objPrinterFile.Close();
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine($"The file was not found: '{e}'");
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine($"The directory was not found: '{e}'");
            }
            catch (IOException e)
            {
                Console.WriteLine($"The file could not be opened: '{e}'");
            }
        }

        //Initiates the loading or fetching of this class' object from the Country DB table
        //Returns true if load successful, false otherwise
        public bool Load(int key)
        {
            return DALayer_Load(key);
        }

        //Initiates the inserting of a Country object to the USState DB table
        //Calls this class' DALayer_Insert method to do the work
        //Returns true if insert is successful, false otherwise
        public bool Insert()
        {
            return DALayer_Insert();
        }

        //Initiates the updating of a Country object in the USState DB table
        //Calls this class' DALayer_Update method to do the work
        //Returns true if update is successful, false otherwise
        public bool Update()
        {
            return DALayer_Update();
        }

        //Initiates the Deletion of a Country object in the USState DB table
        //Calls this class' DALayer_Delete method to do the work
        //Returns true if delete is successful, false otherwise
        public bool Delete(int key)
        {
            return DALayer_Delete(key);
        }

        //Initiates the loading or fetching of all countries from the Country table
        //Calls this class' GetAllCountrys method to do the work
        //Returns a list which contains all the Country Objects from the DB if successful, NULL otherwise
        public static List<Country> GetAllCountries()
        {
            return DALayer_GetAllCountries();
        }
        #endregion

        #region "PROTECTED INSTANCE METHODS"
        //Calls the data access layer to perform retreival of a Country record by key
        //Sets instance data in this class on success
        //returns true if successful, false otherwise

        protected bool DALayer_Load(int key)
        {
            try
            {
                DALObjectFactoryBase objSQLDAOFactory = DALObjectFactoryBase.GetDataSourceDAOFactory(DALObjectFactoryBase.SQLSERVER);
                CountryDAO objCountryDAO = objSQLDAOFactory.GetCountryDAO();
                CountryDTO objListCountryDTO = objCountryDAO.GetRecordByID(key);

                if(objListCountryDTO != null)
                {
                    Country objCountry = new Country();
                    objCountry.CountryID = objListCountryDTO.CountryID;
                    objCountry.CountryCode2 = objListCountryDTO.CountryCode2;
                    objCountry.CountryCode3 = objListCountryDTO.CountryCode3;
                    objCountry.CountryName = objListCountryDTO.CountryName;
                    objCountry.NumericCode = objListCountryDTO.NumericCode;
                }

                return false;
            }
            catch (Exception objE)
            {
                throw new Exception("Unexpected Error in Country DALayer_Country() Method: {0} " + objE.Message);
            }
        }

        //Calls the data access layer to perform insertion of a Country record using a CountryDTO object
        //returns true if successful, false otherwise

        protected bool DALayer_Insert()
        {
            try
            {
                DALObjectFactoryBase objSQLDAOFactory = DALObjectFactoryBase.GetDataSourceDAOFactory(DALObjectFactoryBase.SQLSERVER);
                CountryDAO objCountryDAO = objSQLDAOFactory.GetCountryDAO();
                CountryDTO objCountryDTO = new CountryDTO();

                objCountryDTO.CountryID = this.CountryID;
                objCountryDTO.CountryCode2 = this.CountryCode2;
                objCountryDTO.CountryCode3 = this.CountryCode3;
                objCountryDTO.CountryName = this.CountryName;
                objCountryDTO.NumericCode = this.NumericCode;

                bool inserted = objCountryDAO.Insert(objCountryDTO);

                if(inserted == true)
                {
                    return true;
                }

                return false;
            }
            catch (Exception objE)
            {
                throw new Exception("Unexpected Error in Country DALayer_Insert() Method: {0} " + objE.Message);
            }
        }

        //Calls the data access layer to perform an update of a Country record using a CountryDTO object
        //returns true if successful, false otherwise
        protected bool DALayer_Update()
        {
            try
            {
                DALObjectFactoryBase objSQLDAOFactory = DALObjectFactoryBase.GetDataSourceDAOFactory(DALObjectFactoryBase.SQLSERVER);
                CountryDAO objCountryDAO = objSQLDAOFactory.GetCountryDAO();
                CountryDTO objCountryDTO = new CountryDTO();

                objCountryDTO.CountryID = this.CountryID;
                objCountryDTO.CountryCode2 = this.CountryCode2;
                objCountryDTO.CountryCode3 = this.CountryCode3;
                objCountryDTO.CountryName = this.CountryName;
                objCountryDTO.NumericCode = this.NumericCode;

                bool inserted = objCountryDAO.Update(objCountryDTO);

                if (inserted == true)
                {
                    return true;
                }

                return false;
            }
            catch (Exception objE)
            {
                throw new Exception("Unexpected Error in Country DALayer_Insert() Method: {0} " + objE.Message);
            }
        }

        //Calls the data access layer to perform deletion of a Country record using a key
        //returns true if successful, false otherwise
        protected bool DALayer_Delete(int key)
        {
            try
            {
                DALObjectFactoryBase objSQLDAOFactory = DALObjectFactoryBase.GetDataSourceDAOFactory(DALObjectFactoryBase.SQLSERVER);
                CountryDAO objCountryDAO = objSQLDAOFactory.GetCountryDAO();

                bool deleted = objCountryDAO.Delete(key);

                if (deleted == true)
                {
                    return true;
                }

                return false;
            }
            catch (Exception objE)
            {

                throw new Exception("Unexpected Error in Country DALayer_Delete() Method: {0} " + objE.Message);
            }
        }

        //Initiates the data access process, calling the data access layer to retrieve all Country records from the DB
        //Returns a list which contains all the Country Objects from the DB if successful, NULL otherwise
        protected static List<Country> DALayer_GetAllCountries()
        {
            try
            {
                DALObjectFactoryBase objSQLDAOFactory = DALObjectFactoryBase.GetDataSourceDAOFactory(DALObjectFactoryBase.SQLSERVER);
                CountryDAO objCountryDAO = objSQLDAOFactory.GetCountryDAO();

                List<CountryDTO> objListCountryDTO = objCountryDAO.GetAllRecords();

                if (objListCountryDTO != null)
                {
                    List<Country> objListCountry = new List<Country>();

                    foreach (CountryDTO objCountryDTO in objListCountryDTO)
                    {
                        Country objCountry = new Country();

                        objCountry.CountryID = objCountryDTO.CountryID;
                        objCountry.CountryCode2 = objCountryDTO.CountryCode2;
                        objCountry.CountryCode3 = objCountryDTO.CountryCode3;
                        objCountry.CountryName = objCountryDTO.CountryName;
                        objCountry.NumericCode = objCountryDTO.NumericCode;

                        objListCountry.Add(objCountry);
                    }

                    return objListCountry;
                }

                return null;
            }
            catch (Exception objE)
            {

                throw new Exception("Unexpected Error in Country DALayer_GetAllCountries() Method: {0} " + objE.Message);
            }
        }
        #endregion
    }
}
