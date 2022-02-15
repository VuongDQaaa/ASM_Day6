using ASM_Day6.Models;
namespace ASM_Day6.Services
{
    public interface IMemberservice
    {
        List<Member> GetMaleMember();
        Member OldestMember();
        Tuple<List<Member>, List<Member>, List<Member>> GetMemberByYear(int year);
        List<Member> GetAllMember();
        List<Member> GetFullName();
        Member FindByID(int id);
        void AddMember(Member member);
        void UpdateMember(Member member);
        void DeleteMember(int id);
    }
}