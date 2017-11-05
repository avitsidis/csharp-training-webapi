using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.WebAPI.Models.Courses
{
    public class CourseApiModel
    {
        public int Id { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string Title { get; set; }

        [Range(0, 5)]
        public int Credits { get; set; }

        public int DepartmentId { get; set; }
    }
}
