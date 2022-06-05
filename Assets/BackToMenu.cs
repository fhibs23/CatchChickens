using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackToMenu : MonoBehaviour
{
    public GameObject panel = null;
    public GameObject rules = null;
    public Camera camera = null;
    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Q))
        {
            panel.SetActive(!panel.activeSelf);
            Cursor.lockState = CursorLockMode.None;
            

        }

         if (Input.GetKeyUp(KeyCode.R))
        {
            rules.SetActive(!rules.activeSelf);
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
