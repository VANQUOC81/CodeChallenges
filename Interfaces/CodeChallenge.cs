using Enums;

namespace CodeChallenges.Interfaces
{
    public interface ICodeChallenge
    {
        CodeChallengeSource CodeChallengeSource { get; }

        string Execute();
    }
}