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
        [Required(ErrorMessage = "Il campo è obbligatorio.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Il campo è obbligatorio.")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Il campo è obbligatorio.")]
        [Range(0, double.MaxValue, ErrorMessage = "Il prezzo non può essere negativo.")]
        [Column(TypeName = "decimal(18, 2)")]
        public double Price { get; set; }
        [Required(ErrorMessage = "Il campo è obbligatorio.")]
        public string PictureUrl { get; set; }


    }
}
