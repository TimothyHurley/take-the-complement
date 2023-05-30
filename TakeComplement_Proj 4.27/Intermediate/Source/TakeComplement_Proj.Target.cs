using UnrealBuildTool;

public class TakeComplement_ProjTarget : TargetRules
{
	public TakeComplement_ProjTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("TakeComplement_Proj");
	}
}
