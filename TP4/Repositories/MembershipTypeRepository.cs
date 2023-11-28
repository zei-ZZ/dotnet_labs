using TP4.Models;

namespace TP4.Repositories
{
    public class MembershipTypeRepository:IMembershipTypeRepository
    {
        private readonly AppDbContext _dbContext;

        public MembershipTypeRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
       public IEnumerable<MembershipType> GetAllMemebershipTypes()
        {
            return _dbContext.MembershipTypes.ToList();
        }

    }
}
