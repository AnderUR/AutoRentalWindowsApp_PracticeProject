
namespace EZRentalDALayer
{
    /*
     * Class used to create data transfer objects to tranmsit data bidrectionally between BOL and DAL 
     * on behalf of a USState class object
     */
    public class USStateDTO
    {
        public int StateID { get; set; }
        public string StateCode { get; set; }
        public string StateName { get; set; }
    }
}
