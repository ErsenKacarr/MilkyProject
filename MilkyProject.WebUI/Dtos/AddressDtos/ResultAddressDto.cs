namespace MilkyProject.WebUI.Dtos.AddressDtos
{
    public class ResultAddressDto
    {
        public int addressId { get; set; }
        public string addressDetail { get; set; }
        public string phone { get; set; }
        public string emailAddress { get; set; }
        public string weekdayBusinessHours { get; set; }
        public string weekendBusinessHours { get; set; }
    }
}
