namespace Studentinfo.Models.ViewModel
{
    public class AddStudentRequest
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Department { get; set; }
        public string? Session { get; set; }

        public string? Section { get; set; }

        public string? Gender { get; set; }

        public string? Address { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public IFormFile? ImageFile { get; set; }
    }
}
