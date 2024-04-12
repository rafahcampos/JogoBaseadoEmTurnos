using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackScript : MonoBehaviour
{

    public GameObject owner;

    [SerializeField]
    private bool magicAttack;

    [SerializeField]
    private float minAttackMultiplier;

    [SerializeField]
    private float maxAttackMultiplier;

    [SerializeField]
    private float minDefenseMultiplier;

    [SerializeField]
    private float maxDefenseMultiplier;



    private float damage = 0.0f;
    private float xMagicNewScale;



 public void Attack(GameObject owner)
    {

    }
}
