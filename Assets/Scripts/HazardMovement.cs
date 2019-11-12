using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HazardMovement : MonoBehaviour
{
    public float xDistance = 0.0f;
	public float xSpeed = 0.0f;
	public float yDistance = 0.0f;
	public float ySpeed = 0.0f;

	private Vector3 pCurrent;
	private Vector3 pOriginal;

	private bool movingRight = true;
	private bool movingUp = true;

	private void Start()
	{
		pCurrent = transform.position;
		pOriginal = transform.position;
	}

	// Update is called once per frame
	void Update()
	{
		// Handles movement in the x direction
		if (movingRight)
		{
			if (xDistance > 0 && pCurrent.x < pOriginal.x + xDistance)
			{
				pCurrent.x += xSpeed * 0.01f;
			}
			else if (xDistance < 0 && pCurrent.x > pOriginal.x + xDistance)
			{
				pCurrent.x -= xSpeed * 0.01f;
			}
			else if (xDistance == 0)
			{
				// Does nothing on purpose to save processing time
			}
			else
			{
				movingRight = false;
			}
		}
		else
		{
			if (xDistance > 0 && pCurrent.x > pOriginal.x)
			{
				pCurrent.x -= xSpeed * 0.01f;
			}
			else if (xDistance < 0 && pCurrent.x < pOriginal.x)
			{
				pCurrent.x += xSpeed * 0.01f;
			}
			else if (xDistance == 0)
			{
				// Does nothing on purpose to save processing time
			}
			else
			{
				movingRight = true;
			}
		}
		
		// Handles movement in the y direction
		if (movingUp)
		{
			if (yDistance > 0 && pCurrent.y < pOriginal.y + yDistance)
			{
				pCurrent.y += ySpeed * 0.01f;
			}
			else if (yDistance < 0 && pCurrent.y > pOriginal.y + yDistance)
			{
				pCurrent.y -= ySpeed * 0.01f;
			}
			else if (yDistance == 0)
			{
				// Does nothing on purpose to save processing time
			}
			else
			{
				movingUp = false;
			}
		}
		else
		{
			if (yDistance > 0 && pCurrent.y > pOriginal.y)
			{
				pCurrent.y -= ySpeed * 0.01f;
			}
			else if (yDistance < 0 && pCurrent.y < pOriginal.y)
			{
				pCurrent.y += ySpeed * 0.01f;
			}
			else if (yDistance == 0)
			{
				// Does nothing on purpose to save processing time
			}
			else
			{
				movingUp = true;
			}
		}

		transform.position = pCurrent;
    }
}
