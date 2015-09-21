using UnityEngine;
using System.Collections;
using UnityEngine.UI; 

public class TreasureSunken : MonoBehaviour {
	public Text textUI; 
	public Transform player; 
	public Transform goal;  
	bool hasFoundTresure = false;

	void Start () {
	}

	void Update () {
	
		if (player.position.x < -100f) { 
			textUI.text = "Too far left! Sail east"; } 
		if ((goal.position - player.position).magnitude < 50f) { 
			textUI.text = "There's something shiny up north"; }
		if ((goal.position - player.position).magnitude < 20f) { 
			textUI.text = "Space out to win"; 
			if (Input.GetKeyDown (KeyCode.Space)){ 
				hasFoundTresure = true;}
			}
		if (hasFoundTresure){
			textUI.text = "Gratz, you win";}

	}
}
