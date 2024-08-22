using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public Slider loadingBar;
    public GameObject loadingScreen;
    public float loadingTime = 3f; // Adjust the loading time as needed

    bool isLoading;

    void Start()
    {
        // Set the maximum value of the loading bar
        loadingBar.maxValue = loadingTime;
    }

    void Update()
    {
        if (isLoading)
        {
            if (loadingBar.value < loadingBar.maxValue)
            {
                loadingBar.value += Time.deltaTime;
            }
            else
            {
                SceneManager.LoadScene(1);
            }
        }
    }

    public void ButtonLoadScene()
    {
        isLoading = true;
        loadingScreen.SetActive(true);
    }
}