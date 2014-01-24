using UnityEngine;
using System.Collections;

public class WeponSwitching : MonoBehaviour {

	public GameObject weapon1, weapon2;

	void Update () {
		if(Input.GetKeyDown(KeyCode.Q))
	    {
			SwitchWepons();
		}
	}

	void SwitchWepons()
	{
		if(weapon1.active)
		{
			weapon1.SetActive(false);
			weapon2.SetActive(true);
		}else
		{
			weapon1.SetActive(true);
			weapon2.SetActive(false);
		}
	}
}