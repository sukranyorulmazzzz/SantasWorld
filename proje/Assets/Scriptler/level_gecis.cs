using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class level_gecis : MonoBehaviour
{
   public void Level_ac(string level_ismi)
    {
        SceneManager.LoadScene(1);
    }
    public void Level_ac_siradaki()
    {
        string level_ismi = PlayerPrefs.GetInt("level").ToString();
        SceneManager.LoadScene(1);
    }
}
