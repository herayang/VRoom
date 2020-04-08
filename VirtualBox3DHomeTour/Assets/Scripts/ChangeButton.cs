using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeButton : MonoBehaviour
{
	public GameObject menu;
	private bool visible = false;
	
	void OnMouseDown()
	{
		if (!visible)
		{
			menu.SetActive(true);
			visible = true;
		}
		else {
			menu.SetActive(false);
			visible = false; 
		}

	}

	void Update() {
		if (Input.GetMouseButtonDown(0)) {
			OnMouseDown();
		}
	}

}
