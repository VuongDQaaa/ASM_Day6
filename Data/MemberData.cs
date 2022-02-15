using ASM_Day6.Models;
using ASM_Day6.Enum;
namespace ASM_Day6.Data
{
    public static class MemberData
    {
        public static List<Member> Members = new List<Member>
        {
             new Member(){
                    Id = 1,
                    FirstName = "Dao",
                    LastName = "Vuong1",
                    Gender = Gender.Male,
                    DateOfBirth = new DateTime(2000,3,29),
                    BirthPlace = "Ha Noi",
                    IsGraduated = false,
                },
                new Member(){
                    Id = 2,
                    FirstName = "Dao",
                    LastName = "Vuong2",
                    Gender = Gender.Female,
                    DateOfBirth = new DateTime(2001,3,29),
                    BirthPlace = "Lao Cai",
                    IsGraduated = false,
                },
                new Member(){
                    Id = 3,
                    FirstName ="Dao",
                    LastName = "Vuong3",
                    Gender = Gender.Other,
                    BirthPlace ="Lao Cai",
                    DateOfBirth = new DateTime(1998,2,12),
                },
                new Member(){
                    Id = 4,
                    FirstName = "Dao",
                    LastName = "Vuong4",
                    Gender = Gender.Male,
                    DateOfBirth = new DateTime(2001,3,29),
                    BirthPlace = "Ha Noi",
                    IsGraduated = false,
                },
        };
    }
}