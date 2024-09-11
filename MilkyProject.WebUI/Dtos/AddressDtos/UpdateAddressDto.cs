namespace MilkyProject.WebUI.Dtos.AddressDtos
{
    public class UpdateAddressDto
    {
        public int addressid { get; set; }
        public string addressdetail { get; set; }
        public string phone { get; set; }
        public string emailaddress { get; set; }
        public string weekdayBusinessHours { get; set; }
        public string weekendBusinessHours { get; set; }
    }
}
