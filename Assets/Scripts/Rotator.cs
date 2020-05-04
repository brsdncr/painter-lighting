using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    Vector3 rotateVector;

    private void Start()
    {
        rotateVector = new Vector3(0f, 90f, 0f);
    }
    private void FixedUpdate()
    {
        transform.Rotate(rotateVector * Time.fixedDeltaTime);
    }
}
