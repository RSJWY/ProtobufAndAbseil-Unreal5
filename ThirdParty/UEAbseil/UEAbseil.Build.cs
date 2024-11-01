// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.IO;

public class UEAbseil : ModuleRules
{
	public UEAbseil(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
		Type = ModuleType.External;
		if (Target.Platform == UnrealTargetPlatform.Win64)
		{
			PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "include")); 
			PublicSystemIncludePaths.Add(Path.Combine(ModuleDirectory, "lib"));
			string[] LibFiles = Directory.GetFiles(Path.Combine(ModuleDirectory, "lib"), "*.lib");
			foreach (string LibFile in LibFiles)
			{ 
				// 添加每个库文件
				PublicAdditionalLibraries .Add(LibFile);
			}
		}
		

		ShadowVariableWarningLevel = WarningLevel.Off;
		bEnableUndefinedIdentifierWarnings = false;
		bEnableExceptions = true;
	}
}
