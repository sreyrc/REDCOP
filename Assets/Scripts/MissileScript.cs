using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileScript : MonoBehaviour
{
    public float missileSpeed;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * missileSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Platform" || collision.collider.tag == "Wall" || collision.collider.tag == "Collider")
            Destroy(gameObject);
    }
}
