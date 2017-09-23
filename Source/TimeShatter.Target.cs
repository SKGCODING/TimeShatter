// Distribution of the game is totally forbiden, for remakes and fanmades, please, ask the author

using UnrealBuildTool;
using System.Collections.Generic;

public class TimeShatterTarget : TargetRules
{
	public TimeShatterTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "TimeShatter" } );
	}
}
