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
using System.Collections.Generic;

public class GuiShopPageHats : GuiShopPageBase
{
	// GUIVIEW INTERFACE
	protected override void OnViewInit()
	{
		base.OnViewInit();
	}

	protected override void OnViewReset()
	{
		base.OnViewReset();
	}

	protected override void OnViewShow()
	{
		base.OnViewShow();
	}

	protected override void OnViewHide()
	{
		base.OnViewHide();
	}

	// SPOLECNY ITERFACE PRO VSECHNY PAGE
	public override void OnItemChange(ShopItemId itemId, bool forceUpdateView)
	{
		base.OnItemChange(itemId, forceUpdateView);
	}

	public override List<ShopItemId> GetItems()
	{
		return ShopDataBridge.Instance.GetHats();
	}
}
