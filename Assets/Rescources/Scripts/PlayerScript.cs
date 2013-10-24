using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour 
{
	//public bool OnGround;
	
	public int CurrentLevel;
	
	public KeyCode MoveLeft;
	public KeyCode MoveRight;
	
	private SpriteHandler animate;
	private JumpPlayer Jump;
	
	
	void Start()
	{
		animate = GetComponent<SpriteHandler>();
		Jump = GetComponent<JumpPlayer>();
	}
	void Update()
	{
		if(Input.GetKey(MoveLeft)||Input.GetKey(MoveRight))
		{
		animate.Animate(9,4,0,0,29,5);	
		}
	}
	void FixedUpdate()
	{
		float move;
		Vector3 vel = rigidbody.velocity;
			vel.x=0f;
			rigidbody.velocity = vel;
		if(Jump.OnGround)
		{
			 move = 10000;
		}
		else{
			move = 5000;	
		}
		if (Input.GetKey(MoveRight))
		{
			rigidbody.AddRelativeForce(new Vector3(move,0,0 ));
		}
		else if (Input.GetKey(MoveLeft))
		{
			rigidbody.AddRelativeForce(new Vector3(-move,0 ,0 ));	
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
