using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowerScript : MonoBehaviour
{
    [SerializeField] Transform targetGameObject;
    void Update()
    {
        transform.position = targetGameObject.position;
    }
}
