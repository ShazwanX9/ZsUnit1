using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{
    [SerializeField]
    KeyCode ResetKey;
    [SerializeField]
    KeyCode QuitKey;
    [SerializeField]
    string sceneName;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(ResetKey)){
            CollectGold.goldCollected = 0;
            // SceneManager.GetActiveScene().name
            SceneManager.LoadScene(sceneName);
        }
        if (Input.GetKey(QuitKey))
            Application.Quit();
    }
}
