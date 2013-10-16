using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour 
{
	//public bool OnGround;
	
	public KeyCode MoveLeft;
	public KeyCode MoveRight;
	//public KeyCode Jump;
	
	//public float jumpForce;
	//public float jumpduration;
	
	// Use this for initialization
	void Start () 
	{
		//OnGround = false;
	}
	
	void FixedUpdate()
	{
		
	 //= Vector3.zero;
		Vector3 vel = rigidbody.velocity;
			vel.x=0f;
			rigidbody.velocity = vel;
		if (Input.GetKey(MoveRight))
		{
			rigidbody.AddRelativeForce(new Vector3(0, 0, 1000));
		}
		else if (Input.GetKey(MoveLeft))
		{
			rigidbody.AddRelativeForce(new Vector3(0, 0, -1000));	
		}
		
		//if (Input.GetKeyDown(Jump) && OnGround==true)
		//{
		//	rigidbody.AddForce (Vector3.up * jumpForce);
		//	OnGround=false;
		//}
		
		
	}
	
	void OnCollisionEnter (Collision col)
	{
		//if(col.collider.tag == "Ground")
		//{
		//	OnGround = true;
		//}
		
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
