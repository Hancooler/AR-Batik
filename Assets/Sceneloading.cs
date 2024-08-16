using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoader : MonoBehaviour
{
    public GameObject LoaderUI;
    public Image Loadingbarfill;

    public void LoadScene(int index)
    {
        StartCoroutine(LoadScene_Coroutine(index));
    }

    IEnumerator LoadScene_Coroutine(int index)
    {
        AsyncOperation Operation = SceneManager.LoadSceneAsync(index);
      
        LoaderUI.SetActive(true);
    
        while (!Operation.isDone)
        {
            float progressValue = Mathf.Clamp01(Operation.progress / 0.9f);

            Loadingbarfill.fillAmount = progressValue;
            yield return null;
        }
    }
}