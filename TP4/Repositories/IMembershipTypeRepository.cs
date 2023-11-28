using TP4.Models;

namespace TP4.Repositories
{
    public interface IMembershipTypeRepository
    {
        IEnumerable<MembershipType> GetAllMemebershipTypes();

    }
}
