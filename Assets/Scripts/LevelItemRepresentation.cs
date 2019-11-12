using UnityEngine;
using System;

[Serializable]
public class LevelItemRepresentation
{
    public Vector3 rotation;
    public Vector3 scale;
    public Vector3 position;
    public string prefabName;
    public int spriteOrder;
    public string spriteLayer;
    public Color spriteColour;
	public float xDistance = 0.0f;
	public float xSpeed = 0.0f;
	public float yDistance = 0.0f;
	public float ySpeed = 0.0f;
}
