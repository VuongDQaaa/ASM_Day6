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