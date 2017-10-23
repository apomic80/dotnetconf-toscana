
public class ApiController
{
    private IMessages messages;

    public ApiController(IMessages messages)
  {
      this.messages = messages;
  }

    public string[] Dati()
    {
      return new []
      {
        this.messages.GetMessage1(),
        this.messages.GetMessage2()
      };

    }
}
