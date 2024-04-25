using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    // Start is called before the first frame update
   public void StartButton()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void QuitButton()
    {
        Application.Quit();
    }
}
