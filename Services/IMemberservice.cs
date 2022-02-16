using ASM_Day6.Models;
namespace ASM_Day6.Services
{
    public interface IMemberservice
    {
        List<Member> GetAllMember();
        Member FindByID(int id);
        void AddMember(Member member);
        void UpdateMember(Member member);
        void DeleteMember(int id);
    }
}