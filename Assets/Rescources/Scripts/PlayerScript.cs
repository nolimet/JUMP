using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour 
{
	public static bool OnGround;
	
	public int CurrentLevel;
	
	
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
		if (Input.GetKey(KeyCode.D))
		{
			rigidbody.AddRelativeForce(new Vector3(10000,0,0 ));
		}
		else if (Input.GetKey(KeyCode.A))
		{
			rigidbody.AddRelativeForce(new Vector3(-10000,0 ,0 ));	
		}
		
		if (Input.GetKeyDown(KeyCode.Space))
		{
			rigidbody.AddForce (Vector3.up * 15000);
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
