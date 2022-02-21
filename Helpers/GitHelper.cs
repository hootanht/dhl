using Dhl.Execs;

namespace Dhl.Helpers;
class GitHelper
{
    public static void AddGitToSolution(PromptModel model)
    {
        if (model.AddGit == true)
        {
            BashExec.Run("dotnet new gitignore");
            BashExec.Run("git init");
            BashExec.Run("git add *");
            BashExec.Run("git add .gitignore");
            BashExec.Run("git commit -m 'init.'");


            System.Console.WriteLine("Git initialized successfully.");
        }
    }
}