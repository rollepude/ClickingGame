using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Manager : MonoBehaviour
{
    public void back()
    {
        SceneManager.LoadScene("Main");
    }
    public void quit()
    {
        Application.Quit();
    }

}
