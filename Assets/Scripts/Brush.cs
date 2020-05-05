using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Brush : MonoBehaviour, IColorChanger
{
    Color brushColor;
    Color defaultColor = Color.white;

    float timeLeft = 3.0f;
    float timeResetValue = 3.0f;

    [SerializeField]Text brushTimerText;

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
        StopAllCoroutines();
        SetBrushColor(color);
        ResetTime();

        //TO DO: This can be modular
        if (!color.Equals(this.defaultColor))
        {
            StartCoroutine("ColorReset");
        }
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
            SetTimerText(timeLeft.ToString("F0"));
            yield return new WaitForSeconds(0.01f);
        }

        ResetColor();
    }

    private void ResetTime()
    {
        SetTimerText("");
        timeLeft = timeResetValue;
    }

    private void ResetColor()
    {
        this.brushColor = defaultColor;
        SetColor(this.brushColor);
        //rend.material.SetColor("_Color", defaultColor);
    }

    private void SetBrushColor(Color color)
    {
        this.brushColor = color;
        rend.material.SetColor("_Color", color);
    }

    private void SetTimerText(string textToSet)
    {
        brushTimerText.text = textToSet;
        brushTimerText.color = GetColor();
    }
}
