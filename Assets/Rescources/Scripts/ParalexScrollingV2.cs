using UnityEngine;
using System.Collections;

public class ParalexScrollingV2 : MonoBehaviour {

	public float scrollSpeed;
	// Update is called once per frame
	void Update () 
	{
		float x = Input.GetAxis("Horizontal")*-1;
		
		if (x!=0)
		{
			Vector2 move = new Vector2 (scrollSpeed*x/30,0f);
			transform.Translate(move);
		}		
	}
}
