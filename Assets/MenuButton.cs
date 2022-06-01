using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButton : MonoBehaviour
{
    public GameObject menu = null;
    public GameObject optionsMenu = null;
    public void StartScene()
    {
        Application.LoadLevel("SampleScene");
    }
    public void SwitchMenus()
    {
        menu.SetActive(!menu.activeSelf);
        optionsMenu.SetActive(!optionsMenu.activeSelf);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
