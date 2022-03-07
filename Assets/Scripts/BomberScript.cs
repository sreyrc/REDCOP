using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BomberScript : MonoBehaviour
{
    public GameObject bomb;
    public bool dropBombs;
    // Start is called before the first frame update
    void Update()
    {
        if (dropBombs == true)
        {
            StartCoroutine(DropBombs());
            dropBombs = false;
        }
    }

    IEnumerator DropBombs()
    {
        for (int i = 0; i < 4; i++)
        {
            yield return new WaitForSeconds(0.8f);
            Vector2 spawnPositionLeft = new Vector2(transform.position.x - 5*transform.localScale.x, transform.position.y);
            Vector2 spawnPositionRight = new Vector2(transform.position.x + 5*transform.localScale.x, transform.position.y);
            Quaternion spawnRotation = Quaternion.Euler(new Vector3(transform.rotation.x, transform.rotation.y, (transform.rotation.z - 90)));
            Instantiate(bomb, spawnPositionLeft, spawnRotation);
            Instantiate(bomb, spawnPositionRight, spawnRotation);
        }
    }
}
