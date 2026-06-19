// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class DevilInTheDungeon : ModuleRules
{
	public DevilInTheDungeon(ReadOnlyTargetRules Target) : base(Target)
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
			"DevilInTheDungeon",
			"DevilInTheDungeon/Variant_Platforming",
			"DevilInTheDungeon/Variant_Platforming/Animation",
			"DevilInTheDungeon/Variant_Combat",
			"DevilInTheDungeon/Variant_Combat/AI",
			"DevilInTheDungeon/Variant_Combat/Animation",
			"DevilInTheDungeon/Variant_Combat/Gameplay",
			"DevilInTheDungeon/Variant_Combat/Interfaces",
			"DevilInTheDungeon/Variant_Combat/UI",
			"DevilInTheDungeon/Variant_SideScrolling",
			"DevilInTheDungeon/Variant_SideScrolling/AI",
			"DevilInTheDungeon/Variant_SideScrolling/Gameplay",
			"DevilInTheDungeon/Variant_SideScrolling/Interfaces",
			"DevilInTheDungeon/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
