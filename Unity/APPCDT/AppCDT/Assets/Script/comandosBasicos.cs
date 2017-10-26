using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class comandosBasicos : MonoBehaviour {

    public AudioSource Audio;
    public AudioClip soundbotao;
    public static comandosBasicos instance = null;
    public void carregaCena(string nomeCena)
    {

        if (instance == null)
        {
            instance = this;
        }
        
        DontDestroyOnLoad(gameObject);

        //Audio.PlayOneShot(soundbotao);
        Application.LoadLevel (nomeCena);
    }
    

    public void Exit()
    {
        Application.Quit();
    }
}
