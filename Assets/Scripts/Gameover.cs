using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gameover : MonoBehaviour {





	public void HomeClicked()
	{
		Application.LoadLevel (0);
	}

	public void RetryClicked()
	{
		Application.LoadLevel ("InfinityPath");
	}
}
