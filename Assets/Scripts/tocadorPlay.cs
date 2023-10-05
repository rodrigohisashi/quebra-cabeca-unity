using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tocadorPlay : MonoBehaviour
{
    AudioSource audio2;

    public void playPlay() 
    {
        audio2 = GetComponent<AudioSource>();
        audio2.Play();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
