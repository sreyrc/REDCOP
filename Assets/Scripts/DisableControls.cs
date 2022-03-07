using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableControls : MonoBehaviour
{
    public GameObject enterToDis;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(AppearsAfterwards());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            GetComponent<Animator>().SetBool("keyPressed", true);
            enterToDis.GetComponent<Animator>().SetBool("keyPressed", true);
        }
    }

    IEnumerator AppearsAfterwards()
    {
        yield return new WaitForSeconds(2f);
        enterToDis.SetActive(true);
    }
}
