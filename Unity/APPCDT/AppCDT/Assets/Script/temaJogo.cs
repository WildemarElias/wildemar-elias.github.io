using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class temaJogo : MonoBehaviour
{

    public Button       Btn_Play;
    public Text         Txt_Nome_Tema;

    public GameObject   Info_Tema;
    public Text         Txt_Info_Tema;

    public GameObject   Estrela1;
    public GameObject   Estrela2;
    public GameObject   Estrela3;

    public string[]     nomeTema;
    public int          numeroQuestoes;
    private int         idTema;

    public AudioSource Audio;
    public AudioClip soundbotao;

    // Use this for initialization
    void Start()
    {
        idTema = 0;
        Txt_Nome_Tema.text = nomeTema[idTema];
        Txt_Info_Tema.text = "você acertou x de x questões";
        Info_Tema.SetActive(false);
        Estrela1.SetActive(false);
        Estrela2.SetActive(false);
        Estrela3.SetActive(false);
        Btn_Play.interactable = false;
    }


    public void selecioneTema(int i)
    {
        Audio.PlayOneShot(soundbotao);
        idTema = i;
        PlayerPrefs.SetInt("idTema", idTema);
        Txt_Nome_Tema.text = nomeTema[idTema];
        int notaFinal = PlayerPrefs.GetInt("notaFinal" + idTema.ToString());
        int acertos = PlayerPrefs.GetInt("acertos" + idTema.ToString());
        Estrela1.SetActive(false);
        Estrela2.SetActive(false);
        Estrela3.SetActive(false);
        
        if (notaFinal == 10)
        {
            Estrela1.SetActive(true);
            Estrela2.SetActive(true);
            Estrela3.SetActive(true);
        }
        else if (notaFinal >= 7)
        {
            Estrela1.SetActive(true);
            Estrela2.SetActive(true);
            Estrela3.SetActive(false);
        }
        else if (notaFinal >= 5)
        {
            Estrela1.SetActive(true);
            Estrela2.SetActive(false);
            Estrela3.SetActive(false);
        }

        Txt_Info_Tema.text = "você acertou " +acertos.ToString() +" de " + numeroQuestoes.ToString()+" questões";
        Info_Tema.SetActive(true);
        Btn_Play.interactable = true;
    }

    public void jogar()
    {
        Application.LoadLevel("T" + idTema.ToString());
    }
}
