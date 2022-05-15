using UnrealBuildTool;

public class ParkourGameTarget : TargetRules
{
	public ParkourGameTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("ParkourGame");
	}
}
