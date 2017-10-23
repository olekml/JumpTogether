using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class CountAA : MonoBehaviour {
	public Text countText;
	private int count;

	void Start () {

		count = 0;

		SetCountText();
	}



	void OnTriggerEnter2D(Collider2D other)
	{

		if (other.gameObject.CompareTag ("PickUp")) {
			other.gameObject.SetActive (false);

			count = count + 1;

			SetCountText ();
		}
	}

	void SetCountText()
	{
		countText.text = " " + count.ToString();


	}



	void Update () {

	}
}
