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

[AddComponentMenu("Upgrades/TechSettings")]

// !!!  NEMAZAT POLOZKY, PRIDAVAT POUZE NA KONEC SEZNAMU (pred MAX_ID) !!! - reflectuje se na CLOUD jako INT
public enum E_TechID
{
	None,
	Nanotech,
	AdvMaterials,
	Unused1,
	Unused2,
	ImprovedArmor,
	ImprovedBody,
	ImprovedBodyII,
	ImprovedHealing,
	EnhancedHealth,
	AdvSensors,
	Homing,
	Jamming,
	AdvEnergy,
	Emp,
	EmpII,
	ImprExplosives,
	MAX_ID //add any new IDs prior to this one!
}

// -----------------
public class TechSettings : Settings<E_TechID>
{
	// --------------------------------------------------------------------------------------------
	// P U B L I C    P A R T
	// --------------------------------------------------------------------------------------------

	[OnlineShopItemProperty] // Please don't change names of members tagged with 'OnlineShopItemProperty' as it breaks online shopping service
	public int MoneyCost;

	[OnlineShopItemProperty] // Please don't change names of members tagged with 'OnlineShopItemProperty' as it breaks online shopping service
	public int GoldCost;

	public override bool IsDefault()
	{
		return (MoneyCost == 0) && (GoldCost == 0) && (!DISABLED);
	}

	public override string GetSettingsClass()
	{
		return "tech";
	}

	public override string ToString()
	{
		return ID.ToString();
	}
}
