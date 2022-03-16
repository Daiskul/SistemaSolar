using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotaejey : MonoBehaviour {
	public float rot;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Rotate(0,rot,0);
	
	
	
	
	if (Input.GetKey(KeyCode.A)){
		rot+=1;

	}
	if (Input.GetKey(KeyCode.D)){
		rot-=2;
	}
	}
}
