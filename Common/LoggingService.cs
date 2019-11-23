using System;
using System.Collections.Generic;

namespace Common
{
  public static class LoggingService
  {
    public static void WriteToFile(List<ILoggable> itemsToLog)
    {
      foreach (var item in itemsToLog)
      {
        Console.WriteLine(item.Log());
      }
    }
  }
}