namespace MilkyProject.WebUI.Dtos.ProductDtos
{
    public class CreateProductDto
    {
       
        public string? ProductName { get; set; }
        public decimal OldPrice { get; set; }
        public decimal NewPrice { get; set; }
        public string? ImageUrl { get; set; }
        public bool Status { get; set; }
        public int? categoryId { get; set; }
    }
}

