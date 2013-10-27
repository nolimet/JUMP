using UnityEngine;
using System.Collections;

public class EnemyWalker : MonoBehaviour 
{
	bool attacking;

	int richting = 1;
	
	private SpriteHandler animate;
	
	void Start()
	{
		animate = GetComponent<SpriteHandler>();
	}
	
	void Update()
	{
		animate.Animate(4,5,0,0,19,5);	
	}
	
	void FixedUpdate () 
	{
		/*Vector3 speed = new Vector3();
		
		GameObject player = GameObject.Find("Player");
		transform.LookAt(player.transform.position);
		
		Ray ray = new Ray(transform.position, transform.TransformDirection(Vector3.forward));
			RaycastHit hit;
		
			if(Physics.Raycast(ray, out hit, 5))
			{
			
				if (hit.collider.gameObject.name == "Player")
				{
					attacking = true;
				}
			
		if (attacking)
		{
			rigidbody.AddRelativeForce(0, 0, 6);
		}
			
	}*/
		
		Vector3 speed = new Vector3();
		
		speed.y = rigidbody.velocity.y;
		
		speed.x = 10 * richting;
		
		
		rigidbody.velocity = speed;
	}
	
	void OnTriggerEnter(Collider col)
	{
		if(col.name == "Edge")
		{
			richting = -richting;
		}
	}
}



