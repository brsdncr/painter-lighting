using System;
using UnityEngine;

public class ClickManager : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        CheckMouseInput();
    }

    void CheckMouseInput()
    {
        if (Input.GetMouseButton(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 100.0f))
            {
                try
                {
                    if (hit.transform.GetComponent(typeof(IClickable)))
                    {
                        hit.transform.SendMessage("OnClick");
                    }
                }
                catch (Exception ex)
                {
                    Debug.Log("Warning: " + ex.Message);
                }
            }
        }
    }
}
