using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cuadrado : MonoBehaviour {
	public int fase = 1; 
	public float vel = 0.2f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (fase==1)
		{
		
			this.transform.position += new Vector3(vel,0,0); 
		}
		

		if (fase==1 && this.transform.position.x > 10)
		{
			fase = 2;
		}
		if (fase==2)
		{
			
			this.transform.position += new Vector3(0,0,vel); 
		}
		if (fase==2 && this.transform.position.z > 10)
		{
			fase = 3;
		}
		if (fase==3)
		{
			
			this.transform.position += new Vector3(-vel,0,0); 
		}
		if (fase==3 && this.transform.position.x < 0)
		{
			fase = 4;
		}
		if (fase==4)
		{
		
			this.transform.position += new Vector3(0,0,-vel); 
		}
		if (fase==4 && this.transform.position.z < 0)
		{
			fase = 1;
		}
	}
}
