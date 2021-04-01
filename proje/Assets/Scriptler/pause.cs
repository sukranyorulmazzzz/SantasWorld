using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pause : MonoBehaviour
{
    public static bool oyun_devam_ediyor_mu=true;
    public GameObject panel_pause;
    public void Oyunu_durdur_devam()
    {
        if(oyun_devam_ediyor_mu)
        {
            oyun_devam_ediyor_mu = false;
            Time.timeScale = 0;
            panel_pause.SetActive(true);
        }
        else
        {
            oyun_devam_ediyor_mu = true;
            Time.timeScale = 1;
            panel_pause.SetActive(false);
        }
    }
    public void Ana_menuye_git()
    {
        SceneManager.LoadScene("anamenu");
    }
    public void Tekrar_yukle()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void Oyunu_kapat()
    {
        Application.Quit();
    }

}
