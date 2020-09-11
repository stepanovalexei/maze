using System.IO;
using System.Linq;
using DesperateDevs.CodeGeneration;
using DesperateDevs.Utils;
using Entitas;
using Entitas.CodeGeneration.Plugins;

namespace Editor.CustomGenerators
{
  public class SingleValueComponentEntityApiInterfaceGenerator : AbstractGenerator
  {
    public override string name => "Single Value Component (Entity API Interface)";

    private const string PropertyCode = "${PropertyCode}";
    private const string StandardProperty = "${ComponentType} ${validComponentName} { get; } \n";

    private const string StandardTemplate =
      @"public partial interface I${ComponentName}Entity<out TEntity> : Entitas.IEntity where TEntity : Entitas.IEntity 
{
    ${PropertyCode}
    bool has${ComponentName} { get; }
    TEntity Add${ComponentName}(${newMethodParameters});
    TEntity Replace${ComponentName}(${newMethodParameters});
    TEntity Remove${ComponentName}();
}
";

    const string FLAG_TEMPLATE =
      @"public partial interface I${ComponentName}Entity 
{
    bool ${prefixedComponentName} { get; set; }
}
";

    private const string ValueComponentInterfaceTemplate = "public partial class ${EntityType} : I${ComponentName}Entity<${EntityType}> { }\n";
    private const string FlagInterfaceTemplate = "public partial class ${EntityType} : I${ComponentName}Entity { }\n";

    public override CodeGenFile[] Generate(CodeGeneratorData[] data) =>
      data
        .OfType<ComponentData>()
        .Where(d => d.ShouldGenerateMethods())
        .Where(d => d.GetContextNames().Length > 1)
        .SelectMany(Generate)
        .ToArray();

    private CodeGenFile[] Generate(ComponentData data) =>
      new[] { GenerateInterface(data) }
        .Concat(data.GetContextNames().Select(contextName => GenerateEntityInterface(contextName, data)))
        .ToArray();

    private CodeGenFile GenerateInterface(ComponentData data)
    {
      string template = IsFlag(data)
        ? FLAG_TEMPLATE
        : StandardTemplate;

      return new CodeGenFile(
        "Components" + Path.DirectorySeparatorChar +
        "Interfaces" + Path.DirectorySeparatorChar +
        "I" + data.ComponentName() + "Entity.cs",
        ReplacePropertyIfSingleValue(template, data).Replace(data, string.Empty),
        GetType().FullName
      );
    }

    private static string ReplacePropertyIfSingleValue(string template, ComponentData data)
    {
      MemberData[] members = data.GetMemberData();
      if (!members.IsSingleValueComponent())
        return template.Replace(PropertyCode, StandardProperty);

      string modifiedProperty = $"{members[0].type} {data.ComponentName().UppercaseFirst()} {{ get; }} \n    {StandardProperty}";
      
      return template.Replace(PropertyCode, modifiedProperty);
    }

    private CodeGenFile GenerateEntityInterface(string contextName, ComponentData data) =>
      new CodeGenFile(
        contextName + Path.DirectorySeparatorChar +
        "Components" + Path.DirectorySeparatorChar +
        data.ComponentNameWithContext(contextName).AddComponentSuffix() + ".cs",
        ContentWithReplacements(contextName, data),
        GetType().FullName
      );

    private static string ContentWithReplacements(string contextName, ComponentData data)
    {
      return Template().Replace(data, contextName);

      string Template() => IsFlag(data)
          ? FlagInterfaceTemplate
          : ValueComponentInterfaceTemplate;
    }

    private static bool IsFlag(ComponentData data) => data.GetMemberData().Length == 0;
  }
}