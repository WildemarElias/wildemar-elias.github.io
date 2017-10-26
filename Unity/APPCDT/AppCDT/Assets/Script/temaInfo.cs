using UnityEngine;
using System.Collections;


public class temaInfo : MonoBehaviour {
    public int idTema;
    public GameObject Estrela1;
    public GameObject Estrela2;
    public GameObject Estrela3;
     
    // Use this for initialization
    void Start () {
        Estrela1.SetActive(false);
        Estrela2.SetActive(false);
        Estrela3.SetActive(false);

        int notaFinal = PlayerPrefs.GetInt("notaFinal" + idTema.ToString());
             
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
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
