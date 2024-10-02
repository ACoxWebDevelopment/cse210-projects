using System.ComponentModel.DataAnnotations;

public class PromptGenerator
{
    public List<string> _promptList;

    public string GeneratePrompt(List<string> _promptList)
    {
      Random rnd = new Random ();
      int prompt = rnd.Next(0,_promptList.Count);
      return _promptList[prompt];  
    }
}