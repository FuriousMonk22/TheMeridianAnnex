// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class TheMeridian : ModuleRules
{
	public TheMeridian(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"TheMeridian",
			"TheMeridian/Variant_Platforming",
			"TheMeridian/Variant_Platforming/Animation",
			"TheMeridian/Variant_Combat",
			"TheMeridian/Variant_Combat/AI",
			"TheMeridian/Variant_Combat/Animation",
			"TheMeridian/Variant_Combat/Gameplay",
			"TheMeridian/Variant_Combat/Interfaces",
			"TheMeridian/Variant_Combat/UI",
			"TheMeridian/Variant_SideScrolling",
			"TheMeridian/Variant_SideScrolling/AI",
			"TheMeridian/Variant_SideScrolling/Gameplay",
			"TheMeridian/Variant_SideScrolling/Interfaces",
			"TheMeridian/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
