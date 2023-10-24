using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GestionnaireScene : MonoBehaviour
{
    private int sceneIndex;

    public void Recommencer()
    {
        SceneManager.LoadScene(0);
    }
}
