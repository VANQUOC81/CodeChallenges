using Source.Enums;

namespace Source.Interfaces
{
    public interface ICodeChallenge
    {
        CodeChallengeSource CodeChallengeSource { get; }

        int CodeChallengeNumber { get; }

        string Execute();
    }
}