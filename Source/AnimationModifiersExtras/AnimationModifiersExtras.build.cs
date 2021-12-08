using UnrealBuildTool;

public class AnimationModifiersExtras : ModuleRules
{
    public AnimationModifiersExtras(ReadOnlyTargetRules Target) : base(Target)
    {
        PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

        PublicDependencyModuleNames.AddRange(new string[] {
            "Core",
            "CoreUObject",
            "Engine",
            });
    }
}