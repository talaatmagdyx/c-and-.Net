# Configuration Notes

## Enabling a specific language version compiler

- you had to add a configuration element
to the project file, as shown in the following markup:
    `<LangVersion>7.3</LangVersion> --> 7.3 is version`
  - example go to file_name.csproj

    ```c#
        <Project Sdk="Microsoft.NET.Sdk">
        <PropertyGroup>
            <OutputType>Exe</OutputType>
            <TargetFramework>net5.0</TargetFramework>
            <RootNamespace>book_c_</RootNamespace>
            <LangVersion>preview</LangVersion> new line
        </PropertyGroup>
        </Project>
    ```

- Enabling nullable and non-nullable reference types
  - To disable the feature at the file level, add the following to the top of a code file: `#nullable disable` in file.cs
  - To enable the feature at the file level, add the following to the top of a code file:
    `#nullable enable`

```c#
<PropertyGroup>
    <Nullable>enable</Nullable>
</PropertyGroup
```

- Add Class form project to and project

```c#
<ItemGroup>
    <ProjectReference Include="../PacktLibrary/PacktLibrary.csproj" />
</ItemGroup>
```
