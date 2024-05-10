

using System.Collections.Generic;

public class PromptGenerator
{

    public List<string> _prompts = new List<string>()
    {
        "What is the most imprtant thing you have done today?",
        "What is your favorite hobby?",
        "What is your favorite book?",
        "What is your favorite movie?",
        "What is your dream vacation destination?",
        "What is your favorite food?",
        "What is your profession?",
        "What is your favorite color?",
        "What is your favorite animal?",
        "What is your favorite song?",
        "What is your favorite band?",
        "What is your favorite TV show?",
        "What is your favorite sport?",
        "What is your favorite video game?",
        "What is your favorite board game?",
    };
    Random _randomPrompt = new Random();

    public string GetRandomPrompt()
    {
        //TO get the random prompt
        int _randomIndex = _randomPrompt.Next(0, _prompts.Count);

        string _randomPromptString = _prompts[_randomIndex];

        return _randomPromptString;
    }
}

