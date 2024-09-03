namespace MilkyProject.WebUI.Dtos.ContactDtos
{
    public class UpdateContactDto
    {
        public int contactID { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string subject { get; set; }
        public string message { get; set; }
    }
}
