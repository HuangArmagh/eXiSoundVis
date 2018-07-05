using UnrealBuildTool;
using System.IO;

public class eXiSoundVis : ModuleRules
{
	public eXiSoundVis(ReadOnlyTargetRules Target) : base(Target)
	{
		PrivateIncludePaths.AddRange(new string[] {	"eXiSoundVis/Private" });
		PublicIncludePaths.AddRange(new string[] { "eXiSoundVis/Public" });

		PublicDependencyModuleNames.AddRange(new string[] { "Engine", "Core", "CoreUObject", "InputCore", "RHI", "Kiss_FFT" });

        if (Target.Platform == UnrealTargetPlatform.Win64 || Target.Platform == UnrealTargetPlatform.Win32)
        {
            PublicAdditionalLibraries.Add("legacy_stdio_definitions.lib");
        }
		AddEngineThirdPartyPrivateStaticDependencies(Target, new string[]{"Kiss_FFT"});
        //AddThirdPartyPrivateStaticDependencies(Target, "Kiss_FFT");
	}
}
