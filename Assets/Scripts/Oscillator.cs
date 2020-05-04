using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator : MonoBehaviour
{
    private void FixedUpdate()
    {
        transform.position = new Vector3(transform.position.x, Mathf.Sin(Time.time * 5), transform.position.z);
    }
}
