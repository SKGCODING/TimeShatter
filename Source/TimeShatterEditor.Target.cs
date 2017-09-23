// Distribution of the game is totally forbiden, for remakes and fanmades, please, ask the author

using UnrealBuildTool;
using System.Collections.Generic;

public class TimeShatterEditorTarget : TargetRules
{
	public TimeShatterEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;

		ExtraModuleNames.AddRange( new string[] { "TimeShatter" } );
	}
}
