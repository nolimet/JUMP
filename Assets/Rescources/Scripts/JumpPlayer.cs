using UnityEngine;
using System.Collections;

public class JumpPlayer : MonoBehaviour {
	
	public KeyCode Jump;
	
	public bool OnGround=true;
	
	public float jumpForce = 1500;
	public float jumpDuration;
	
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		if (Input.GetKeyDown(Jump) && OnGround==true)
		{
			rigidbody.AddForce (Vector3.up * jumpForce);
			OnGround=false;
		} 
	}
	
	void OnCollisionEnter (Collision col)
	{
		if(col.collider.tag == "Ground")
		{
			OnGround = true;
		}
	}
}
