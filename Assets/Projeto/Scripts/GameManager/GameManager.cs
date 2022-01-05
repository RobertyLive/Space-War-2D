using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Text pontos, cronometro;

    public int valorG, valorM;
    private void Update() {
        cronometro.text = Time.time.ToString("F1");//.ToString("F2");    
    }
}
