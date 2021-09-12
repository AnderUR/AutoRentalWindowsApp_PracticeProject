namespace EZRentalDALayer
{
    /*
     * Class used to create data transfer objects to tranmsit data bidrectionally between BOL and DAL 
     * on behalf of a Country class object
     */
    public class CountryDTO
    {
        public int CountryID { get; set; }
        public string CountryCode2 { get; set; }
        public string CountryCode3 { get; set; }
        public string CountryName { get; set; }
        public int NumericCode { get; set; }
    }
}
