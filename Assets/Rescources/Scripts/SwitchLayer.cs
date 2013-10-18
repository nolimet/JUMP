using UnityEngine;
using System.Collections;

public class SwitchLayer : MonoBehaviour {
	
	public KeyCode switchKey;
	public float distance = 1;
	public float duration = 0.1f;
	
	private bool switched = false;
	private bool CanSwitch;
	private bool home = true;
	
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

		
		if(switched && transform.position.z>StartPos && CanSwitch)
		{
			pos.z -= step;
		}
		else if(switched ==false && transform.position.z<MoveTo && CanSwitch)
		{
			pos.z += step;
		}
		transform.position=pos;
	}
	
	void OncollisionEnter(Collider col)
	{
		if(col.collider.tag=="AntiSwitch")
		{
			CanSwitch=false;	
		}
		else
		{
			CanSwitch=true;	
		}
			
	}
}