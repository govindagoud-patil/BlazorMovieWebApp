using System.ComponentModel.DataAnnotations;

namespace Movies_BlazorWASM.Entities
{
    public class Movie
    {
        public int Id { get; set; }
        public  string Title { get; set; }
        public  string Description { get; set; }
        public  string Category { get; set; }

        [DataType(DataType.Date)]
        public DateTime? ReleaseDate { get; set; }
        public decimal Price { get; set; }

    }
}
