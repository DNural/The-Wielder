using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BattleManager : MonoBehaviour
{
    public static GameObject cAlly0, cAlly1, cAlly2, cAlly3, cAlly4;
    public static GameObject cEnemy0, cEnemy1, cEnemy2, cEnemy3, cEnemy4;
    public GameObject btnBattle;
    public GameObject pnlWin;
    public GameObject pnlLose;
    public bool IsAttacking = false;
    public bool movingForward, movingBackward = false;
    public float cardSpeed = 0;
    Vector3 StartPoint0, StartPoint1, StartPoint2, StartPoint3, StartPoint4;
    int cAlly0Health, cAlly0Attack;
    int cAlly1Health, cAlly1Attack;
    int cAlly2Health, cAlly2Attack;
    int cAlly3Health, cAlly3Attack;
    int cAlly4Health, cAlly4Attack;
    int cEnemy0Health, cEnemy0Attack;
    int cEnemy1Health, cEnemy1Attack;
    int cEnemy2Health, cEnemy2Attack;
    int cEnemy3Health, cEnemy3Attack;
    int cEnemy4Health, cEnemy4Attack;

    public void Attack()
    {
        if (cAlly0 != null)
        {
            StartPoint0 = cAlly0.transform.position;
            cAlly0Health = int.Parse(cAlly0.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text);
            cAlly0Attack = int.Parse(cAlly0.transform.Find("Attack").GetComponentInChildren<TextMeshProUGUI>().text);
        }
        if (cAlly1 != null)
        {
            cAlly1Health = int.Parse(cAlly1.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text);
            cAlly1Attack = int.Parse(cAlly1.transform.Find("Attack").GetComponentInChildren<TextMeshProUGUI>().text);
        }
        if (cAlly2 != null)
        {
            cAlly2Health = int.Parse(cAlly2.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text);
            cAlly2Attack = int.Parse(cAlly2.transform.Find("Attack").GetComponentInChildren<TextMeshProUGUI>().text);
        }
        if (cAlly3 != null)
        {
            cAlly3Health = int.Parse(cAlly3.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text);
            cAlly3Attack = int.Parse(cAlly3.transform.Find("Attack").GetComponentInChildren<TextMeshProUGUI>().text);
        }
        if (cAlly4 != null)
        {
            cAlly4Health = int.Parse(cAlly4.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text);
            cAlly4Attack = int.Parse(cAlly4.transform.Find("Attack").GetComponentInChildren<TextMeshProUGUI>().text);
        }
        IsAttacking = true;
        movingForward = true;
        btnBattle.SetActive(false);
    }

    private void FixedUpdate()
    {
        if (movingForward == false && movingBackward == false)
        {
            if (cAlly0 == null && cAlly1 != null)
            {
                StartPoint1 = cAlly1.transform.position;
            }
            if (cAlly1 == null && cAlly2 != null)
            {
                StartPoint2 = cAlly2.transform.position;
            }
            if (cAlly2 == null && cAlly3 != null)
            {
                StartPoint3 = cAlly3.transform.position;
            }
            if (cAlly3 == null && cAlly4 != null)
            {
                StartPoint4 = cAlly4.transform.position;
            }
            movingForward = true;
        }
        if (IsAttacking == true)
        {
            if (cAlly0 != null)
            {
                onAttackAlly0();
            }
            else
            {
                if (cAlly1 != null)
                {
                    onAttackAlly1();
                }
                else
                {
                    if (cAlly2 != null)
                    {
                        onAttackAlly2();
                    }
                    else
                    {
                        if (cAlly3 != null)
                        {
                            onAttackAlly3();
                        }
                        else
                        {
                            if (cAlly4 != null)
                            {
                                onAttackAlly4();
                            }
                        }
                    }
                }
            }
            if (cEnemy0 == null && cEnemy1 == null && cEnemy2 == null && cEnemy3 == null && cEnemy4 == null)
            {
                IsAttacking = false;
                pnlWin.SetActive(true);
                SoundManagerScript.PlaySound("Victory");
            }
            else
            {
                if (cAlly0 == null && cAlly1 == null && cAlly2 == null && cAlly3 == null && cAlly4 == null)
                {
                    IsAttacking = false;
                    pnlLose.SetActive(true);
                    SoundManagerScript.PlaySound("Defeat");
                }
            }
        }
    }

    private void onAttackAlly0()
    {
        if (cEnemy0 != null)
        {
            if (IsAttacking == true)
            {
                if (movingForward == true)
                {
                    cAlly0.transform.position = Vector2.MoveTowards(cAlly0.transform.position, cEnemy0.transform.position, cardSpeed * Time.deltaTime);
                    cEnemy0Health = int.Parse(cEnemy0.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text);
                    cEnemy0Attack = int.Parse(cEnemy0.transform.Find("Attack").GetComponentInChildren<TextMeshProUGUI>().text);
                    if (cAlly0.transform.position == cEnemy0.transform.position)
                    {
                        movingBackward = true;
                        movingForward = false;
                        cAlly0Health -= cEnemy0Attack;
                        cAlly0.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text = cAlly0Health.ToString();
                        cEnemy0Health -= cAlly0Attack;
                        cEnemy0.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text = cEnemy0Health.ToString();
                    }
                }
                else if (movingBackward == true)
                {
                    cAlly0.transform.position = Vector2.MoveTowards(cAlly0.transform.position, StartPoint0, cardSpeed * Time.deltaTime);
                    if (cAlly0.transform.position == StartPoint0)
                    {
                        movingBackward = false;
                        if (cEnemy0Health <= 0)
                        {
                            Destroy(cEnemy0);
                        }
                        if (cAlly0Health <= 0)
                        {
                            Destroy(cAlly0);
                        }
                    }
                }
            }
        }
        if (cEnemy0 == null && cEnemy1 != null)
        {
            if (IsAttacking == true)
            {
                if (movingForward == true)
                {
                    cAlly0.transform.position = Vector2.MoveTowards(cAlly0.transform.position, cEnemy1.transform.position, cardSpeed * Time.deltaTime);
                    cEnemy1Health = int.Parse(cEnemy1.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text);
                    cEnemy1Attack = int.Parse(cEnemy1.transform.Find("Attack").GetComponentInChildren<TextMeshProUGUI>().text);
                    if (cAlly0.transform.position == cEnemy1.transform.position)
                    {
                        movingBackward = true;
                        movingForward = false;
                        cAlly0Health -= cEnemy1Attack;
                        cAlly0.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text = cAlly0Health.ToString();
                        cEnemy1Health -= cAlly0Attack;
                        cEnemy1.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text = cEnemy1Health.ToString();
                    }
                }
                else if (movingBackward == true)
                {
                    cAlly0.transform.position = Vector2.MoveTowards(cAlly0.transform.position, StartPoint0, cardSpeed * Time.deltaTime);
                    if (cAlly0.transform.position == StartPoint0)
                    {
                        movingBackward = false;
                        if (cEnemy1Health <= 0)
                        {
                            Destroy(cEnemy1);
                        }
                        if (cAlly0Health <= 0)
                        {
                            Destroy(cAlly0);
                        }
                    }
                }
            }
        }
        if (cEnemy1 == null && cEnemy2 != null)
        {
            if (IsAttacking == true)
            {
                if (movingForward == true)
                {
                    cAlly0.transform.position = Vector2.MoveTowards(cAlly0.transform.position, cEnemy2.transform.position, cardSpeed * Time.deltaTime);
                    cEnemy2Health = int.Parse(cEnemy2.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text);
                    cEnemy2Attack = int.Parse(cEnemy2.transform.Find("Attack").GetComponentInChildren<TextMeshProUGUI>().text);
                    if (cAlly0.transform.position == cEnemy2.transform.position)
                    {
                        movingBackward = true;
                        movingForward = false;
                        cAlly0Health -= cEnemy2Attack;
                        cAlly0.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text = cAlly0Health.ToString();
                        cEnemy2Health -= cAlly0Attack;
                        cEnemy2.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text = cEnemy2Health.ToString();
                    }
                }
                else if (movingBackward == true)
                {
                    cAlly0.transform.position = Vector2.MoveTowards(cAlly0.transform.position, StartPoint0, cardSpeed * Time.deltaTime);
                    if (cAlly0.transform.position == StartPoint0)
                    {
                        movingBackward = false;
                        if (cEnemy2Health <= 0)
                        {
                            Destroy(cEnemy2);
                        }
                        if (cAlly0Health <= 0)
                        {
                            Destroy(cAlly0);
                        }
                    }
                }
            }
        }
        if (cEnemy2 == null && cEnemy3 != null)
        {
            if (IsAttacking == true)
            {
                if (movingForward == true)
                {
                    cAlly0.transform.position = Vector2.MoveTowards(cAlly0.transform.position, cEnemy3.transform.position, cardSpeed * Time.deltaTime);
                    cEnemy3Health = int.Parse(cEnemy3.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text);
                    cEnemy3Attack = int.Parse(cEnemy3.transform.Find("Attack").GetComponentInChildren<TextMeshProUGUI>().text);
                    if (cAlly0.transform.position == cEnemy3.transform.position)
                    {
                        movingBackward = true;
                        movingForward = false;
                        cAlly0Health -= cEnemy3Attack;
                        cAlly0.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text = cAlly0Health.ToString();
                        cEnemy3Health -= cAlly0Attack;
                        cEnemy3.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text = cEnemy3Health.ToString();
                    }
                }
                else if (movingBackward == true)
                {
                    cAlly0.transform.position = Vector2.MoveTowards(cAlly0.transform.position, StartPoint0, cardSpeed * Time.deltaTime);
                    if (cAlly0.transform.position == StartPoint0)
                    {
                        movingBackward = false;
                        if (cEnemy3Health <= 0)
                        {
                            Destroy(cEnemy3);
                        }
                        if (cAlly0Health <= 0)
                        {
                            Destroy(cAlly0);
                        }
                    }
                }
            }
        }
        if (cEnemy3 == null && cEnemy4 != null)
        {
            if (IsAttacking == true)
            {
                if (movingForward == true)
                {
                    cAlly0.transform.position = Vector2.MoveTowards(cAlly0.transform.position, cEnemy4.transform.position, cardSpeed * Time.deltaTime);
                    cEnemy4Health = int.Parse(cEnemy4.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text);
                    cEnemy4Attack = int.Parse(cEnemy4.transform.Find("Attack").GetComponentInChildren<TextMeshProUGUI>().text);
                    if (cAlly0.transform.position == cEnemy4.transform.position)
                    {
                        movingBackward = true;
                        movingForward = false;
                        cAlly0Health -= cEnemy4Attack;
                        cAlly0.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text = cAlly0Health.ToString();
                        cEnemy4Health -= cAlly0Attack;
                        cEnemy4.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text = cEnemy4Health.ToString();
                    }
                }
                else if (movingBackward == true)
                {
                    cAlly0.transform.position = Vector2.MoveTowards(cAlly0.transform.position, StartPoint0, cardSpeed * Time.deltaTime);
                    if (cAlly0.transform.position == StartPoint0)
                    {
                        movingBackward = false;
                        if (cEnemy4Health <= 0)
                        {
                            Destroy(cEnemy4);
                        }
                        if (cAlly0Health <= 0)
                        {
                            Destroy(cAlly0);
                        }
                    }
                }
            }
        }
    }

    private void onAttackAlly1()
    {
        if (cEnemy0 != null)
        {
            if (IsAttacking == true)
            {
                if (movingForward == true)
                {
                    cAlly1.transform.position = Vector2.MoveTowards(cAlly1.transform.position, cEnemy0.transform.position, cardSpeed * Time.deltaTime);
                    cEnemy0Health = int.Parse(cEnemy0.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text);
                    cEnemy0Attack = int.Parse(cEnemy0.transform.Find("Attack").GetComponentInChildren<TextMeshProUGUI>().text);
                    if (cAlly1.transform.position == cEnemy0.transform.position)
                    {
                        movingBackward = true;
                        movingForward = false;
                        cAlly1Health -= cEnemy0Attack;
                        cAlly1.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text = cAlly1Health.ToString();
                        cEnemy0Health -= cAlly1Attack;
                        cEnemy0.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text = cEnemy0Health.ToString();
                    }
                }
                if (movingBackward == true)
                {
                    cAlly1.transform.position = Vector2.MoveTowards(cAlly1.transform.position, StartPoint1, cardSpeed * Time.deltaTime);
                    if (cAlly1.transform.position == StartPoint1)
                    {
                        movingBackward = false;
                        if (cEnemy0Health <= 0)
                        {
                            Destroy(cEnemy0);
                        }
                        if (cAlly1Health <= 0)
                        {
                            Destroy(cAlly1);
                        }
                    }
                }
            }
        }
        if (cEnemy0 == null && cEnemy1 != null)
        {
            if (IsAttacking == true)
            {
                if (movingForward == true)
                {
                    cAlly1.transform.position = Vector2.MoveTowards(cAlly1.transform.position, cEnemy1.transform.position, cardSpeed * Time.deltaTime);
                    cEnemy1Health = int.Parse(cEnemy1.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text);
                    cEnemy1Attack = int.Parse(cEnemy1.transform.Find("Attack").GetComponentInChildren<TextMeshProUGUI>().text);
                    if (cAlly1.transform.position == cEnemy1.transform.position)
                    {
                        movingBackward = true;
                        movingForward = false;
                        cAlly1Health -= cEnemy1Attack;
                        cAlly1.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text = cAlly1Health.ToString();
                        cEnemy1Health -= cAlly1Attack;
                        cEnemy1.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text = cEnemy1Health.ToString();
                    }
                }
                if (movingBackward == true)
                {
                    cAlly1.transform.position = Vector2.MoveTowards(cAlly1.transform.position, StartPoint1, cardSpeed * Time.deltaTime);
                    if (cAlly1.transform.position == StartPoint1)
                    {
                        movingBackward = false;
                        if (cEnemy1Health <= 0)
                        {
                            Destroy(cEnemy1);
                        }
                        if (cAlly1Health <= 0)
                        {
                            Destroy(cAlly1);
                        }
                    }
                }
            }
        }
        if (cEnemy1 == null && cEnemy2 != null)
        {
            if (IsAttacking == true)
            {
                if (movingForward == true)
                {
                    cAlly1.transform.position = Vector2.MoveTowards(cAlly1.transform.position, cEnemy2.transform.position, cardSpeed * Time.deltaTime);
                    cEnemy2Health = int.Parse(cEnemy2.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text);
                    cEnemy2Attack = int.Parse(cEnemy2.transform.Find("Attack").GetComponentInChildren<TextMeshProUGUI>().text);
                    if (cAlly1.transform.position == cEnemy2.transform.position)
                    {
                        movingBackward = true;
                        movingForward = false;
                        cAlly1Health -= cEnemy2Attack;
                        cAlly1.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text = cAlly1Health.ToString();
                        cEnemy2Health -= cAlly1Attack;
                        cEnemy2.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text = cEnemy2Health.ToString();
                    }
                }
                if (movingBackward == true)
                {
                    cAlly1.transform.position = Vector2.MoveTowards(cAlly1.transform.position, StartPoint1, cardSpeed * Time.deltaTime);
                    if (cAlly1.transform.position == StartPoint1)
                    {
                        movingBackward = false;
                        if (cEnemy2Health <= 0)
                        {
                            Destroy(cEnemy2);
                        }
                        if (cAlly1Health <= 0)
                        {
                            Destroy(cAlly1);
                        }
                    }
                }
            }
        }
        if (cEnemy2 == null && cEnemy3 != null)
        {
            if (IsAttacking == true)
            {
                if (movingForward == true)
                {
                    cAlly1.transform.position = Vector2.MoveTowards(cAlly1.transform.position, cEnemy3.transform.position, cardSpeed * Time.deltaTime);
                    cEnemy3Health = int.Parse(cEnemy3.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text);
                    cEnemy3Attack = int.Parse(cEnemy3.transform.Find("Attack").GetComponentInChildren<TextMeshProUGUI>().text);
                    if (cAlly1.transform.position == cEnemy3.transform.position)
                    {
                        movingBackward = true;
                        movingForward = false;
                        cAlly1Health -= cEnemy3Attack;
                        cAlly1.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text = cAlly1Health.ToString();
                        cEnemy3Health -= cAlly1Attack;
                        cEnemy3.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text = cEnemy3Health.ToString();
                    }
                }
                if (movingBackward == true)
                {
                    cAlly1.transform.position = Vector2.MoveTowards(cAlly1.transform.position, StartPoint1, cardSpeed * Time.deltaTime);
                    if (cAlly1.transform.position == StartPoint1)
                    {
                        movingBackward = false;
                        if (cEnemy3Health <= 0)
                        {
                            Destroy(cEnemy3);
                        }
                        if (cAlly1Health <= 0)
                        {
                            Destroy(cAlly1);
                        }
                    }
                }
            }
        }
        if (cEnemy3 == null && cEnemy4 != null)
        {
            if (IsAttacking == true)
            {
                if (movingForward == true)
                {
                    cAlly1.transform.position = Vector2.MoveTowards(cAlly1.transform.position, cEnemy4.transform.position, cardSpeed * Time.deltaTime);
                    cEnemy4Health = int.Parse(cEnemy4.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text);
                    cEnemy4Attack = int.Parse(cEnemy4.transform.Find("Attack").GetComponentInChildren<TextMeshProUGUI>().text);
                    if (cAlly1.transform.position == cEnemy4.transform.position)
                    {
                        movingBackward = true;
                        movingForward = false;
                        cAlly1Health -= cEnemy4Attack;
                        cAlly1.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text = cAlly1Health.ToString();
                        cEnemy4Health -= cAlly1Attack;
                        cEnemy4.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text = cEnemy4Health.ToString();
                    }
                }
                if (movingBackward == true)
                {
                    cAlly1.transform.position = Vector2.MoveTowards(cAlly1.transform.position, StartPoint1, cardSpeed * Time.deltaTime);
                    if (cAlly1.transform.position == StartPoint1)
                    {
                        movingBackward = false;
                        if (cEnemy4Health <= 0)
                        {
                            Destroy(cEnemy4);
                        }
                        if (cAlly1Health <= 0)
                        {
                            Destroy(cAlly1);
                        }
                    }
                }
            }
        }
    }

    private void onAttackAlly2()
    {
        if (cEnemy0 != null)
        {
            if (IsAttacking == true)
            {
                if (movingForward == true)
                {
                    cAlly2.transform.position = Vector2.MoveTowards(cAlly2.transform.position, cEnemy0.transform.position, cardSpeed * Time.deltaTime);
                    cEnemy0Health = int.Parse(cEnemy0.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text);
                    cEnemy0Attack = int.Parse(cEnemy0.transform.Find("Attack").GetComponentInChildren<TextMeshProUGUI>().text);
                    if (cAlly2.transform.position == cEnemy0.transform.position)
                    {
                        movingBackward = true;
                        movingForward = false;
                        cAlly2Health -= cEnemy0Attack;
                        cAlly2.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text = cAlly2Health.ToString();
                        cEnemy0Health -= cAlly2Attack;
                        cEnemy0.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text = cEnemy0Health.ToString();
                    }
                }
                if (movingBackward == true)
                {
                    cAlly2.transform.position = Vector2.MoveTowards(cAlly2.transform.position, StartPoint2, cardSpeed * Time.deltaTime);
                    if (cAlly2.transform.position == StartPoint2)
                    {
                        movingBackward = false;
                        if (cEnemy0Health <= 0)
                        {
                            Destroy(cEnemy0);
                        }
                        if (cAlly2Health <= 0)
                        {
                            Destroy(cAlly2);
                        }
                    }
                }
            }
        }
        if (cEnemy0 == null && cEnemy1 != null)
        {
            if (IsAttacking == true)
            {
                if (movingForward == true)
                {
                    cAlly2.transform.position = Vector2.MoveTowards(cAlly2.transform.position, cEnemy1.transform.position, cardSpeed * Time.deltaTime);
                    cEnemy1Health = int.Parse(cEnemy1.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text);
                    cEnemy1Attack = int.Parse(cEnemy1.transform.Find("Attack").GetComponentInChildren<TextMeshProUGUI>().text);
                    if (cAlly2.transform.position == cEnemy1.transform.position)
                    {
                        movingBackward = true;
                        movingForward = false;
                        cAlly2Health -= cEnemy1Attack;
                        cAlly2.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text = cAlly2Health.ToString();
                        cEnemy1Health -= cAlly2Attack;
                        cEnemy1.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text = cEnemy1Health.ToString();
                    }
                }
                if (movingBackward == true)
                {
                    cAlly2.transform.position = Vector2.MoveTowards(cAlly2.transform.position, StartPoint2, cardSpeed * Time.deltaTime);
                    if (cAlly2.transform.position == StartPoint2)
                    {
                        movingBackward = false;
                        if (cEnemy1Health <= 0)
                        {
                            Destroy(cEnemy1);
                        }
                        if (cAlly2Health <= 0)
                        {
                            Destroy(cAlly2);
                        }
                    }
                }
            }
        }
        if (cEnemy1 == null && cEnemy2 != null)
        {
            if (IsAttacking == true)
            {
                if (movingForward == true)
                {
                    cAlly2.transform.position = Vector2.MoveTowards(cAlly2.transform.position, cEnemy2.transform.position, cardSpeed * Time.deltaTime);
                    cEnemy2Health = int.Parse(cEnemy2.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text);
                    cEnemy2Attack = int.Parse(cEnemy2.transform.Find("Attack").GetComponentInChildren<TextMeshProUGUI>().text);
                    if (cAlly2.transform.position == cEnemy2.transform.position)
                    {
                        movingBackward = true;
                        movingForward = false;
                        cAlly2Health -= cEnemy2Attack;
                        cAlly2.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text = cAlly2Health.ToString();
                        cEnemy2Health -= cAlly2Attack;
                        cEnemy2.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text = cEnemy2Health.ToString();
                    }
                }
                if (movingBackward == true)
                {
                    cAlly2.transform.position = Vector2.MoveTowards(cAlly2.transform.position, StartPoint2, cardSpeed * Time.deltaTime);
                    if (cAlly2.transform.position == StartPoint2)
                    {
                        movingBackward = false;
                        if (cEnemy2Health <= 0)
                        {
                            Destroy(cEnemy2);
                        }
                        if (cAlly2Health <= 0)
                        {
                            Destroy(cAlly2);
                        }
                    }
                }
            }
        }
        if (cEnemy2 == null && cEnemy3 != null)
        {
            if (IsAttacking == true)
            {
                if (movingForward == true)
                {
                    cAlly2.transform.position = Vector2.MoveTowards(cAlly2.transform.position, cEnemy3.transform.position, cardSpeed * Time.deltaTime);
                    cEnemy3Health = int.Parse(cEnemy3.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text);
                    cEnemy3Attack = int.Parse(cEnemy3.transform.Find("Attack").GetComponentInChildren<TextMeshProUGUI>().text);
                    if (cAlly2.transform.position == cEnemy3.transform.position)
                    {
                        movingBackward = true;
                        movingForward = false;
                        cAlly2Health -= cEnemy3Attack;
                        cAlly2.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text = cAlly2Health.ToString();
                        cEnemy3Health -= cAlly2Attack;
                        cEnemy3.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text = cEnemy3Health.ToString();
                    }
                }
                if (movingBackward == true)
                {
                    cAlly2.transform.position = Vector2.MoveTowards(cAlly2.transform.position, StartPoint2, cardSpeed * Time.deltaTime);
                    if (cAlly2.transform.position == StartPoint2)
                    {
                        movingBackward = false;
                        if (cEnemy3Health <= 0)
                        {
                            Destroy(cEnemy3);
                        }
                        if (cAlly2Health <= 0)
                        {
                            Destroy(cAlly2);
                        }
                    }
                }
            }
        }
        if (cEnemy3 == null && cEnemy4 != null)
        {
            if (IsAttacking == true)
            {
                if (movingForward == true)
                {
                    cAlly2.transform.position = Vector2.MoveTowards(cAlly2.transform.position, cEnemy4.transform.position, cardSpeed * Time.deltaTime);
                    cEnemy4Health = int.Parse(cEnemy4.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text);
                    cEnemy4Attack = int.Parse(cEnemy4.transform.Find("Attack").GetComponentInChildren<TextMeshProUGUI>().text);
                    if (cAlly2.transform.position == cEnemy4.transform.position)
                    {
                        movingBackward = true;
                        movingForward = false;
                        cAlly2Health -= cEnemy4Attack;
                        cAlly2.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text = cAlly2Health.ToString();
                        cEnemy4Health -= cAlly2Attack;
                        cEnemy4.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text = cEnemy4Health.ToString();
                    }
                }
                if (movingBackward == true)
                {
                    cAlly2.transform.position = Vector2.MoveTowards(cAlly2.transform.position, StartPoint2, cardSpeed * Time.deltaTime);
                    if (cAlly2.transform.position == StartPoint2)
                    {
                        movingBackward = false;
                        if (cEnemy4Health <= 0)
                        {
                            Destroy(cEnemy4);
                        }
                        if (cAlly2Health <= 0)
                        {
                            Destroy(cAlly2);
                        }
                    }
                }
            }
        }
    }

    private void onAttackAlly3()
    {
        if (cEnemy0 != null)
        {
            if (IsAttacking == true)
            {
                if (movingForward == true)
                {
                    cAlly3.transform.position = Vector2.MoveTowards(cAlly3.transform.position, cEnemy0.transform.position, cardSpeed * Time.deltaTime);
                    cEnemy0Health = int.Parse(cEnemy0.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text);
                    cEnemy0Attack = int.Parse(cEnemy0.transform.Find("Attack").GetComponentInChildren<TextMeshProUGUI>().text);
                    if (cAlly3.transform.position == cEnemy0.transform.position)
                    {
                        movingBackward = true;
                        movingForward = false;
                        cAlly3Health -= cEnemy0Attack;
                        cAlly3.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text = cAlly3Health.ToString();
                        cEnemy0Health -= cAlly3Attack;
                        cEnemy0.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text = cEnemy0Health.ToString();
                    }
                }
                if (movingBackward == true)
                {
                    cAlly3.transform.position = Vector2.MoveTowards(cAlly3.transform.position, StartPoint3, cardSpeed * Time.deltaTime);
                    if (cAlly3.transform.position == StartPoint3)
                    {
                        movingBackward = false;
                        if (cEnemy0Health <= 0)
                        {
                            Destroy(cEnemy0);
                        }
                        if (cAlly3Health <= 0)
                        {
                            Destroy(cAlly3);
                        }
                    }
                }
            }
        }
        if (cEnemy0 == null && cEnemy1 != null)
        {
            if (IsAttacking == true)
            {
                if (movingForward == true)
                {
                    cAlly3.transform.position = Vector2.MoveTowards(cAlly3.transform.position, cEnemy1.transform.position, cardSpeed * Time.deltaTime);
                    cEnemy1Health = int.Parse(cEnemy1.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text);
                    cEnemy1Attack = int.Parse(cEnemy1.transform.Find("Attack").GetComponentInChildren<TextMeshProUGUI>().text);
                    if (cAlly3.transform.position == cEnemy1.transform.position)
                    {
                        movingBackward = true;
                        movingForward = false;
                        cAlly3Health -= cEnemy1Attack;
                        cAlly3.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text = cAlly3Health.ToString();
                        cEnemy1Health -= cAlly3Attack;
                        cEnemy1.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text = cEnemy1Health.ToString();
                    }
                }
                if (movingBackward == true)
                {
                    cAlly3.transform.position = Vector2.MoveTowards(cAlly3.transform.position, StartPoint3, cardSpeed * Time.deltaTime);
                    if (cAlly3.transform.position == StartPoint3)
                    {
                        movingBackward = false;
                        if (cEnemy1Health <= 0)
                        {
                            Destroy(cEnemy1);
                        }
                        if (cAlly3Health <= 0)
                        {
                            Destroy(cAlly3);
                        }
                    }
                }
            }
        }
        if (cEnemy1 == null && cEnemy2 != null)
        {
            if (IsAttacking == true)
            {
                if (movingForward == true)
                {
                    cAlly3.transform.position = Vector2.MoveTowards(cAlly3.transform.position, cEnemy2.transform.position, cardSpeed * Time.deltaTime);
                    cEnemy2Health = int.Parse(cEnemy2.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text);
                    cEnemy2Attack = int.Parse(cEnemy2.transform.Find("Attack").GetComponentInChildren<TextMeshProUGUI>().text);
                    if (cAlly3.transform.position == cEnemy2.transform.position)
                    {
                        movingBackward = true;
                        movingForward = false;
                        cAlly3Health -= cEnemy2Attack;
                        cAlly3.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text = cAlly3Health.ToString();
                        cEnemy2Health -= cAlly3Attack;
                        cEnemy2.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text = cEnemy2Health.ToString();
                    }
                }
                if (movingBackward == true)
                {
                    cAlly3.transform.position = Vector2.MoveTowards(cAlly3.transform.position, StartPoint3, cardSpeed * Time.deltaTime);
                    if (cAlly3.transform.position == StartPoint3)
                    {
                        movingBackward = false;
                        if (cEnemy2Health <= 0)
                        {
                            Destroy(cEnemy2);
                        }
                        if (cAlly3Health <= 0)
                        {
                            Destroy(cAlly3);
                        }
                    }
                }
            }
        }
        if (cEnemy2 == null && cEnemy3 != null)
        {
            if (IsAttacking == true)
            {
                if (movingForward == true)
                {
                    cAlly3.transform.position = Vector2.MoveTowards(cAlly3.transform.position, cEnemy3.transform.position, cardSpeed * Time.deltaTime);
                    cEnemy3Health = int.Parse(cEnemy3.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text);
                    cEnemy3Attack = int.Parse(cEnemy3.transform.Find("Attack").GetComponentInChildren<TextMeshProUGUI>().text);
                    if (cAlly3.transform.position == cEnemy3.transform.position)
                    {
                        movingBackward = true;
                        movingForward = false;
                        cAlly3Health -= cEnemy3Attack;
                        cAlly3.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text = cAlly3Health.ToString();
                        cEnemy3Health -= cAlly3Attack;
                        cEnemy3.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text = cEnemy3Health.ToString();
                    }
                }
                if (movingBackward == true)
                {
                    cAlly3.transform.position = Vector2.MoveTowards(cAlly3.transform.position, StartPoint3, cardSpeed * Time.deltaTime);
                    if (cAlly3.transform.position == StartPoint3)
                    {
                        movingBackward = false;
                        if (cEnemy3Health <= 0)
                        {
                            Destroy(cEnemy3);
                        }
                        if (cAlly3Health <= 0)
                        {
                            Destroy(cAlly3);
                        }
                    }
                }
            }
        }
        if (cEnemy3 == null && cEnemy4 != null)
        {
            if (IsAttacking == true)
            {
                if (movingForward == true)
                {
                    cAlly3.transform.position = Vector2.MoveTowards(cAlly3.transform.position, cEnemy4.transform.position, cardSpeed * Time.deltaTime);
                    cEnemy4Health = int.Parse(cEnemy4.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text);
                    cEnemy4Attack = int.Parse(cEnemy4.transform.Find("Attack").GetComponentInChildren<TextMeshProUGUI>().text);
                    if (cAlly3.transform.position == cEnemy4.transform.position)
                    {
                        movingBackward = true;
                        movingForward = false;
                        cAlly3Health -= cEnemy4Attack;
                        cAlly3.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text = cAlly3Health.ToString();
                        cEnemy4Health -= cAlly3Attack;
                        cEnemy4.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text = cEnemy4Health.ToString();
                    }
                }
                if (movingBackward == true)
                {
                    cAlly3.transform.position = Vector2.MoveTowards(cAlly3.transform.position, StartPoint3, cardSpeed * Time.deltaTime);
                    if (cAlly3.transform.position == StartPoint3)
                    {
                        movingBackward = false;
                        if (cEnemy4Health <= 0)
                        {
                            Destroy(cEnemy4);
                        }
                        if (cAlly3Health <= 0)
                        {
                            Destroy(cAlly3);
                        }
                    }
                }
            }
        }
    }

    private void onAttackAlly4()
    {
        if (cEnemy0 != null)
        {
            if (IsAttacking == true)
            {
                if (movingForward == true)
                {
                    cAlly4.transform.position = Vector2.MoveTowards(cAlly4.transform.position, cEnemy0.transform.position, cardSpeed * Time.deltaTime);
                    cEnemy0Health = int.Parse(cEnemy0.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text);
                    cEnemy0Attack = int.Parse(cEnemy0.transform.Find("Attack").GetComponentInChildren<TextMeshProUGUI>().text);
                    if (cAlly4.transform.position == cEnemy0.transform.position)
                    {
                        movingBackward = true;
                        movingForward = false;
                        cAlly4Health -= cEnemy0Attack;
                        cAlly4.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text = cAlly4Health.ToString();
                        cEnemy0Health -= cAlly4Attack;
                        cEnemy0.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text = cEnemy0Health.ToString();
                    }
                }
                if (movingBackward == true)
                {
                    cAlly4.transform.position = Vector2.MoveTowards(cAlly4.transform.position, StartPoint4, cardSpeed * Time.deltaTime);
                    if (cAlly4.transform.position == StartPoint4)
                    {
                        movingBackward = false;
                        if (cEnemy0Health <= 0)
                        {
                            Destroy(cEnemy0);
                        }
                        if (cAlly4Health <= 0)
                        {
                            Destroy(cAlly4);
                        }
                    }
                }
            }
        }
        if (cEnemy0 == null && cEnemy1 != null)
        {
            if (IsAttacking == true)
            {
                if (movingForward == true)
                {
                    cAlly4.transform.position = Vector2.MoveTowards(cAlly4.transform.position, cEnemy1.transform.position, cardSpeed * Time.deltaTime);
                    cEnemy1Health = int.Parse(cEnemy1.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text);
                    cEnemy1Attack = int.Parse(cEnemy1.transform.Find("Attack").GetComponentInChildren<TextMeshProUGUI>().text);
                    if (cAlly4.transform.position == cEnemy1.transform.position)
                    {
                        movingBackward = true;
                        movingForward = false;
                        cAlly4Health -= cEnemy1Attack;
                        cAlly4.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text = cAlly4Health.ToString();
                        cEnemy1Health -= cAlly4Attack;
                        cEnemy1.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text = cEnemy1Health.ToString();
                    }
                }
                if (movingBackward == true)
                {
                    cAlly4.transform.position = Vector2.MoveTowards(cAlly4.transform.position, StartPoint4, cardSpeed * Time.deltaTime);
                    if (cAlly4.transform.position == StartPoint4)
                    {
                        movingBackward = false;
                        if (cEnemy1Health <= 0)
                        {
                            Destroy(cEnemy1);
                        }
                        if (cAlly4Health <= 0)
                        {
                            Destroy(cAlly4);
                        }
                    }
                }
            }
        }
        if (cEnemy1 == null && cEnemy2 != null)
        {
            if (IsAttacking == true)
            {
                if (movingForward == true)
                {
                    cAlly4.transform.position = Vector2.MoveTowards(cAlly4.transform.position, cEnemy2.transform.position, cardSpeed * Time.deltaTime);
                    cEnemy2Health = int.Parse(cEnemy2.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text);
                    cEnemy2Attack = int.Parse(cEnemy2.transform.Find("Attack").GetComponentInChildren<TextMeshProUGUI>().text);
                    if (cAlly4.transform.position == cEnemy2.transform.position)
                    {
                        movingBackward = true;
                        movingForward = false;
                        cAlly4Health -= cEnemy2Attack;
                        cAlly4.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text = cAlly4Health.ToString();
                        cEnemy2Health -= cAlly4Attack;
                        cEnemy2.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text = cEnemy2Health.ToString();
                    }
                }
                if (movingBackward == true)
                {
                    cAlly4.transform.position = Vector2.MoveTowards(cAlly4.transform.position, StartPoint4, cardSpeed * Time.deltaTime);
                    if (cAlly4.transform.position == StartPoint4)
                    {
                        movingBackward = false;
                        if (cEnemy2Health <= 0)
                        {
                            Destroy(cEnemy2);
                        }
                        if (cAlly4Health <= 0)
                        {
                            Destroy(cAlly4);
                        }
                    }
                }
            }
        }
        if (cEnemy2 == null && cEnemy3 != null)
        {
            if (IsAttacking == true)
            {
                if (movingForward == true)
                {
                    cAlly4.transform.position = Vector2.MoveTowards(cAlly4.transform.position, cEnemy3.transform.position, cardSpeed * Time.deltaTime);
                    cEnemy3Health = int.Parse(cEnemy3.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text);
                    cEnemy3Attack = int.Parse(cEnemy3.transform.Find("Attack").GetComponentInChildren<TextMeshProUGUI>().text);
                    if (cAlly4.transform.position == cEnemy3.transform.position)
                    {
                        movingBackward = true;
                        movingForward = false;
                        cAlly4Health -= cEnemy3Attack;
                        cAlly4.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text = cAlly4Health.ToString();
                        cEnemy3Health -= cAlly4Attack;
                        cEnemy3.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text = cEnemy3Health.ToString();
                    }
                }
                if (movingBackward == true)
                {
                    cAlly4.transform.position = Vector2.MoveTowards(cAlly4.transform.position, StartPoint4, cardSpeed * Time.deltaTime);
                    if (cAlly4.transform.position == StartPoint4)
                    {
                        movingBackward = false;
                        if (cEnemy3Health <= 0)
                        {
                            Destroy(cEnemy3);
                        }
                        if (cAlly4Health <= 0)
                        {
                            Destroy(cAlly4);
                        }
                    }
                }
            }
        }
        if (cEnemy3 == null && cEnemy4 != null)
        {
            if (IsAttacking == true)
            {
                if (movingForward == true)
                {
                    cAlly4.transform.position = Vector2.MoveTowards(cAlly4.transform.position, cEnemy4.transform.position, cardSpeed * Time.deltaTime);
                    cEnemy4Health = int.Parse(cEnemy4.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text);
                    cEnemy4Attack = int.Parse(cEnemy4.transform.Find("Attack").GetComponentInChildren<TextMeshProUGUI>().text);
                    if (cAlly4.transform.position == cEnemy4.transform.position)
                    {
                        movingBackward = true;
                        movingForward = false;
                        cAlly4Health -= cEnemy4Attack;
                        cAlly4.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text = cAlly4Health.ToString();
                        cEnemy4Health -= cAlly4Attack;
                        cEnemy4.transform.Find("Health").GetComponentInChildren<TextMeshProUGUI>().text = cEnemy4Health.ToString();
                    }
                }
                if (movingBackward == true)
                {
                    cAlly4.transform.position = Vector2.MoveTowards(cAlly4.transform.position, StartPoint4, cardSpeed * Time.deltaTime);
                    if (cAlly4.transform.position == StartPoint4)
                    {
                        movingBackward = false;
                        if (cEnemy4Health <= 0)
                        {
                            Destroy(cEnemy4);
                        }
                        if (cAlly4Health <= 0)
                        {
                            Destroy(cAlly4);
                        }
                    }
                }
            }
        }
    }
}
