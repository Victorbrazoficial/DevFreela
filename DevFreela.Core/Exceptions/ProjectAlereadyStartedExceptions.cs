
namespace DevFreela.Core.Exceptions
{
    public class ProjectAlereadyStartedExceptions : Exception
    {
        public ProjectAlereadyStartedExceptions() : base("Project is already in Started status.")
        {
            
        }
    }
}