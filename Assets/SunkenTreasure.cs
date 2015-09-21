using UnityEngine;
using System.Collections;

public class SunkenTreasure : MonoBehaviour {
	public Transform cube;
	public float moveSpeed;

	void Update () {

	if (Input.GetKey (KeyCode.W)){ 
			transform.position += new Vector3(0f, 0f, moveSpeed) * Time.deltaTime; 
			transform.eulerAngles = new Vector3(0, 0, 0);
		}
    if (Input.GetKey (KeyCode.S)){ 
			transform.position += new Vector3 (0f, 0f, -moveSpeed) * Time.deltaTime;
			transform.eulerAngles = new Vector3(0f, -180, 0);
		} 
    if (Input.GetKey (KeyCode.A)){ 
			transform.position += new Vector3(-moveSpeed, 0f, 0f) * Time.deltaTime; 
			transform.eulerAngles = new Vector3(0 , -90, 0);
		} 
	if (Input.GetKey (KeyCode.D)){ 
			transform.position += new Vector3 (moveSpeed, 0f, 0f) * Time.deltaTime; 
			transform.eulerAngles = new Vector3(0, 90, 0);
		} 

	
	}
	} 