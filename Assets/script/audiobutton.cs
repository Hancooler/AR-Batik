using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound : MonoBehaviour
{
    public AudioSource audioSource;

    public AudioClip buttonTap;
    public AudioClip buttonClose;
    
    
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void button()
    {
        // audio button

        audioSource.PlayOneShot(buttonTap);
    }
}
