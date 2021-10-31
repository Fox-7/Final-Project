using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseHover : MonoBehaviour
{
	// Start is called before the first frame update
	void Start()
	{
		GetComponent<Renderer>().material.color = Color.black;
	}

	// Change text color on mouse click
	void OnMouseEnter()
	{
		GetComponent<Renderer>().material.color = Color.red;
	}

	// Change text color on mouse click
	void OnMouseExit()
	{
		GetComponent<Renderer>().material.color = Color.black;
	}
}