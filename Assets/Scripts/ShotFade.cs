using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotFade : MonoBehaviour 
{

	public float decayTime = 10.0f;
	public float alphaLevel =1.0f;

	SpriteRenderer objectGFX; 

	// Use this for initialization

	void OnAwake()
	{
		
	}
	void Start () 
	{
		objectGFX = GetComponentInChildren<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		decayTime -= Time.deltaTime;
		Color color = objectGFX.material.color;
		color.a = decayTime;
		objectGFX.material.color = color;

		if(decayTime <= 0.0f)
		{
			Destroy(this.gameObject);
		}
	}
}
