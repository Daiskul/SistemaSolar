using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotap : MonoBehaviour {
	public float rot2;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	this.transform.Rotate(0,rot2,0);	
	}
}
