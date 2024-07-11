using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Logic1 : MonoBehaviour
{
    private void Start()
    {
    }
    public void PlayGame()
    {
        Debug.Log("Switching scenes");
        SceneManager.LoadScene(1);
    }
}
