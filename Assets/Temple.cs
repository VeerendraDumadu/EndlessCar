using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temple : MonoBehaviour {
	public GameObject p1,h1;
	public float TurnSpeed = 1f;
	private float leftRight = 1f;
	private float forward = 1f;
	int Speed;

	private float yRotation;

	private float xRotation;


	// Use this for initialization
	void Start () {
		Speed = 10;
	}
	void ProcessInput()
	{
		leftRight = Input.GetAxis("Horizontal");
		forward = Input.GetAxis("Vertical");

	}
	// Update is called once per frame
	void Update () 
	{
		PathGeneration ();

		if ((this.transform.rotation.y *100 >= 0) && (this.transform.rotation.y *100 <= 69)) {
			Debug.Log ("first");
			yRotation = 90.0f;

		}
		else
		{
			Debug.Log ("secondf");
			yRotation = 00.0f;
		}
		if (this.transform.rotation.y * 100 >= 70) {
			Debug.Log ("thirds");
			yRotation = 00.0f;
		} 
		Debug.Log ("yRotation" + this.transform.rotation.y * 100);

		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			yRotation += Input.GetAxis ("Horizontal");
			this.transform.eulerAngles = new Vector3 (0, -yRotation, 0);
		}
		if (Input.GetKeyDown (KeyCode.RightArrow)) {
			yRotation += Input.GetAxis ("Horizontal");
			this.transform.eulerAngles = new Vector3 (0, yRotation, 0);
		}
		ProcessInput ();

		transform.Translate (Vector3.forward * Time.deltaTime *Speed);

	}
		
//	public void ConrolPlayer()
//	{
//		transform.Translate(Vector3.forward * Time.deltaTime*Speed);
//
////		var x = Input.GetAxis("Horizontal") * Time.deltaTime * Speed;
////		var z = Input.GetAxis("Vertical") * Time.deltaTime * Speed;
////		transform.Translate(x, 0, z);
//	}


		
	public void PathGeneration()
	{

			if (transform.position.z - p1.transform.position.z >= 70) {
				Vector3 Temp = new Vector3 (50, 0, 100);
				p1.transform.position += Temp;
			}



			if (transform.position.z - h1.transform.position.z >= 40) {
				Vector3 Temp = new Vector3 (50, 0, 100);
				h1.transform.position += Temp;
			}
		}


}
