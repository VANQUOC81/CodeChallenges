using Enums;

namespace CodeChallenges.Interfaces
{
    public interface ICodeChallenge
    {
        CodeChallengeSource CodeChallengeSource { get; }

        int CodeChallengeNumber { get; }

        string Execute();
    }
}