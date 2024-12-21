namespace Studentinfo.Models.ViewModel
{
    public class EditStudentRequest
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Department { get; set; }
        public string? Session { get; set; }
    }
}
