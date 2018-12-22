using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class Utils
{
    public static void reloadlvl()
    {
        int indx = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(indx);
    }
    public static void loadnextlvl()
    {
        int indx = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene((indx + 1) % SceneManager.sceneCountInBuildSettings);
    }

}
