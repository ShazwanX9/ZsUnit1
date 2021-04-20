using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectGold : MonoBehaviour
{
    [HideInInspector]
    public static int goldCollected = 0;
    [SerializeField]
    int goldLayer;

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.layer == goldLayer)
            Destroy(other.gameObject);
            goldCollected += 1;
            Debug.Log(goldCollected);
    }

}
