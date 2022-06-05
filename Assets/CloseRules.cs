using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseRules : MonoBehaviour
{
    public GameObject rules = null;
    public void Close()
    {
        rules.SetActive(!rules.activeSelf);
        Cursor.lockState = CursorLockMode.None;

    }
}
