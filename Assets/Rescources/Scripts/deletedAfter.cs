using UnityEngine;
using System.Collections;

public class deletedAfter : MonoBehaviour {
	
	public float TimeDestroy = 5;
	// Use this for initialization
	void Start () {
		Destroy(gameObject,TimeDestroy);
	}
}
