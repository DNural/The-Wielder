using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class DeclareCards : MonoBehaviour
{
    public GameObject Enemies;
    public GameObject EnemyArea;
    GameObject EnemyCard;
    public GameObject Ally0, Ally1, Ally2, Ally3, Ally4;

    void Awake()
    {
        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            for (int i = 0; i < 2; i++)
            {
                EnemyCard = Instantiate(Enemies, new Vector3(0, 0, 0), Quaternion.identity);
                if (i == 0)
                {
                    EnemyCard.transform.Find("Attack").GetComponentInChildren<TextMeshProUGUI>().text = "3";
                    EnemyCard.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text = "5";
                    BattleManager.cEnemy0 = EnemyCard;
                }
                if (i == 1)
                {
                    EnemyCard.transform.Find("Attack").GetComponentInChildren<TextMeshProUGUI>().text = "5";
                    EnemyCard.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text = "1";
                    BattleManager.cEnemy1 = EnemyCard;
                }
                EnemyCard.transform.SetParent(EnemyArea.transform, false);
            }
            Ally0.transform.Find("Attack").GetComponentInChildren<TextMeshProUGUI>().text = "3";
            Ally0.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text = "2";
            Ally0.transform.Find("Mana").GetComponentInChildren<TextMeshProUGUI>().text = "3";

            Ally1.transform.Find("Attack").GetComponentInChildren<TextMeshProUGUI>().text = "4";
            Ally1.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text = "5";
            Ally1.transform.Find("Mana").GetComponentInChildren<TextMeshProUGUI>().text = "5";

            Ally2.transform.Find("Attack").GetComponentInChildren<TextMeshProUGUI>().text = "1";
            Ally2.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text = "4";
            Ally2.transform.Find("Mana").GetComponentInChildren<TextMeshProUGUI>().text = "2";

            Ally3.transform.Find("Attack").GetComponentInChildren<TextMeshProUGUI>().text = "5";
            Ally3.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text = "2";
            Ally3.transform.Find("Mana").GetComponentInChildren<TextMeshProUGUI>().text = "4";

            Ally4.transform.Find("Attack").GetComponentInChildren<TextMeshProUGUI>().text = "1";
            Ally4.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text = "1";
            Ally4.transform.Find("Mana").GetComponentInChildren<TextMeshProUGUI>().text = "1";
        }
        if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            for (int i = 0; i < 2; i++)
            {
                EnemyCard = Instantiate(Enemies, new Vector3(0, 0, 0), Quaternion.identity);
                if (i == 0)
                {
                    EnemyCard.transform.Find("Attack").GetComponentInChildren<TextMeshProUGUI>().text = "5";
                    EnemyCard.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text = "6";
                    BattleManager.cEnemy0 = EnemyCard;
                }
                if (i == 1)
                {
                    EnemyCard.transform.Find("Attack").GetComponentInChildren<TextMeshProUGUI>().text = "5";
                    EnemyCard.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text = "3";
                    BattleManager.cEnemy1 = EnemyCard;
                }
                EnemyCard.transform.SetParent(EnemyArea.transform, false);
            }
            Ally0.transform.Find("Attack").GetComponentInChildren<TextMeshProUGUI>().text = "3";
            Ally0.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text = "1";
            Ally0.transform.Find("Mana").GetComponentInChildren<TextMeshProUGUI>().text = "2";

            Ally1.transform.Find("Attack").GetComponentInChildren<TextMeshProUGUI>().text = "2";
            Ally1.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text = "2";
            Ally1.transform.Find("Mana").GetComponentInChildren<TextMeshProUGUI>().text = "2";

            Ally2.transform.Find("Attack").GetComponentInChildren<TextMeshProUGUI>().text = "4";
            Ally2.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text = "3";
            Ally2.transform.Find("Mana").GetComponentInChildren<TextMeshProUGUI>().text = "4";

            Ally3.transform.Find("Attack").GetComponentInChildren<TextMeshProUGUI>().text = "2";
            Ally3.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text = "4";
            Ally3.transform.Find("Mana").GetComponentInChildren<TextMeshProUGUI>().text = "3";

            Ally4.transform.Find("Attack").GetComponentInChildren<TextMeshProUGUI>().text = "3";
            Ally4.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text = "6";
            Ally4.transform.Find("Mana").GetComponentInChildren<TextMeshProUGUI>().text = "5";
        }
        if (SceneManager.GetActiveScene().buildIndex == 3)
        {
            for (int i = 0; i < 3; i++)
            {
                EnemyCard = Instantiate(Enemies, new Vector3(0, 0, 0), Quaternion.identity);
                if (i == 0)
                {
                    EnemyCard.transform.Find("Attack").GetComponentInChildren<TextMeshProUGUI>().text = "5";
                    EnemyCard.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text = "4";
                    BattleManager.cEnemy0 = EnemyCard;
                }
                if (i == 1)
                {
                    EnemyCard.transform.Find("Attack").GetComponentInChildren<TextMeshProUGUI>().text = "6";
                    EnemyCard.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text = "2";
                    BattleManager.cEnemy1 = EnemyCard;
                }
                if (i == 2)
                {
                    EnemyCard.transform.Find("Attack").GetComponentInChildren<TextMeshProUGUI>().text = "3";
                    EnemyCard.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text = "4";
                    BattleManager.cEnemy2 = EnemyCard;
                }
                EnemyCard.transform.SetParent(EnemyArea.transform, false);
            }
            Ally0.transform.Find("Attack").GetComponentInChildren<TextMeshProUGUI>().text = "4";
            Ally0.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text = "5";
            Ally0.transform.Find("Mana").GetComponentInChildren<TextMeshProUGUI>().text = "6";

            Ally1.transform.Find("Attack").GetComponentInChildren<TextMeshProUGUI>().text = "2";
            Ally1.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text = "1";
            Ally1.transform.Find("Mana").GetComponentInChildren<TextMeshProUGUI>().text = "2";

            Ally2.transform.Find("Attack").GetComponentInChildren<TextMeshProUGUI>().text = "1";
            Ally2.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text = "1";
            Ally2.transform.Find("Mana").GetComponentInChildren<TextMeshProUGUI>().text = "1";

            Ally3.transform.Find("Attack").GetComponentInChildren<TextMeshProUGUI>().text = "3";
            Ally3.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text = "2";
            Ally3.transform.Find("Mana").GetComponentInChildren<TextMeshProUGUI>().text = "3";

            Ally4.transform.Find("Attack").GetComponentInChildren<TextMeshProUGUI>().text = "5";
            Ally4.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text = "2";
            Ally4.transform.Find("Mana").GetComponentInChildren<TextMeshProUGUI>().text = "4";
        }
        if (SceneManager.GetActiveScene().buildIndex == 4)
        {
            for (int i = 0; i < 3; i++)
            {
                EnemyCard = Instantiate(Enemies, new Vector3(0, 0, 0), Quaternion.identity);
                if (i == 0)
                {
                    EnemyCard.transform.Find("Attack").GetComponentInChildren<TextMeshProUGUI>().text = "4";
                    EnemyCard.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text = "5";
                    BattleManager.cEnemy0 = EnemyCard;
                }
                if (i == 1)
                {
                    EnemyCard.transform.Find("Attack").GetComponentInChildren<TextMeshProUGUI>().text = "3";
                    EnemyCard.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text = "12";
                    BattleManager.cEnemy1 = EnemyCard;
                }
                if (i == 2)
                {
                    EnemyCard.transform.Find("Attack").GetComponentInChildren<TextMeshProUGUI>().text = "9";
                    EnemyCard.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text = "7";
                    BattleManager.cEnemy2 = EnemyCard;
                }
                EnemyCard.transform.SetParent(EnemyArea.transform, false);
            }
            Ally0.transform.Find("Attack").GetComponentInChildren<TextMeshProUGUI>().text = "4";
            Ally0.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text = "1";
            Ally0.transform.Find("Mana").GetComponentInChildren<TextMeshProUGUI>().text = "2";

            Ally1.transform.Find("Attack").GetComponentInChildren<TextMeshProUGUI>().text = "3";
            Ally1.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text = "1";
            Ally1.transform.Find("Mana").GetComponentInChildren<TextMeshProUGUI>().text = "1";

            Ally2.transform.Find("Attack").GetComponentInChildren<TextMeshProUGUI>().text = "4";
            Ally2.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text = "8";
            Ally2.transform.Find("Mana").GetComponentInChildren<TextMeshProUGUI>().text = "4";

            Ally3.transform.Find("Attack").GetComponentInChildren<TextMeshProUGUI>().text = "5";
            Ally3.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text = "1";
            Ally3.transform.Find("Mana").GetComponentInChildren<TextMeshProUGUI>().text = "3";

            Ally4.transform.Find("Attack").GetComponentInChildren<TextMeshProUGUI>().text = "4";
            Ally4.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text = "1";
            Ally4.transform.Find("Mana").GetComponentInChildren<TextMeshProUGUI>().text = "2";
        }
        if (SceneManager.GetActiveScene().buildIndex == 5)
        {
            for (int i = 0; i < 5; i++)
            {
                EnemyCard = Instantiate(Enemies, new Vector3(0, 0, 0), Quaternion.identity);
                if (i == 0)
                {
                    EnemyCard.transform.Find("Attack").GetComponentInChildren<TextMeshProUGUI>().text = "15";
                    EnemyCard.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text = "10";
                    BattleManager.cEnemy0 = EnemyCard;
                }
                if (i == 1)
                {
                    EnemyCard.transform.Find("Attack").GetComponentInChildren<TextMeshProUGUI>().text = "9";
                    EnemyCard.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text = "5";
                    BattleManager.cEnemy1 = EnemyCard;
                }
                if (i == 2)
                {
                    EnemyCard.transform.Find("Attack").GetComponentInChildren<TextMeshProUGUI>().text = "2";
                    EnemyCard.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text = "5";
                    BattleManager.cEnemy2 = EnemyCard;
                }
                if (i == 3)
                {
                    EnemyCard.transform.Find("Attack").GetComponentInChildren<TextMeshProUGUI>().text = "6";
                    EnemyCard.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text = "6";
                    BattleManager.cEnemy3 = EnemyCard;
                }
                if (i == 4)
                {
                    EnemyCard.transform.Find("Attack").GetComponentInChildren<TextMeshProUGUI>().text = "9";
                    EnemyCard.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text = "2";
                    BattleManager.cEnemy4 = EnemyCard;
                }
                EnemyCard.transform.SetParent(EnemyArea.transform, false);
            }
            Ally0.transform.Find("Attack").GetComponentInChildren<TextMeshProUGUI>().text = "3";
            Ally0.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text = "10";
            Ally0.transform.Find("Mana").GetComponentInChildren<TextMeshProUGUI>().text = "3";

            Ally1.transform.Find("Attack").GetComponentInChildren<TextMeshProUGUI>().text = "5";
            Ally1.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text = "5";
            Ally1.transform.Find("Mana").GetComponentInChildren<TextMeshProUGUI>().text = "3";

            Ally2.transform.Find("Attack").GetComponentInChildren<TextMeshProUGUI>().text = "2";
            Ally2.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text = "2";
            Ally2.transform.Find("Mana").GetComponentInChildren<TextMeshProUGUI>().text = "1";

            Ally3.transform.Find("Attack").GetComponentInChildren<TextMeshProUGUI>().text = "2";
            Ally3.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text = "3";
            Ally3.transform.Find("Mana").GetComponentInChildren<TextMeshProUGUI>().text = "2";

            Ally4.transform.Find("Attack").GetComponentInChildren<TextMeshProUGUI>().text = "10";
            Ally4.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text = "8";
            Ally4.transform.Find("Mana").GetComponentInChildren<TextMeshProUGUI>().text = "6";
        }
    }

    public void Enemy_Click()
    {
        Debug.Log(EnemyCard.transform.Find("Attack").GetComponentInChildren<TextMeshProUGUI>().text);
    }
}
