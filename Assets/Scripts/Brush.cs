using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brush : MonoBehaviour, IColorChanger
{
    Color brushColor;
    Color defaultColor = Color.white;

    float timeLeft = 3.0f;
    float timeResetValue = 3.0f;

    private void Start()
    {
        ResetColor();
    }

    public void SetColor(Color color)
    {
        this.brushColor = color;
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
    }
}
