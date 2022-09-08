using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDialogue : MonoBehaviour
{
    public float sec = 4f;
    public GameManager GameManager;
    void Start()
    {
        GameManager.StartCoroutine(LateCall(sec));
    }

    IEnumerator LateCall(float sec)
    {
        if (gameObject.activeInHierarchy)
            gameObject.SetActive(false);

        yield return new WaitForSeconds(sec);

            gameObject.SetActive(true);
        
            //Turn the Game Oject back off after 1 sec.
            yield return new WaitForSeconds(5);

            //Game object will turn off
            gameObject.SetActive(false);
        

    }
}
