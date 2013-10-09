using UnityEngine;
using System.Collections;

public class EnemyWalker : MonoBehaviour {

	int richting = 1;
	void FixedUpdate () 
	{
		Vector3 speed = new Vector3();
		
		speed.y = rigidbody.velocity.y;
		
		speed.z = 10 * richting;
		
		
		rigidbody.velocity = speed;
	}
}
