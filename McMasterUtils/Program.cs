using System;
using McMaster.Extensions.CommandLineUtils;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CommandLineUtils
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      var parameters = default(Parameters);
      using (var app = new Parameters())
      {
        app.ThrowOnUnexpectedArgument = false;
        app.HelpOption();
        app.OptionsComparison = StringComparison.InvariantCultureIgnoreCase;

        var result = app.Parse(args);
        System.Console.WriteLine($"App exection: {app.Execute(args)}");

        System.Console.WriteLine($"Port: {app.Port}");
        Console.WriteLine($"Parameters model (1): {Newtonsoft.Json.JsonConvert.SerializeObject(app.Options)}");
      }

      Console.WriteLine("---");
      Console.WriteLine($"Parameters model (2): {Newtonsoft.Json.JsonConvert.SerializeObject(parameters)}");
    }
  }

  internal class Parameters : CommandLineApplication
  {
    [Option("-debug|--debug")]
    public bool Debug { get; private set; }

    [Option("-info|--info", "Set info", CommandOptionType.SingleValue)]
    public string Info { get; private set; }

    [Option("-port|--port", "Set port", CommandOptionType.SingleValue)]
    public int Port { get; private set; }
  }

}
