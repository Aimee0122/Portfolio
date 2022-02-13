using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneBack : MonoBehaviour
{
    public void ChangeSceneBtn()
    {
            SceneManager.LoadScene("Lobby");
    }
}
