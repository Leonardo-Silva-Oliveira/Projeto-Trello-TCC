using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    float timer = 0f;
    public Text textTimer;

    void Update(){
        timer += Time.deltaTime;
        textTimer.text = FormatTime(timer);
    }

    string FormatTime(float timer){
        int minutes = (int)timer/60;
        int seconds = (int)timer%60;
        return string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
