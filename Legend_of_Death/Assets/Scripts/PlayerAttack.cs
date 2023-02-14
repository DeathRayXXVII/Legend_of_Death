using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerAttack : MonoBehaviour
{
    [Header ("Player Attack")]
    public intData damage; //Number to be delt with
    public float attackRange; //Range in which the player can attack
    public float attackRate; //Rate at which the player can attack at
    private float lastAttackTime; //Last time the player attack
    public LayerMask enemyLayer;
    private Vector2 direction;
    public GameObject wepon; //Getting the object to use
    private AudioSource source; //Audio sourece
    public AudioClip marker; //Audio clip

    // Start is called before the first frame update
    void Start()
    {
        wepon.SetActive(false); //Deactivating the wepon object
        source = GetComponent<AudioSource>(); //Getting the audio source
    }
    private void OnTriggerEnter3D (Collider other)
    {
        lastAttackTime = Time.time;
        //enemy.TakeDamage(damage);
        Attack();
        
    }
    void Attack()
    {
        lastAttackTime = Time.time;
        
        //Raycast using the enemyLayer
        RaycastHit2D hit = Physics2D.Raycast(transform.position, direction, attackRange, enemyLayer);

        if(hit.collider != null)
        {
            //hit.collider.GetComponent<EnemyController>()?.TakeDamage(damage);
            source.PlayOneShot(marker,1.0f);//Play the Audio source on hit
            Debug.Log("you hit");
        }
         
    }
}

