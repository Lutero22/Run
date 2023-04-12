using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField] private TMP_Text TextoPuntaje;
    [SerializeField] private TMP_Text TextoHiscore;

    private int puntaje;
    private int Hiscore;
    private float tiempo;
    void Start()
    {
        
    }

    void Update()
    {
        

        tiempo += Time.deltaTime;
        puntaje = (int)tiempo;
        TextoPuntaje.text = string.Format("{0:00000}", puntaje);
        TextoHiscore.text = string.Format("{0:00000}", Hiscore);

        Hiscore = PlayerPrefs.GetInt("Save Score", 0);

        if (puntaje > Hiscore)
        {
            Hiscore = puntaje;
            PlayerPrefs.SetInt("Save Score", Hiscore);
        }
    }
}
