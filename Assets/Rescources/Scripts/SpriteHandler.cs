using UnityEngine;
using System.Collections;

public class SpriteHandler : MonoBehaviour {

	private int delay;
	
	//public int nrOfColums;
	//public int nrOfRows;
	
	//public int NrOfCells;
	//public float Fps;
	
	//public int startAtCollum;
	//public int startAtRow;
	// Update is called once per frame
	
	public void Animate (int nrOfColums, int nrOfRows, int startAtColum, int startAtRow,int NrOfCells,int Fps, bool hasTexture=false, Vector2 TextureSize = new Vector2()) {

		int index = (int) (Fps*Time.time);
		index = index % NrOfCells;
	
		float sizeX; 
		float sizeY;
	
		Vector2 size;
		
		if(hasTexture==false)
		{
			sizeX = 1f /nrOfColums;
			sizeY =1f / nrOfRows;
		
			size = new Vector2 (sizeX,sizeY);
			
			float vindex = index/nrOfColums;
			float uindex = index%nrOfColums;
			
			float OffSetX = size.x*(uindex+startAtColum);
			float OffSetY =size.y*(vindex+startAtRow);
			Vector2 OffSet = new Vector2 (OffSetX,OffSetY);
		
			Debug.Log ("vindx " + vindex + " uindx " + uindex);
		}
		else
		{
			
		}
		
		
		//set size
		
		renderer.material.SetTextureScale("_MainTex",size);
		renderer.material.SetTextureOffset("_MainTex",OffSet);
		
	}
}
