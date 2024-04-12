using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FighterAction : MonoBehaviour
{
    private GameObject hero;
    private GameObject enemy;

    [SerializeField]
    private GameObject meleePrefab;

    [SerializeField]
    private GameObject magicPrefab;

    [SerializeField]
    private GameObject rangePrefab;

    [SerializeField]
    private Sprite faceIcon;

    private GameObject currentAttack;
    private GameObject meleeAttack;
    private GameObject magicAttack;
    private GameObject rangeAttack;


    public void SelectAttack(string btn)
    {
        GameObject victim = hero;

        if(tag == "Hero")
        {
            victim = enemy;
        }
        if(btn.CompareTo("melee") == 0)
        {
            meleeAttack.GetComponent<AttackScript>().Attack(victim);
        }
        else if (btn.CompareTo("magic") == 0)
        {
            rangeAttack.GetComponent<AttackScript>().Attack(victim);
        }
        else if (btn.CompareTo("range") == 0)
        {
            rangeAttack.GetComponent<AttackScript>().Attack(victim);
        }
        else if(btn.CompareTo("run") == 0)
        {
            Debug.Log("Running!");
        }
    }









}

