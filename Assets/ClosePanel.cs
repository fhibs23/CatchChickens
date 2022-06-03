using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosePanel : MonoBehaviour
{
    public GameObject panel = null;
    public void Close()
    {
        panel.SetActive(!panel.activeSelf);
        Cursor.lockState = CursorLockMode.None;

    }
}
