using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereDropper : MonoBehaviour
{
    [SerializeField] List<GameObject> sphereList;
    [SerializeField] float dropFrequency;

    float[] spawnPositions = { -4f, 4f };

    private void Start()
    {
        InvokeRepeating("StartDroppingSpheres", 2.0f, dropFrequency);
    }

    private void StartDroppingSpheres()
    {
        int randomSphereType = Random.Range(0, sphereList.Count);
        float pickedPos = spawnPositions[Random.Range(0, spawnPositions.Length)];
        
        var newSphere = Instantiate(sphereList[randomSphereType], new Vector3(pickedPos, 5f, 0f), Quaternion.identity);
        newSphere.transform.parent = gameObject.transform;
    }
}
