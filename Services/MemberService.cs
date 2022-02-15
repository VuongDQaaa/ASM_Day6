using ASM_Day6.Data;
using ASM_Day6.Models;
namespace ASM_Day6.Services
{
    public class MemberService : IMemberservice
    {
        public void AddMember(Member member)
        {
            MemberData.Members.Add(member);
        }
        private int GetIndexByID(int id)
        {
            var memberIndex = MemberData.Members.FindIndex(m => m.Id == id);
            return memberIndex;
        }
        public List<Member> GetAllMember()
        {
            return MemberData.Members;
        }
        public List<Member> GetFullName()
        {
            return MemberData.Members;
        }
        public List<Member> GetMaleMember()
        {
            return MemberData.Members.Where(m => m.Gender == Enum.Gender.Male).ToList();
        }
        public Tuple<List<Member>, List<Member>, List<Member>> GetMemberByYear(int year)
        {
            var lessThan2000 = MemberData.Members.Where(x => x.DateOfBirth.Year < year).ToList();
            var greaterThan2000 = MemberData.Members.Where(x => x.DateOfBirth.Year > year).ToList();
            var equalThan2000 = MemberData.Members.Where(x => x.DateOfBirth.Year == year).ToList();
            return Tuple.Create(lessThan2000, greaterThan2000, equalThan2000);
        }
        public Member OldestMember()
        {
            return MemberData.Members.MinBy(m => m.DateOfBirth.Year);
        }
        public void UpdateMember(Member member)
        {
            var memberIndex = GetIndexByID(member.Id);
            MemberData.Members[memberIndex] = member;
        }
        public Member FindByID(int id)
        {
            return MemberData.Members.Where(member => member.Id == id).FirstOrDefault();
        }
        public void DeleteMember(int id)
        {
            var memberIndex = GetIndexByID(id);
            MemberData.Members.RemoveAt(memberIndex);
        }
    }
}