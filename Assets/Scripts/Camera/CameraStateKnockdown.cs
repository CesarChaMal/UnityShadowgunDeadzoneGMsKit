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

public class CameraStateKnockdown : CameraState
{
	Transform DefaultPos;
	Transform DefaultLookat;

	GameObject Offset;
	Transform OffsetTransform;

	// Use this for initialization
	public CameraStateKnockdown(AgentHuman owner) : base(owner)
	{
		DefaultPos = Owner.transform.Find("CameraTargetPos");
		DefaultLookat = Owner.transform.Find("CameraTargetDir");

		Offset = new GameObject("CameraOffsetKnockdown");

		OffsetTransform = Offset.transform;
		OffsetTransform.parent = Owner.transform;
		OffsetTransform.position = DefaultPos.position;
		OffsetTransform.LookAt(DefaultLookat.position);

		OffsetTransform.RotateAround(DefaultLookat.position, DefaultLookat.right, 25);
		OffsetTransform.RotateAround(DefaultLookat.position, DefaultLookat.up, 180);
	}

	public override Transform GetDesiredCameraTransform()
	{
		/*OffsetTransform.position = DefaultPos.position;
        OffsetTransform.LookAt(DefaultLookat.position);
	
		OffsetTransform.RotateAround(DefaultLookat.position, DefaultLookat.right, 25 );
		OffsetTransform.RotateAround(DefaultLookat.position, DefaultLookat.up, 180 );*/

		return OffsetTransform;
	}

	/// 
	public override void Activate(Transform t)
	{
		base.Activate(t);
		Offset.SetActive(true);

		//      OffsetTransform.position = t.TransformDirection(Vector3.zero);
		//GameCamera.Instance.Activate(t.position + Vector3.up, t.position + t.forward);
	}

	public override void Deactivate()
	{
		Offset.SetActive(false);
		base.Deactivate();
	}
}
