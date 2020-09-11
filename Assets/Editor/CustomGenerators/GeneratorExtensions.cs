using System;
using System.IO;
using System.Linq;
using DesperateDevs.CodeGeneration;
using Entitas.CodeGeneration.Plugins;

namespace Editor.CustomGenerators
{
  public static class GeneratorExtensions
  {
    public static string ContextName(this CodeGenFile codeGenFile) =>
      codeGenFile.fileName.Contains(Path.DirectorySeparatorChar)
        ? codeGenFile.fileName.Substring(0, codeGenFile.fileName.IndexOf(Path.DirectorySeparatorChar))
        : "";

    public static bool IsSingleValueComponent(this MemberData[] members) =>
      members.Length == 1 &&
      string.Compare(members[0].name, "Value", StringComparison.InvariantCulture) == 0;
  }
}