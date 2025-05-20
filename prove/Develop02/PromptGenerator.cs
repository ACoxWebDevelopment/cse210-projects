using System.ComponentModel.DataAnnotations;

public class PromptGenerator
{
  public List<string> _prompts = new List<string>// creates a list of possible prompts

  {
  "What was the best part of my day?",
  "How did I see the hand of the Lord in my life today?",
  "What was the strongest emotion I felt today?",
  "Is there anything I would change about something I did or didn't do today?",
  "What was the least favorite part of my day?",
  "What did I do to brighten someone elses day?",
  "What will I do to make tomorrow even better?"
  
};
  public string GeneratePrompt()
  {
    Random rndm = new Random();
    int prompt = rndm.Next(_prompts.Count);
    return _prompts[prompt];
}
}