using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class WLevel : MonoBehaviour
{
    public TextMeshProUGUI txtLevel;
    void Awake()
    {
        txtLevel.text = "Level " + SceneManager.GetActiveScene().buildIndex;
    }
}
