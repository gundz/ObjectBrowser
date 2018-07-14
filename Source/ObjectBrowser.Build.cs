// Copyright 1998-2015 Epic Games, Inc. All Rights Reserved.

namespace UnrealBuildTool.Rules
{
	public class ObjectBrowser : ModuleRules
	{
        public ObjectBrowser(ReadOnlyTargetRules Target)
            : base(Target)
        {
			PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

			PrivateIncludePaths.AddRange(
				new string[] {
					"Private",
				});

			PublicDependencyModuleNames.AddRange(
				new string[] {
					"Core",
				}
			);

			PrivateDependencyModuleNames.AddRange(
				new string[] {
					"CoreUObject",
					"EditorStyle",
					"Engine",
					"InputCore",
					"Slate",
					"SlateCore",
					"UnrealEd",
                    "ClassViewer",
                    "PropertyEditor",
					"WorkspaceMenuStructure"
				}
			);
		}
	}
}
