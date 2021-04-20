using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetOnCollision : MonoBehaviour
{
    [SerializeField]
    string strTag;

    void OnCollisionEnter(Collision collision) {
        if(collision.collider.tag == strTag) {
            CollectGold.goldCollected = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
