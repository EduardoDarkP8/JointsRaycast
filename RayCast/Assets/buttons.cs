using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttons : MonoBehaviour
{
    public void open1()
	{
        SceneManager.LoadScene(1);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
    public void open2()
    {
        SceneManager.LoadScene(2);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
    public void Sair()
	{
        Application.Quit();
	}

}
