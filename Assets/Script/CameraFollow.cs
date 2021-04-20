using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField]
    Transform transTarget;
    [SerializeField]
    float xOffset, yOffset, zOffset;

    // Update is called once per frame
    void Update()
    {
        // transform.position = transTarget.position;
        transform.position = new Vector3(   transTarget.position.x + xOffset, 
                                            transTarget.position.y + yOffset, 
                                            transTarget.position.z + zOffset    );;
    }
}
