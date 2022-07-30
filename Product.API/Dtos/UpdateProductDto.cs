namespace Product.API.Dtos
{
    public class UpdateProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Cost { get; set; }
        public double Price { get; set; }
    }
}
