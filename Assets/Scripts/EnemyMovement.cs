using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]
public class EnemyMovement : MonoBehaviour
{
    public GameObject player;
    public float moveSpeed, shootDistance, seeDistance=10;
    int directionX;
    public bool reversed = false;
    Animator anim;
    Vector2 originallyFacing;
    // Start is called before the first frame update
    void Awake()
    {
        GetComponent<EnemyMovement>().enabled = false;
        anim = GetComponent<Animator>();
        originallyFacing = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.x > transform.position.x)
            directionX = 1;
        else
            directionX = -1;
        float distanceX = Mathf.Abs(player.transform.position.x - transform.position.x);
        float distanceY = Mathf.Abs(player.transform.position.y - transform.position.y);
        if (distanceX >= shootDistance && distanceX <= seeDistance && distanceY < 2 )
        {
            transform.Translate(Vector2.right * moveSpeed * directionX * Time.deltaTime);
            anim.SetBool("isRunning", true);
        }
        else
            anim.SetBool("isRunning", false);
        


        //flip character
        if (directionX == -1)
        {
            transform.localScale = originallyFacing * new Vector2(-1, 1);
            reversed = true;
        }
        else
        {
            transform.localScale = originallyFacing;
            reversed = false;
        }
    }
}
