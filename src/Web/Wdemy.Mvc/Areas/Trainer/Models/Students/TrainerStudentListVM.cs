using Wdemy.Domain.Enums;

namespace Wdemy.Mvc.Areas.Trainer.Models.Students
{
    public class TrainerStudentListVM
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string FullName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public string? Image { get; set; }
    }
}
