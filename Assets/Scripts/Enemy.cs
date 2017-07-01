using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour 
{
	public float movementSpeed = 1.0f;

	public int EHealth = 1;

	public bool flip;

	public SpriteRenderer sprGfx;
	// Use this for initialization
	void Start () 
	{
		//SpriteRenderer sprGfx = GetComponentInChildren<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (EHealth <= 0)
		{
			Destroy (GetComponent<CapsuleCollider2D>());
			GetComponent<Rigidbody2D>().gravityScale = 1.0f;
		}

		if (flip != true)
		{
			transform.Translate(Vector2.right*movementSpeed*Time.deltaTime);
			sprGfx.flipX = false;
		}
		else
		{
			transform.Translate(Vector2.left*movementSpeed*Time.deltaTime);
			sprGfx.flipX = true;
		}

		if (transform.position.y < -100.0f)
		{
			Destroy(gameObject);
		}
	}
	public void OnTriggerEnter2D(Collider2D coll)
	{
		
		if(coll.gameObject.tag == "wall")
		{
			flip = !flip;
		}

		if (coll.gameObject.tag == "DamageEnemy")
		{
			Health();
		}


	}

	public void Health()
	{
		EHealth -= 1;
		Debug.Log("i took damage");
	}
}
