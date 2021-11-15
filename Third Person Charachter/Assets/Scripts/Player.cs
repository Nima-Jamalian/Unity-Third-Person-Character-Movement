using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Animator doorAnimator;
    private bool playHasKey = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Key")
        {
            collision.gameObject.SetActive(false);
            playHasKey = true;
        }

        if(collision.gameObject.name == "DoorOpenTrigger")
        {
            if(playHasKey == true)
            {
                doorAnimator.SetBool("isPlayerOnDoorTrigger", true);
            }
        }
    }
}
