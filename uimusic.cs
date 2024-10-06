using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uimusic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        AudioSource audio = GetComponent<AudioSource>();
        audio.time = 47;
        audio.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
