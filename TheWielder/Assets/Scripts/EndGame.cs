using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndGame : MonoBehaviour
{
    public static float EndTimer;
    public TextMeshProUGUI txtTimer;
    private void Awake()
    {
        float minutes = Mathf.Floor(EndTimer / 60);
        float seconds = Mathf.Floor(EndTimer - (minutes * 60));
        string stMinutes = minutes.ToString();
        string stSeconds = seconds.ToString();
        if (minutes < 10)
        {
            stMinutes = "0" + minutes;
        }
        if (seconds < 10)
        {
            stSeconds = "0" + seconds;
        }
        string stMiliseconds = "0";
        if (EndTimer.ToString().IndexOf(",") > 0)
        {
            stMiliseconds = EndTimer.ToString().Substring(EndTimer.ToString().IndexOf(",") + 1, EndTimer.ToString().Length - (EndTimer.ToString().IndexOf(",") + 1));
        }
        txtTimer.text = stMinutes + ":" + stSeconds + "." + stMiliseconds;
    }
}
