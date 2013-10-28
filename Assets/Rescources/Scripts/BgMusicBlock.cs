using UnityEngine;
using System.Collections;

public class BgMusicBlock : MonoBehaviour 
{
	public AudioClip bgMusic;
	
	
	

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
	
	}
	
	void OnTriggerEnter (Collider other)
	{
		if(other.collider.name == "Player")
		{
			//audio.Play();
			AudioSource.PlayClipAtPoint(bgMusic, transform.position);
			//Destroy(col.collider.gameObject);
		}
	}
}
