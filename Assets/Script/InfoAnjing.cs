using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InfoAnjing : MonoBehaviour
{
    public void Menu()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void Play()
    {
        SceneManager.LoadScene("Play");
    }
}
