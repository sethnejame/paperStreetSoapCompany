using System;
using System.Collections.Generic;

namespace Common
{
  public static class StringHandler
  {
    public string InsertSpaces(string source)
    {
      string result = string.Empty;

      if (!String.IsNullOrWhiteSpace(source))
      {
        foreach (char letter in source)
        {
          if (char.IsUpper(letter))
          {
            result = result.Trim();
            result += " ";
          }
          result += letter;
        }
      }

      return result.TrimStart();
    }
  }
}