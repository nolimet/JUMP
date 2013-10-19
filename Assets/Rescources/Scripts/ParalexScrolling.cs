using UnityEngine;
using System.Collections;

public class ParalexScrolling : MonoBehaviour {
	
	public float ScrollSpeed;
	

	void Start () {
	
	}
	
	void Update () {
	
		Vector2 offset= new Vector2 ( ScrollSpeed * Time.time,0f);
		renderer.material.SetTextureOffset("_MainTex",offset);
	}
}
