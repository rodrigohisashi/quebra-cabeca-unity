using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tocadorMusica : MonoBehaviour
{
    AudioSource audio2;

    public void playMusica() 
    {
        audio2 = GetComponent<AudioSource>();
        audio2.Play();
    }

    public void stopMusic() 
    {
        // Certifique-se de que você tenha um componente de áudio associado ao GameObject
        AudioSource audio2 = GetComponent<AudioSource>();

        // Verifique se o componente de áudio não é nulo e está tocando
        if (audio2 != null && audio2.isPlaying) 
        {
            audio2.Pause(); // Pausa a reprodução da música
        }
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
