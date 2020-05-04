using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour, IClickable
{
    Color sphereColor;
    GameObject brush;

    private void Start()
    {
        sphereColor = transform.GetComponent<Renderer>().material.color;
        brush = GameObject.Find("Brush");
    }

    private void OnDestroy()
    {
        Destroy(gameObject);
    }

	private void OnCollisionEnter(Collision collision)
	{
		this.OnDestroy();
	}

    //Public methods
	public void OnClick()
	{
		this.SetBrushColor();
		this.OnDestroy();
	}

	public void SetBrushColor()
	{
		brush.GetComponent<Brush>().SetColor(sphereColor);
	}

	public Color GetColor()
	{
		return this.sphereColor;
	}


}
