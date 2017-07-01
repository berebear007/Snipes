using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchDebugTool : MonoBehaviour {

	private Vector2 touchOrigin = -Vector2.one;

	public GameObject touchSpot;
	public GameObject hitParent;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.touchCount > 0)
		{
			Touch myTouch = Input.touches[0];
			if (myTouch.phase == TouchPhase.Began)
				{
				touchOrigin = myTouch.position;
				//Debug.Log("you touched me here:" + myTouch.position);
				Vector2 screenPos = Camera.main.ScreenToWorldPoint(touchOrigin);
				GameObject go = Instantiate (touchSpot, screenPos, Quaternion.identity) as GameObject;
				go.transform.SetParent(hitParent.transform);
				}
		}		
	}
}
