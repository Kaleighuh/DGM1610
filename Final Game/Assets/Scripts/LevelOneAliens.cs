using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelOneAliens : MonoBehaviour
{
    [Header("Enemy Health")]
    public int curHP;
    public int maxHP;

    [Header("Enemy Attack")]
    public int damage;
    public float attackRange;
    public float attackRate;
    private float lastAttackTime;
    public PlayerController player;

    void Start()
    {
        player = GameObject.Find("Player").GetComponent<PlayerController>();
    }
    void Update()
    {
        if(Time.time - lastAttackTime >= attackRate && Vector2.Distance(transform.position, player.transform.position) < attackRange)
        {
            Attack();
        }
    }
    public void TakeDamage(int damage)
    {
        curHP -= damage;
        if(curHP <= 0)
        {
            Die();
        }
    }

    void Attack()
    {
        
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
