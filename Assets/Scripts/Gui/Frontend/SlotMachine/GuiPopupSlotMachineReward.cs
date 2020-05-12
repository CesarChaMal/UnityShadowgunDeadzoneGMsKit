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

using UnityEngine;
using System.Collections;

public class GuiPopupSlotMachineReward : GuiPopup
{
	readonly static string CLOSE_BUTTON = "Close_Button";

	// GUIPOPUP INTERFACE

	public override void SetCaption(string inCaption)
	{
	}

	public override void SetText(string inText)
	{
		GuiBaseUtils.GetControl<GUIBase_Label>(Layout, "Text_Label").SetNewText(inText);
	}

	// GUIVIEW INTERFACE

	protected override void OnViewShow()
	{
		base.OnViewShow();

		GuiBaseUtils.RegisterButtonDelegate(Layout, CLOSE_BUTTON, () => { Owner.Back(); }, null);
	}

	protected override void OnViewHide()
	{
		GuiBaseUtils.RegisterButtonDelegate(Layout, CLOSE_BUTTON, null, null);

		base.OnViewHide();
	}
}
