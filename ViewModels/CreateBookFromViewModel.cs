namespace BookStore.ViewModels
{
    public class CreateBookFromViewModel
    {
        [Required]
        [StringLength(200)]
        public string Title { get; set; }

        [Required]
        [StringLength(13)]
        public string ISBN { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        public string Description { get; set; }

        public int StockQuantity { get; set; }

        [AllowedExtensions(FileSettings.AllowedExtensions),
            MaxFileSize(FileSettings.MaxFileSizeInBytes)]
        public IFormFile ImageUrl { get; set; }

        public DateTime PublishedDate { get; set; }

        public int Pages { get; set; }

        public string Language { get; set; } = "English";
		
        [Display(Name = "Category")]
        public int CategoryId { get; set; }

        public IEnumerable<SelectListItem> Categories { get; set; } = Enumerable.Empty<SelectListItem>();

        [Display(Name = "Authors")]
		public List<int> SelectedAuthors { get; set; } = new List<int>();

        public IEnumerable<SelectListItem> Authors { get; set; } = Enumerable.Empty<SelectListItem>();
        

	}
}
