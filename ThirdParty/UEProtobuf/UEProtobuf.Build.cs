// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.IO;

public class UEProtobuf : ModuleRules
{
	public UEProtobuf(ReadOnlyTargetRules Target) : base(Target)
	{
		/*Type = ModuleType.External;
		PublicSystemLibraryPaths.Add(Path.Combine(ModuleDirectory, "lib"));
		
		PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "include"));
		
		string[] LibFiles = Directory.GetFiles(Path.Combine(ModuleDirectory, "lib"), "*.lib");
		foreach (string LibFile in LibFiles)
		{
			// 添加每个库文件
			PublicSystemLibraries .Add(LibFile);
		}
		
		PublicDefinitions.Add("GOOGLE_PROTOBUF_INTERNAL_DONATE_STEAL_INLINE=0");
		PublicDefinitions.Add("PROTOBUF_BUILTIN_ATOMIC=0");*/
		
		PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;
		Type = ModuleType.External;
		if (Target.Platform == UnrealTargetPlatform.Win64)
		{
			PublicSystemIncludePaths.Add(Path.Combine(ModuleDirectory, "include"));
			PublicSystemIncludePaths.Add(Path.Combine(ModuleDirectory, "lib"));
			PublicAdditionalLibraries.Add(Path.Combine(ModuleDirectory, "lib", "libprotobuf.lib"));
		}

		ShadowVariableWarningLevel = WarningLevel.Off;
		bEnableUndefinedIdentifierWarnings = false;
		bEnableExceptions = true;
		PublicDefinitions.Add("_CRT_SECURE_NO_WARNINGS");
		PublicDefinitions.Add("GOOGLE_PROTOBUF_NO_RTTI=1");
		PublicDefinitions.Add("GOOGLE_PROTOBUF_CMAKE_BUILD");
		PublicDefinitions.Add("PROTOBUF_ENABLE_DEBUG_LOGGING_MAY_LEAK_PII=0");
		PublicDefinitions.Add("PROTOBUF_BUILTIN_ATOMIC=0");

	}
}
