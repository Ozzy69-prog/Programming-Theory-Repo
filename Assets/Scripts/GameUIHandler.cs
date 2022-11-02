using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameUIHandler : MonoBehaviour
{
    public TextMeshProUGUI gameText;
    
    // Start is called before the first frame update
    void Start()
    {
        if (MainManager.Instance != null)
        {
            gameText.SetText("Hello " + MainManager.Instance.nameSpace + ", press one of the shapes and discover more abouts its origin!");
        }
    }

    public void GoBackToMenu()
    {
        SceneManager.LoadScene(0);
    }
      
}
