//
// By using or accessing the source codes or any other information of the Game SHADOWGUN: DeadZone ("Game"),
// you ("You" or "Licensee") agree to be bound by all the terms and conditions of SHADOWGUN: DeadZone Public
// License Agreement (the "PLA") starting the day you access the "Game" under the Terms of the "PLA".
//
// You can review the most current version of the "PLA" at any time at: http://madfingergames.com/pla/deadzone
//
// If you don't agree to all the terms and conditions of the "PLA", you shouldn't, and aren't permitted
// to use or access the source codes or any other information of the "Game" supplied by MADFINGER Games, a.s.
//

using System;
using UnityEngine;

//E_PropKey.E_AT_TARGET_POS
class GOAPGoalPlayAnim : GOAPGoal
{
	public GOAPGoalPlayAnim(AgentHuman owner) : base(E_GOAPGoals.PlayAnim, owner)
	{
	}

	public override void InitGoal()
	{
	}

	public override float GetMaxRelevancy()
	{
		return Owner.BlackBoard.GoapSetup.PlayAnimRelevancy;
	}

	public override void CalculateGoalRelevancy()
	{
		//AgentOrder order = Ai.BlackBoard.OrderGet();
		//if(order != null && order.Type == AgentOrder.E_OrderType.E_GOTO)
		WorldStateProp prop = Owner.WorldState.GetWSProperty(E_PropKey.PlayAnim);
		if (prop != null && prop.GetBool() == true)
			GoalRelevancy = Owner.BlackBoard.GoapSetup.PlayAnimRelevancy;
		else
			GoalRelevancy = 0;
	}

	public override void SetDisableTime()
	{
		NextEvaluationTime = Owner.BlackBoard.GoapSetup.PlayAnimDelay + Time.timeSinceLevelLoad;
	}

	public override void SetWSSatisfactionForPlanning(WorldState worldState)
	{
		worldState.SetWSProperty(E_PropKey.PlayAnim, false);
	}

	public override bool IsWSSatisfiedForPlanning(WorldState worldState)
	{
		WorldStateProp prop = worldState.GetWSProperty(E_PropKey.PlayAnim);

		if (prop != null && prop.GetBool() == false)
			return true;

		return false;
	}

	public override bool IsSatisfied()
	{
		return IsPlanFinished();
	}
}
