using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverObject : MonoBehaviour {

	// unity accessible text 
	public Text gameOverTxt;

	// Use this for initialization
	void Start () {
		// invisible
		gameOverTxt.color = new Color(0,0,0,0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other){
		// visible
		gameOverTxt.color = new Color(0,0,0,1);
	}
}
