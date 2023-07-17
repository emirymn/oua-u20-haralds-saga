using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wolf : MonoBehaviour
{
    private Animator anim;
    private bool canRotate;
    private GameObject target;
    private void Awake()
    {
        anim = GetComponentInChildren<Animator>();
    }
    void Update()
    {
        if (canRotate)
        {
            //  transform.LookAt(target.transform);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        target = other.gameObject;
        if (other.gameObject.CompareTag("GameController"))
        {
            var lookPos = target.transform.position - gameObject.transform.position;
            Quaternion.LookRotation(lookPos);
            anim.SetBool("canAttack", true);
            canRotate = true;
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("GameController"))
        {
            anim.SetBool("canAttack", false);
            canRotate = false;
        }

    }
}
