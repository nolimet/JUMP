using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour 
{
	public static bool OnGround;
	
	public int CurrentLevel;
	
	public KeyCode MoveLeft;
	public KeyCode MoveRight;
	public KeyCode Jump;
	
	// Use this for initialization
	void Start () 
	{
		OnGround = false;
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
	void FixedUpdate()
	{
		
	 //= Vector3.zero;
		Vector3 vel = rigidbody.velocity;
			vel.x=0f;
			rigidbody.velocity = vel;
		if (Input.GetKey(MoveRight))
		{
			rigidbody.AddRelativeForce(new Vector3(10000,0,0 ));
		}
		else if (Input.GetKey(MoveLeft))
		{
			rigidbody.AddRelativeForce(new Vector3(-10000,0 ,0 ));	
		}
		


		if (Input.GetKey(Jump))

		{
			rigidbody.AddForce (Vector3.up * 1500);
		}
		
	
		
		
	}
	
	void OnCollisionEnter (Collision col)
	{
		if(col.collider.name == "Ground")
		{
			OnGround = true;
			
		}
		
		if(col.collider.name == "EnemyJumper")
		{
			Destroy(col.collider.gameObject);
			Application.LoadLevel(0);
		}
		
		if (col.collider.name == "EnemyWalker")
		{
			Destroy(col.collider.gameObject);
			Application.LoadLevel(0);
		}
		
	}
}
