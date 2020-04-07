using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeButton : MonoBehaviour
{
	public GameObject menu;
	private bool visible = false;
	public static ConsoleButton ins; 
	private void OnTriggerEnter(Collider other)
	{
		if (visible)
		{
			menu.SetActive(true);
			visible = true;
		}
		else {
			menu.SetActive(false);
			visible = false; 
		}

	}

}
