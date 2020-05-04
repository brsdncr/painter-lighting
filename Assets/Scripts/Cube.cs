using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour, IClickable, IColorChanger
{
    GameObject brush;
    private void Start()
    {
        brush = GameObject.Find("Brush");
    }
    public void OnClick()
    {
        this.ChangeColor();
    }

    public void ChangeColor()
    {
        Color currentColor = brush.transform.GetComponent<Brush>().GetColor();
        this.SetColor(currentColor);
    }

    public void SetColor(Color color)
    {
        if (this.GetColor().Equals(Color.white) || color.Equals(Color.white))
        {
            var cubeRenderer = transform.GetComponent<Renderer>();
            cubeRenderer.material.SetColor("_Color", color);
        }
    }

    public Color GetColor()
    {
        var cubeRenderer = transform.GetComponent<Renderer>();
        return cubeRenderer.material.color;
    }
}
