namespace LaMiaPizzeriaEF.Models {
    public class Pizza {
        public Pizza(int id, string name, string description, double price, string pictureUrl) {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
            PictureUrl = pictureUrl;
        }

        public Pizza() { }

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string PictureUrl { get; set; }


    }
}
