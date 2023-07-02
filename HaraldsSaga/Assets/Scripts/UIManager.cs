using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Image InventoryBackScreen;

    public static UIManager instance;
    private void Awake()
    {
        if (instance != null)
            Destroy(gameObject);

        instance = this;

    }


    public void InventoryOpenClose()
    {
        if (InventoryBackScreen.transform.gameObject.activeSelf)
        {
            InventoryBackScreen.gameObject.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
        else
        {
            InventoryBackScreen.gameObject.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
}
