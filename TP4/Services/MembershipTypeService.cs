using TP4.Models;
using TP4.Repositories;

namespace TP4.Services
{
    public class MembershipTypeService:IMembershipTypeService
    {
        private readonly IMembershipTypeRepository _membershipTypeRepository;

        public MembershipTypeService(IMembershipTypeRepository membershipTypeRepository)
        {
            _membershipTypeRepository = membershipTypeRepository;
        }
        public IEnumerable<MembershipType> GetAllMemebershipTypes()
        {
            return _membershipTypeRepository.GetAllMemebershipTypes();
        }


    }
}
