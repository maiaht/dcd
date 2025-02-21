using api.Models;

namespace api.Services
{
    public interface IProjectService
    {
        IEnumerable<Project> GetAll();
        Project GetProject(Guid projectId);
        void AddDrainageStrategy(Project project, DrainageStrategy drainageStrategy);

    }
}
