using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    [SerializeField]
    int numOfGold;
    [SerializeField]
    string endSceneName;
    // Update is called once per frame
    void FixedUpdate()
    {
        if (CollectGold.goldCollected == numOfGold) {
            CollectGold.goldCollected = 0;
            SceneManager.LoadScene(endSceneName);
        }
    }
}
