using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoader : MonoBehaviour
{
    public GameObject LoaderUI;
  

    public void LoadScene(int index)
    {
        StartCoroutine(LoadScene_Coroutine(index));
    }

   
}