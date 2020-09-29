namespace CoreCommunicationServer.InternalCommands.Interfaces
{
    public interface IAgent
    {
        List<string> Execute(string shPath, string repoPath);
        string ExecuteSingle(string shPath, string repoPath);
    }
}