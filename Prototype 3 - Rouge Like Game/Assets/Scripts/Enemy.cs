using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [Header("Enemy Health")]
    public int curHP;
    public int maxHP;
    [Header("Enemy Attack")]
    public int damage;
    public float attackRate;
    private float lastAttackTime;
    public Player_Controller player;
    
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").GetComponent <Player_Controller> ();
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time - lastAttackTime >= attackRate)
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
        lastAttackTime = Time.time;
        player.TakeDamage(damage);
    }
    public void Die()
    {
        Destroy(gameObject);
    }
}