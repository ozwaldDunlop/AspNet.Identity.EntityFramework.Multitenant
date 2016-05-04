cls
del *.nupkg

c:\Windows\Microsoft.NET\Framework64\v4.0.30319\MSBuild.exe ..\AspNet.Identity.EntityFramework.Multitenant\AspNet.Identity.EntityFramework.Multitenant.csproj /p:Configuration=Release

nuget pack ..\AspNet.Identity.EntityFramework.Multitenant\AspNet.Identity.EntityFramework.Multitenant.csproj -Prop Configuration=Release -IncludeReferencedProjects
REM nuget push *.nupkg
