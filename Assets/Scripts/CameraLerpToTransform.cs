using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLerpToTransform : MonoBehaviour
{
    public Transform camTarget;
    [Range(2.5f,10f)]
    public float trackingSpeed = 7.8f;
    public float minX;
    public float minY;
    public float maxX;
    public float maxY;

    void FixedUpdate()
    {
        if (camTarget != null)
        {
            var newPos = Vector2.Lerp(transform.position, camTarget.position, Time.deltaTime * trackingSpeed);
            var camPosition = new Vector3(newPos.x, newPos.y, -10f);
            var v3 = camPosition;

			// Allows looking up and down
			if (Input.GetKey(KeyCode.W))
			{
				v3.y += 0.3f;
			}
			else
			{
				v3.y -= 0.3f;
			}

			if (Input.GetKey(KeyCode.S))
			{
				v3.y -= 0.3f;
			}
			else
			{
				v3.y += 0.3f;
			}

			var clampX = Mathf.Clamp(v3.x, minX, maxX);
            var clampY = Mathf.Clamp(v3.y, minY, maxY);
            transform.position = new Vector3(clampX, clampY, -10f);
        }
    }
}