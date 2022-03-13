using API.DTOs;
using API.Enities;
using API.Interfaces;

namespace API.Data
{
    public class LikesRepository : ILikesRepository
    {
        private readonly DataContext _context;
        public LikesRepository(DataContext context)
        {
            _context = context;
        }

        public Task<UserLike> GetUserLike(int SourceUserId, int LikedUserId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<LikeDto>> GetUserLike(string predicate, int userId)
        {
            throw new NotImplementedException();
        }

        public Task<AppUser> GetUserWithLikes(int userId)
        {
            throw new NotImplementedException();
        }
    }
}