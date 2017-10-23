using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIControlA : MonoBehaviour {

	public void ChangeScene(string sceneName)
	{
		Application.LoadLevel (sceneName);

	}
}
