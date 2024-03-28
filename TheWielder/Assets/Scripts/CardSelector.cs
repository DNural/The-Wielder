using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CardSelector : MonoBehaviour
{
    public GameObject ScrollViewCards;
    public TextMeshProUGUI btnText;
    public bool IsToggled;

    public void ToggleSV()
    {
        if (ScrollViewCards != null)
        {
            bool IsSVActive = ScrollViewCards.activeSelf;
            IsToggled = IsSVActive;
            ScrollViewCards.SetActive(!IsSVActive);
        }
    }

    public void SetText()
    {
        if (IsToggled == false)
        {
            btnText.text = "Hide";
        }
        else
        {
            btnText.text = "Show";
        }
    }
}
