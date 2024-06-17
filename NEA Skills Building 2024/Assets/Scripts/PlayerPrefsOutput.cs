using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerPrefsOutput : MonoBehaviour {

	TextMeshPro TxtOutput;
	// Use this for initialization
	void Start () {
		TxtOutput.text = PlayerPrefs.GetString ("WhichButtonClicked");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
