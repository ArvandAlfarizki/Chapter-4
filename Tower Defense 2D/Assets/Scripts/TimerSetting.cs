using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerSetting : MonoBehaviour
{
    public Text TextTimer;
    public float Waktu = 100;

    public bool Timer = true;

    void SetText()
    {
        int Menit = Mathf.FloorToInt(Waktu / 60);
        int Detik = Mathf.FloorToInt(Waktu % 60);
        TextTimer.text = Menit.ToString("00")+":"+ Detik.ToString("00");
    }
    
    float s;

    // Update is called once per frame
    private void Update()
    {
        
        if (Timer)
        {
                s += Time.deltaTime;
            if(s >=1)
            {
                Waktu++;
                s = 0;
            }
        }

        if(Timer && Waktu >= 200)
        {
            Debug.Log("TimeOut");
            Timer = false;
        }

        SetText();

    }
}
