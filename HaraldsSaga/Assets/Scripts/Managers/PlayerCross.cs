using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCross : MonoBehaviour
{
    [SerializeField] GameObject camHolderGo;
    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(GetComponentInChildren<Camera>().transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
        {
            if (hit.transform.gameObject.CompareTag("NPC"))
            {
                UIManager.instance.infoText.gameObject.SetActive(true);
                UIManager.instance.infoText.text = hit.transform.gameObject.name;
                Debug.DrawRay(GetComponentInChildren<Camera>().transform.position, transform.TransformDirection(Vector3.forward) * 15f, Color.green);

            }
            else
            {
                UIManager.instance.infoText.gameObject.SetActive(false);
                Debug.DrawRay(GetComponentInChildren<Camera>().transform.position, transform.TransformDirection(Vector3.forward) * 15f, Color.white);
            }
        }
    }
}
