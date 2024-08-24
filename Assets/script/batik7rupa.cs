using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class batik7rupa : MonoBehaviour
{
    public Transform masukanloadingbar;
    [SerializeField]
    private float nilaiSekarang;
    [SerializeField]
    private float nilaiKecepatan;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (nilaiSekarang < 100)
        {
            nilaiSekarang += nilaiKecepatan * Time.deltaTime;
            Debug.Log((int)nilaiSekarang);
        }
        else
        {
            SceneManager.LoadScene("batikunsil");
        }
        masukanloadingbar.GetComponent<Image>().fillAmount = nilaiSekarang / 100f;

        if (nilaiSekarang < 100)
        {
            nilaiSekarang += nilaiKecepatan * Time.deltaTime;
            Debug.Log((int)nilaiSekarang);
        }
        else
        {
            SceneManager.LoadScene("batikgarutan");
        }
        masukanloadingbar.GetComponent<Image>().fillAmount = nilaiSekarang / 100f;
    }
}
