using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mainmenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//Application.LoadLevel ("InfinityPath");
	}

	public void OnSlectedevent(GameObject item)
	{
		Application.LoadLevel ("InfinityPath");
	}

}
