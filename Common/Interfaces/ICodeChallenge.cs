using Common.Enums;

namespace Common.Interfaces
{
    public interface ICodeChallenge : IInputValues
    {
        CodeChallengeSource CodeChallengeSource { get; }

        int CodeChallengeNumber { get; }

        // executes with list of input parameters identical to examples
        string Execute(List<string> input);
    }
}