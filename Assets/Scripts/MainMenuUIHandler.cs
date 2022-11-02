using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class MainMenuUIHandler : MonoBehaviour
{
    public MainManager m_manager;

   public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    public void ChangeName(string s)
    {
        m_manager.nameSpace = s;
        Debug.Log(m_manager.nameSpace);
    }
}
