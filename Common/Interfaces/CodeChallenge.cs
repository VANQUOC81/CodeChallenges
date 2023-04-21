using Common.Enums;

namespace Common.Interfaces
{
    public interface ICodeChallenge
    {
        CodeChallengeSource CodeChallengeSource { get; }

        int CodeChallengeNumber { get; }

        string Execute();
    }
}