using UnityEngine;
using System.Collections;

public class EnemyJumper : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
	void FixedUpdate()
	{
		Vector3 vel = rigidbody.velocity;
		vel.x=0f;
		rigidbody.velocity = vel;
		
		rigidbody.AddForce (Vector3.up * 1500);
		
	}
}
