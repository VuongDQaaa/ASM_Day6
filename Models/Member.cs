using ASM_Day6.Enum;
namespace ASM_Day6.Models
{
    public class Member
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNum { get; set; }
        public string BirthPlace { get; set; }
        public bool IsGraduated { get; set; }
    }
}