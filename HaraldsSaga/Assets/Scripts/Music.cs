using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
     private static Music obje = null;
  
    void Awake()
    {
        if( obje == null )
        {
            obje = this;
            DontDestroyOnLoad( this );
        }
        else if( this != obje )
        {
            Destroy( gameObject );
        }
    }
}
