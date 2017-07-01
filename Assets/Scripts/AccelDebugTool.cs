using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccelDebugTool : MonoBehaviour
{
	public float moveSpeed;
	public float moveModifyer;
	public float accel;
	public float accelLimit;

	public Transform target;

	// Use this for initialization
	void Start ()
	{
		Screen.orientation = ScreenOrientation.Landscape;
	}
	
	// Update is called once per frame
	void Update () 
	{
		//*******************SNAP To Cover needs lots of work****************\\
		//		if (Input.acceleration.x <moveValue && Input.acceleration.x> - moveValue)
//		{
//			transform.position = new Vector3(0,transform.position.y,-10.0f);
//		}
//		else if(Input.acceleration.x>moveValue)
//		{
//			transform.position = new Vector3(10,transform.position.y,-10.0f);
//		}
//		else if(Input.acceleration.x<-moveValue)
//		{
//			transform.position = new Vector3(-10,transform.position.y,-10.0f);
//		}
		//Debug.Log(Input.acceleration);


		//transform.Translate(Input.acceleration.x*moveSpeed,0,0);
		accel=Input.acceleration.x;
		if (accel>accelLimit)
		{
			transform.Translate(Input.acceleration.x*moveSpeed,0,0);
		}
		else if (accel<-accelLimit)
		{
			transform.Translate(Input.acceleration.x*moveSpeed,0,0);
		}
		else 
		{
			float step = moveSpeed * Time.deltaTime;
			transform.position = Vector3.MoveTowards(transform.position,target.position,step * moveModifyer);
		}
		Vector3 pos = transform.position;
		pos.x = Mathf.Clamp(transform.position.x, -10.0f,10.0f);
		pos.y = Mathf.Clamp(transform.position.y,-5,0);
		transform.position = pos;
		//Debug.Log ("Y"+Input.acceleration.y);
	}

}
