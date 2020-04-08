using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadialMenuSpawner : MonoBehaviour
{
	public static RadialMenuSpawner ins;
	public RadialMenu menuPrefab;
	private Camera cam; 

	private void Awake()
	{
		ins = this;
		cam = Camera.main;
		
	}

	public void SpawnMenu() {
		RadialMenu newMenu = Instantiate(menuPrefab) as RadialMenu;
		newMenu.transform.SetParent (transform, false);
		Vector3 p = Input.mousePosition;
		p.z = 20; 
		newMenu.transform.position = cam.ScreenToWorldPoint(p);


	}
		

}
