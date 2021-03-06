﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;



public class notaFinal : MonoBehaviour {


    private int idTema;
    public Text txtNota;
    public Text txtInfoTema;
    public GameObject estrela1;
    public GameObject estrela2;
    public GameObject estrela3;

    private int notafinal;
    private int acertos;

    public int numeroQuestoes;

    // Use this for initialization
    void Start () {
        idTema = PlayerPrefs.GetInt("idTema");
        estrela1.SetActive(false);
        estrela2.SetActive(false);
        estrela3.SetActive(false);

        
        notafinal = PlayerPrefs.GetInt("notaFinalTemp"+idTema.ToString());
        acertos = PlayerPrefs.GetInt("acertosTemp" + idTema.ToString());
        txtNota.text = notafinal.ToString();

        txtInfoTema.text = "você acertou " + acertos.ToString() + " de " + numeroQuestoes.ToString() + " questões";
      
        if (notafinal == 10)
        {
            estrela1.SetActive(true);
            estrela2.SetActive(true);
            estrela3.SetActive(true);
        }
        else if(notafinal >= 7)
        {
            estrela1.SetActive(true);
            estrela2.SetActive(true);
            estrela3.SetActive(false);
        }
        else if (notafinal >= 5)
        {
            estrela1.SetActive(true);
            estrela2.SetActive(false);
            estrela3.SetActive(false);
        }

    }
	public void jogarNovamente()
    {
        Application.LoadLevel("T" + idTema.ToString());
    }

}
