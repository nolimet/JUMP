using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour 
{
	//public bool OnGround;
	
	public int CurrentLevel;
	
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
			rigidbody.AddRelativeForce(new Vector3(10000,0,0 ));
		}
		else if (Input.GetKey(MoveLeft))
		{
			rigidbody.AddRelativeForce(new Vector3(-10000,0 ,0 ));	
		}
		
<<<<<<< HEAD


		if (Input.GetKey(Jump))

		{
			rigidbody.AddForce (Vector3.up * 1500);
		}
=======
		//if (Input.GetKeyDown(Jump) && OnGround==true)
		//{
		//	rigidbody.AddForce (Vector3.up * jumpForce);
		//	OnGround=false;
		//}
>>>>>>> origin/got-a-error
		
	
		
		
	}
	
	void OnCollisionEnter (Collision col)
	{
<<<<<<< HEAD
		if(col.collider.name == "Ground")
		{
			OnGround = true;
			
		}
=======
		//if(col.collider.tag == "Ground")
		//{
		//	OnGround = true;
		//}
>>>>>>> origin/got-a-error
		
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
