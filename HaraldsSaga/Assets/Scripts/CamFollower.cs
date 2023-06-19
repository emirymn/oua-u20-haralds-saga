
using UnityEngine;

public class CamFollower : MonoBehaviour
{
  [SerializeField] Transform playerCameraPos;
     void Update()
    {
        transform.position = playerCameraPos.position;
    }
}
