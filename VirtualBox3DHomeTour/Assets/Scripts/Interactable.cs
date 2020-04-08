using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
	[System.Serializable]
	public class Action {
		public string title; 
	}
	private void OnMouseDown()
	{
		RadialMenuSpawner.ins.SpawnMenu();
	}
}
