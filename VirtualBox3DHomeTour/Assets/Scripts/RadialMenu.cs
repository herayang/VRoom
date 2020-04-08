using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadialMenu : MonoBehaviour
{
	public RadialButton buttonPrefab;
	public RadialButton selected; 

    void Start()
    {
		RadialButton newButton = Instantiate(buttonPrefab) as RadialButton;
		newButton.transform.SetParent(transform, false);
		newButton.transform.localPosition = new Vector3(0f, 100f);
		
    }

}
