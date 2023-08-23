using Common.Enums;

namespace Common.Interfaces
{
    public interface ICodeChallenge
    {
        CodeChallengeSource CodeChallengeSource { get; }

        int CodeChallengeNumber { get; }

        // executes with input parameters identical to examples
        string Execute();
    }
}