using Data.Contexts;
using Data.Entities;

namespace Data.Repositories
{
    public class ProjectRepository : BaseRepository<ProjectEntity> 
    {
        public ProjectRepository(DataContext context) : base(context)
        {
        }
    }
}