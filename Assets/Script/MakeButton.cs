using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class MakeButton : MonoBehaviour
{

    [SerializeField]
    private bool physical;

    void Start()
    {
        string temp = gameObject.name;
        gameObject.GetComponent<Button>().onClick.AddListener(() => AttackCallback(temp));     
    }

    private void AttackCallback(string btn)
    {
        GameObject hero = GameObject.FindGameObjectWithTag("Hero");

        if(btn.CompareTo("MeeleBtn") == 0)
        {
            hero.GetComponent<FighterAction>().SelectAttack("melee");
        }
        if(btn.CompareTo("MagicBtn") == 0)
        {
            hero.GetComponent<FighterAction>().SelectAttack("magic");
        }
        if (btn.CompareTo("RangeBtn") == 0)
        {
            hero.GetComponent<FighterAction>().SelectAttack("range");
        }
        if (btn.CompareTo("RunBtn") == 0)
        {
            hero.GetComponent<FighterAction>().SelectAttack("run")
        }
    }
}
