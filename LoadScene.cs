using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LoadScene : MonoBehaviour
{
    public void SceneLoad(int SceneIndex)
    {
        SceneManager.LoadScene(SceneIndex);
    }
}
