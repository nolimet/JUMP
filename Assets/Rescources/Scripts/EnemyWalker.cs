using UnityEngine;
using System.Collections;

public class EnemyWalker : MonoBehaviour 
{
	bool attacking;

	int richting = 1;
	void FixedUpdate () 
	{
		Vector3 speed = new Vector3();
		
		//speed.y = rigidbody.velocity.y;
		
		//speed.z = 4 * richting;
		
		
		//rigidbody.velocity = speed;
		
		GameObject player = GameObject.Find("Player");
		transform.LookAt(player.transform.position);
		
		Ray ray = new Ray(transform.position, transform.TransformDirection(Vector3.forward));
			RaycastHit hit;
			//Debug.DrawRay(ray.origin, ray.direction * 200);
			if(Physics.Raycast(ray, out hit, 200))
			{
				if (hit.collider.gameObject.name == "Player")
				{
					attacking = true;
				}
		if (attacking)
		{
			rigidbody.AddRelativeForce(0, 0, 12);
		}
			
	}
	}
}
