using CSharpFunctionalExtensions;

namespace Angor.Contexts.Funding.Projects.Domain;

public interface IProjectRepository
{
    Task<Result<Project>> Get(ProjectId id);
    Task<Result<IEnumerable<Project>>> GetAll(params ProjectId[] id);
    Task<Result<IList<Project>>> Latest();

    Task<Result<Maybe<Project>>> TryGet(ProjectId projectId);
}