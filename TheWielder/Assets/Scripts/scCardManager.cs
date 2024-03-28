using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scCardManager : MonoBehaviour
{
    public GameObject ally0, ally1, ally2, ally3, ally4;
    public GameObject svCardsHolder;
    public GameObject CardManager;
    public GameObject btnHideShow;
    public GameObject btnLock;
    public GameObject AllyArea;
    public GameObject RemainingMana;
    public GameObject btnBattle;
    public int ally0Mana, ally1Mana, ally2Mana, ally3Mana, ally4Mana;
    public int RemainingManaCount;

    void Start()
    {
        RemainingManaCount = int.Parse(RemainingMana.GetComponentInChildren<TextMeshProUGUI>().text);
        ally0Mana = int.Parse(ally0.transform.Find("Mana").GetComponentInChildren<TextMeshProUGUI>().text);
        ally1Mana = int.Parse(ally1.transform.Find("Mana").GetComponentInChildren<TextMeshProUGUI>().text);
        ally2Mana = int.Parse(ally2.transform.Find("Mana").GetComponentInChildren<TextMeshProUGUI>().text);
        ally3Mana = int.Parse(ally3.transform.Find("Mana").GetComponentInChildren<TextMeshProUGUI>().text);
        ally4Mana = int.Parse(ally4.transform.Find("Mana").GetComponentInChildren<TextMeshProUGUI>().text);
    }

    void Update()
    {
        if (RemainingManaCount == 0)
        {
            btnLock_Clicked();
        }
    }

    public void ally0_Clicked()
    {
        if (RemainingManaCount >= ally0Mana && ally0.transform.parent.name == CardManager.name)
        {
            ally0.transform.SetParent(AllyArea.transform, false);
            RemainingManaCount -= ally0Mana;
            RemainingMana.GetComponentInChildren<TextMeshProUGUI>().text = RemainingManaCount.ToString();
            if (BattleManager.cAlly0 == null)
            {
                BattleManager.cAlly0 = ally0;
            }
            else
            {
                if (BattleManager.cAlly1 == null)
                {
                    BattleManager.cAlly1 = ally0;
                }
                else
                {
                    if (BattleManager.cAlly2 == null)
                    {
                        BattleManager.cAlly2 = ally0;
                    }
                    else
                    {
                        if (BattleManager.cAlly3 == null)
                        {
                            BattleManager.cAlly3 = ally0;
                        }
                        else
                        {
                            if (BattleManager.cAlly4 == null)
                            {
                                BattleManager.cAlly4 = ally0;
                            }
                        }
                    }
                }
            }
        }
    }

    public void ally1_Clicked()
    {
        if (RemainingManaCount >= ally1Mana && ally1.transform.parent.name == CardManager.name)
        {
            ally1.transform.SetParent(AllyArea.transform, false);
            RemainingManaCount -= ally1Mana;
            RemainingMana.GetComponentInChildren<TextMeshProUGUI>().text = RemainingManaCount.ToString();
            if (BattleManager.cAlly0 == null)
            {
                BattleManager.cAlly0 = ally1;
            }
            else
            {
                if (BattleManager.cAlly1 == null)
                {
                    BattleManager.cAlly1 = ally1;
                }
                else
                {
                    if (BattleManager.cAlly2 == null)
                    {
                        BattleManager.cAlly2 = ally1;
                    }
                    else
                    {
                        if (BattleManager.cAlly3 == null)
                        {
                            BattleManager.cAlly3 = ally1;
                        }
                        else
                        {
                            if (BattleManager.cAlly4 == null)
                            {
                                BattleManager.cAlly4 = ally1;
                            }
                        }
                    }
                }
            }
        }
    }

    public void ally2_Clicked()
    {
        if (RemainingManaCount >= ally2Mana && ally2.transform.parent.name == CardManager.name)
        {
            ally2.transform.SetParent(AllyArea.transform, false);
            RemainingManaCount -= ally2Mana;
            RemainingMana.GetComponentInChildren<TextMeshProUGUI>().text = RemainingManaCount.ToString();
            if (BattleManager.cAlly0 == null)
            {
                BattleManager.cAlly0 = ally2;
            }
            else
            {
                if (BattleManager.cAlly1 == null)
                {
                    BattleManager.cAlly1 = ally2;
                }
                else
                {
                    if (BattleManager.cAlly2 == null)
                    {
                        BattleManager.cAlly2 = ally2;
                    }
                    else
                    {
                        if (BattleManager.cAlly3 == null)
                        {
                            BattleManager.cAlly3 = ally2;
                        }
                        else
                        {
                            if (BattleManager.cAlly4 == null)
                            {
                                BattleManager.cAlly4 = ally2;
                            }
                        }
                    }
                }
            }
        }
    }

    public void ally3_Clicked()
    {
        if (RemainingManaCount >= ally3Mana && ally3.transform.parent.name == CardManager.name)
        {
            ally3.transform.SetParent(AllyArea.transform, false);
            RemainingManaCount -= ally3Mana;
            RemainingMana.GetComponentInChildren<TextMeshProUGUI>().text = RemainingManaCount.ToString();
            if (BattleManager.cAlly0 == null)
            {
                BattleManager.cAlly0 = ally3;
            }
            else
            {
                if (BattleManager.cAlly1 == null)
                {
                    BattleManager.cAlly1 = ally3;
                }
                else
                {
                    if (BattleManager.cAlly2 == null)
                    {
                        BattleManager.cAlly2 = ally3;
                    }
                    else
                    {
                        if (BattleManager.cAlly3 == null)
                        {
                            BattleManager.cAlly3 = ally3;
                        }
                        else
                        {
                            if (BattleManager.cAlly4 == null)
                            {
                                BattleManager.cAlly4 = ally3;
                            }
                        }
                    }
                }
            }
        }
    }

    public void ally4_Clicked()
    {
        if (RemainingManaCount >= ally4Mana && ally4.transform.parent.name == CardManager.name)
        {
            ally4.transform.SetParent(AllyArea.transform, false);
            RemainingManaCount -= ally4Mana;
            RemainingMana.GetComponentInChildren<TextMeshProUGUI>().text = RemainingManaCount.ToString();
            if (BattleManager.cAlly0 == null)
            {
                BattleManager.cAlly0 = ally4;
            }
            else
            {
                if (BattleManager.cAlly1 == null)
                {
                    BattleManager.cAlly1 = ally4;
                }
                else
                {
                    if (BattleManager.cAlly2 == null)
                    {
                        BattleManager.cAlly2 = ally4;
                    }
                    else
                    {
                        if (BattleManager.cAlly3 == null)
                        {
                            BattleManager.cAlly3 = ally4;
                        }
                        else
                        {
                            if (BattleManager.cAlly4 == null)
                            {
                                BattleManager.cAlly4 = ally4;
                            }
                        }
                    }
                }
            }
        }
    }

    public void btnLock_Clicked()
    {
        svCardsHolder.SetActive(false);
        btnHideShow.SetActive(false);
        btnBattle.SetActive(true);
    }
}
