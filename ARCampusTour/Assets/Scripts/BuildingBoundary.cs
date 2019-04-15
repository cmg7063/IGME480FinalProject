using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingBoundary : MonoBehaviour
{
    
	public Vector3 boundMin;
	public Vector3 boundMax;
    // Start is called before the first frame update
    void Start()
    {
        
    }


	/// <summary>
	/// Gets the X minimum.
	/// Retrieves the minimum X value (left edge) of this sprite
	/// </summary>
	/// <returns>The X minimum as a float.</returns>
	public float GetXMin()
	{
		//Debug.Log ("Returning min x " + boundMin.x);
		return boundMin.x;
		//return gameObject.GetComponent<SpriteRenderer> ().sprite.bounds.min.x;
	}

	/// <summary>
	/// Gets the X maximum.
	/// Retrieves the maximum X value (right edge) of this sprite
	/// </summary>
	/// <returns>The X max as a float.</returns>
	public float GetXMax()
	{
		//Debug.Log ("Returning max x " + boundMax.x);
		return boundMax.x;
		//return gameObject.GetComponent<SpriteRenderer> ().sprite.bounds.min.x;
	}

	/// <summary>
	/// Gets the Y minimum.
	/// Retrieves the minimum Y value (bottom edge) of this sprite
	/// </summary>
	/// <returns>The Y minimum as a float</returns>
	public float GetZMin()
	{
		//Debug.Log ("Returning min x " + boundMin.x);
		return boundMin.z;
		//return gameObject.GetComponent<SpriteRenderer> ().sprite.bounds.min.x;
	}

	/// <summary>
	/// Gets the Y maximum.
	/// Retrieves the maximum Y value (top edge) of this sprite
	/// </summary>
	/// <returns>The Y maximum as a float</returns>
	public float GetZMax()
	{
		//Debug.Log ("Returning max x " + boundMax.x);
		return boundMax.z;
		//return gameObject.GetComponent<SpriteRenderer> ().sprite.bounds.min.x;
	}
}
