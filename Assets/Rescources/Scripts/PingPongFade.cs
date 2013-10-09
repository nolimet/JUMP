using UnityEngine;
using System.Collections;

public class PingPongFade : MonoBehaviour {

	public float duration = 10.0f;
	
	public float maxAlpha = 0.2f;
	
	private bool updown = false;
	
	public KeyCode KeyBind;

    // Update is called once per frame

    void Update () {
		
		float substract=1/duration;

        Color textureColor = renderer.material.color;
		
		if(textureColor.a > maxAlpha && updown==false)
		{
        	textureColor.a -= substract*Time.deltaTime;
		}
		
		if(textureColor.a < 1&& updown)
		{
        	textureColor.a += substract*Time.deltaTime;
		}
		if(Input.GetKeyDown(KeyBind))
		{
				updown=!updown;
		}
        renderer.material.color = textureColor;

    }
	public void ChangeOpacity()
	{
		updown=!updown;
	}
}
