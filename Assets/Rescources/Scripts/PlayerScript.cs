using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour 
{
	//public bool OnGround;
	
	public int CurrentLevel;
	
	public KeyCode MoveLeft;
	public KeyCode MoveRight;
	
	void FixedUpdate()
	{
		
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
	}
	
	void OnCollisionEnter (Collision col)
	{
		if(col.collider.name == "EnemyJumper")
		{
			Destroy(col.collider.gameObject);
			Application.LoadLevel(0);
		}
		
		if (col.collider.name == "EnemyWalker")
		{
			//Destroy(col.collider.gameObject);
			//Application.LoadLevel(Application.loadedLevel);
		}
		
	}
}
