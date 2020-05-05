using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brush : MonoBehaviour, IColorChanger
{
    Color brushColor;
    Color defaultColor = Color.white;

    float timeLeft = 3.0f;
    float timeResetValue = 3.0f;

    Renderer rend;

    private void Start()
    {
        Cursor.visible = false;
        rend = GetComponent<Renderer>();
        ResetColor();
    }

    void Update()
    {
        Vector3 currentMousePos = Input.mousePosition;
        Vector3 cursorPos = Camera.main.ScreenToWorldPoint(new Vector3(currentMousePos.x,currentMousePos.y, 10f));
        transform.position = cursorPos;
    }

    public void SetColor(Color color)
    {
        SetBrushColor(color);
        ResetTime();
        StartCoroutine("ColorReset");
    }

    public Color GetColor()
    {
        return this.brushColor;
    }


    IEnumerator ColorReset()
    {
        while (timeLeft >= 0.0f)
        {
            timeLeft = timeLeft - 0.01f;
            yield return new WaitForSeconds(0.01f);
        }
        ResetTime();
        ResetColor();
    }

    private void ResetTime()
    {
        timeLeft = timeResetValue;
    }

    private void ResetColor()
    {
        brushColor = defaultColor;
        rend.material.SetColor("_Color", defaultColor);
    }

    private void SetBrushColor(Color color)
    {
        this.brushColor = color;
        rend.material.SetColor("_Color", color);
    }
}
