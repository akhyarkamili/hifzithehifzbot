using System.Data;
using Domain.Common;
using static System.Enum;

namespace WebApi.Flows;

public class RegistrationFlow
{
    public RegistrationFlow(string name, Gender gender, RegistrationFlowState state)
    {
        Name = name;
        Gender = gender;
        State = state;
    }

    public string Handle(string message)
    {
        switch (State)
        {
            case RegistrationFlowState.Initial:
                State = RegistrationFlowState.NeedName;
                return "Hi! Welcome to Hifzi\nWhat's your name?";
            case RegistrationFlowState.NeedName:
                if (!String.IsNullOrEmpty(message))
                {
                    State = RegistrationFlowState.NeedGender;
                    Name = message;
                }
                return "What's your gender? Female/Male";
            case RegistrationFlowState.NeedGender:
                Gender gender;
                if (!TryParse(message, out gender))
                {
                    return $"Unrecognized gender: {message}, please type Female or Male.";
                }

                Gender = gender;
                State = RegistrationFlowState.GenderRetrievedAndRegistrationComplete;
                return "Registration successful!";
            case RegistrationFlowState.GenderRetrievedAndRegistrationComplete:
                return "Nothing to do right now...";
            default:
                return "Error. Unknown state!";
        }
    }
    
    public string Name { get; private set; }
    public Gender Gender { get; private set; }
    public RegistrationFlowState State { get; private set; }
}

public enum RegistrationFlowState
{
    Initial,
    NeedName,
    NeedGender,
    GenderRetrievedAndRegistrationComplete
}