using EZRentalDALayer;
using System;
using System.Collections.Generic;
using System.IO;

namespace EZRentalBOLayer
{
    public class USState
    {

        #region "PUBLIC INSTANCE & STATIC PROPERTIES DECLRATIONS"
        public int StateID { get; set; }
        public string StateCode { get; set; }
        public string StateName { get; set; }
        #endregion

        #region "CONSTRUCTORS, FINALIZER/DESTRUCTOR METHODS DECLARATIONS"
        public USState()
        {
            this.StateID = 0;
            this.StateCode = "";
            this.StateName = "";
        }

        public USState(int stateID, string stateCode, string stateName)
        {
            this.StateID = stateID;
            this.StateCode = stateCode;
            this.StateName = stateName;
        }

        ~USState() { }
        #endregion

        #region "PUBLIC INSTANCE & STATIC METHODS"
        //Method writes all the object's data to a Network_Printer.txt file
        public void Print()
        {            
            try
            {
                using (StreamWriter objPrinterFile = new StreamWriter("Network_Printer.txt", true))
                {
                    objPrinterFile.WriteLine("US State information: ");
                    objPrinterFile.WriteLine("US State ID = {0}", StateID);
                    objPrinterFile.WriteLine("US State Code = {0}", StateCode);
                    objPrinterFile.WriteLine("US State Name = {0}", StateName);
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

        //Initiates the loading or fetching of this class' object from the USState DB table
        //Returns true if load successful, false otherwise
        public bool Load(int key)
        { 
            return DALayer_Load(key);
        }

        //Initiates the inserting of a USState object to the USState DB table
        //Calls this class' DALayer_Insert method to do the work
        //Returns true if insert is successful, false otherwise
        public bool Insert()
        {
            return DALayer_Insert();
        }

        //Initiates the updating of a USState object in the USState DB table
        //Calls this class' DALayer_Update method to do the work
        //Returns true if update is successful, false otherwise
        public bool Update()
        {
            return DALayer_Update();
        }

        //Initiates the Deletion of a USState object in the USState DB table
        //Calls this class' DALayer_Delete method to do the work
        //Returns true if delete is successful, false otherwise
        public bool Delete(int key)
        {
            return DALayer_Delete(key); 
        }

        //Initiates the loading or fetching of all the US States from the USState DB table
        //Calls this class' DALayer_GetAllUSStates method to do the work
        //Returns a list which contains all the USState Objects from the DB if successful, NULL otherwise
        public static List<USState> GetAllUSStates()
        {
            return DALayer_GetAllUSStates();
        }
        #endregion

        #region "PROTECTED INSTANCE METHODS"
        //Calls the data access layer to perform retreival of a USState record by key
        //Sets instance data in this class on success
        //returns true if successful, false otherwise
        protected bool DALayer_Load(int key)
        {
            try
            {
                DALObjectFactoryBase objSQLDAOFactory = DALObjectFactoryBase.GetDataSourceDAOFactory(DALObjectFactoryBase.SQLSERVER);
                USStateDAO objUSStateDAO = objSQLDAOFactory.GetUSStateDAO();
                USStateDTO objUSStateDTO = objUSStateDAO.GetRecordByID(key);
                
                if(objUSStateDTO != null)
                {
                    this.StateID = objUSStateDTO.StateID;
                    this.StateCode = objUSStateDTO.StateCode;
                    this.StateName = objUSStateDTO.StateName;

                    return true;
                } else
                {
                    return false;
                }
            }
            catch (Exception objE)
            {
                throw new Exception("Unexpected Error in DALayer_Load(key) Method: {0} " + objE.Message);
            }
        }

        //Calls the data access layer to perform insertion of a USState record using a USStateDTO object
        //returns true if successful, false otherwise
        protected bool DALayer_Insert()
        {
            try
            {
                DALObjectFactoryBase objSQLDAOFactory = DALObjectFactoryBase.GetDataSourceDAOFactory(DALObjectFactoryBase.SQLSERVER);
                USStateDAO objUSStateDAO = objSQLDAOFactory.GetUSStateDAO();
                USStateDTO objUSStateDTO = new USStateDTO();

                objUSStateDTO.StateID = this.StateID;
                objUSStateDTO.StateCode = this.StateCode;
                objUSStateDTO.StateName = this.StateName;

                bool inserted = objUSStateDAO.Insert(objUSStateDTO);

                if (inserted == true)
                {
                    return true;
                } else
                {
                    return false;
                }
            } catch (Exception objE)
            {
                throw new Exception("Unexpected Error in DALayer_Insert() Method: {0} " + objE.Message);
            }
        }

        //Calls the data access layer to perform an update of a USState record using a USStateDTO object
        //returns true if successful, false otherwise
        protected bool DALayer_Update()
        {
            try
            {
                DALObjectFactoryBase objSQLFactory = DALObjectFactoryBase.GetDataSourceDAOFactory(DALObjectFactoryBase.SQLSERVER);
                USStateDAO objUSStateDAO = objSQLFactory.GetUSStateDAO();
                USStateDTO objUSStateDTO = new USStateDTO();

                objUSStateDTO.StateID = this.StateID;
                objUSStateDTO.StateCode = this.StateCode;
                objUSStateDTO.StateName = this.StateName;

                bool updated = objUSStateDAO.Update(objUSStateDTO);

                if(updated == true)
                {
                    return true;
                } else
                {
                    return false;
                }
            } catch (Exception objE)
            {
                throw new Exception("Unexpected Error in DALayer_Update() Method: {0} " + objE.Message);
            }
        }

        //Calls the data access layer to perform deletion of a USState record using a key
        //returns true if successful, false otherwise
        protected bool DALayer_Delete(int key)
        {
            try
            {
                DALObjectFactoryBase objSQLDAOFactory = DALObjectFactoryBase.GetDataSourceDAOFactory(DALObjectFactoryBase.SQLSERVER);
                USStateDAO objUSStateDAO = objSQLDAOFactory.GetUSStateDAO();

                bool Deleted = objUSStateDAO.Delete(key);

                if (Deleted == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception objE)
            {
                throw new Exception("Unexpected Error in DALayer_Insert() Method: {0} " + objE.Message);
            }
        }

        //Initiates the data access process, calling the data access layer to retrieve all USStates records from the DB
        //Returns a list which contains all the USState Objects from the DB if successful, NULL otherwise
        protected static List<USState> DALayer_GetAllUSStates()
        {
            try
            {
                DALObjectFactoryBase objSQLDAOFactory = DALObjectFactoryBase.GetDataSourceDAOFactory(DALObjectFactoryBase.SQLSERVER);
                USStateDAO objUSStateDAO = objSQLDAOFactory.GetUSStateDAO();
                List<USStateDTO> objListUSStateDTO = objUSStateDAO.GetAllRecords();

                if(objListUSStateDTO != null)
                {
                    List<USState> listUSState = new List<USState>();

                    foreach (USStateDTO objUSStateDTO in objListUSStateDTO)
                    {
                        USState objUSState = new USState();

                        objUSState.StateID = objUSStateDTO.StateID;
                        objUSState.StateCode = objUSStateDTO.StateCode;
                        objUSState.StateName = objUSStateDTO.StateName;

                        listUSState.Add(objUSState);
                    }

                    return listUSState;
                } 

                return null;

                
            } catch (Exception objE)
            {
                throw new Exception("Unexpected Error in DALayer_GetAllUSStates() Method: {0} " + objE.Message);
            }
        }
        #endregion
    }
}
