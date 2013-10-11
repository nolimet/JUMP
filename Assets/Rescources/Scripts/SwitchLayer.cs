using UnityEngine;
using System.Collections;

public class SwitchLayer : MonoBehaviour {
	
	public KeyCode switchKey;
	public float distance = 1;
	public float duration = 0.1f;
	
	private bool switched = false;
	private bool home=true;
	
	private float MoveTo;
	private float StartPos;
	
	// Use this for initialization
	void Start () {
		MoveTo = transform.position.z+distance;
		StartPos = transform.position.z;
	}
	
	// Update is called once per frame
	void Update () {
		float step = distance/duration;
		step = step*Time.deltaTime;
		Vector3 pos = transform.position;
		
		if(Input.GetKeyDown(switchKey))
		{
			switched=!switched;
			home=false;
		}

		
		if(switched && transform.position.z>StartPos && home==false)
		{
			pos.z -= step;
		}
		else if(switched ==false && transform.position.z<MoveTo && home==false)
		{
			pos.z += step;
		}
		/*else if (transform.position.z>MoveTo || transform.position.z<StartPos)
		{
			home=true;
			if(switched == true)
			{
				pos.z=MoveTo;
			}
			else if(switched == false)
			{
				pos.z=StartPos;	
			}
		}*/
		transform.position=pos;
	}
}