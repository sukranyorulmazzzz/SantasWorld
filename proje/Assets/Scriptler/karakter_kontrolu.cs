using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class karakter_kontrolu : MonoBehaviour
{
    public float hiz;
    public Animator animasyoncum;
    float horizontal;
    public int altin_miktari;
    public Text text_altin_miktari;
    public Text oyun_sonu_altin_miktari;
    public GameObject pnl_oyun_sonu;
    public GameObject pnl_oyun_basi;
    public AudioSource ses_altin_toplama;
    public static bool Oyuna_baslandi_mi=false;
    public int kacinci_level = 1;
   
 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
       
        
    {
        if(Oyuna_baslandi_mi==false)
        {
            return;
        }
        Oldummu();
      //  horizontal = Input.GetAxis("Horizontal");

        bool kosuyormuyum = false;
        if (horizontal != 0)
        {
            kosuyormuyum = true;
            animasyoncum.speed = Mathf.Abs(horizontal);
        }
        else
        {
            animasyoncum.speed = Mathf.Abs(1);
        }

        animasyoncum.SetBool("kosuyormuyum", kosuyormuyum);
        transform.position += new Vector3(horizontal * hiz * Time.deltaTime, 0, 0);
        Yon_Duzeltmesi();


    }
    void Oldummu()
    {
        if(transform.position.y<-12f)
        {
          
            Olme();
        }
    }
    void Yon_Duzeltmesi()
    {
        if (horizontal > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        else if (horizontal < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }
    void OnTriggerEnter2D(Collider2D carpilan_nesne)
    {
        if (carpilan_nesne.tag == "altinlar")
        {
            altin_miktari++;
            text_altin_miktari.text = altin_miktari.ToString();
            ses_altin_toplama.Play();
            Destroy(carpilan_nesne.gameObject);
        }
        else if (carpilan_nesne.tag == "tuzaklar")
        {
            Olme();
        }
        else if(carpilan_nesne.tag=="kizak")
        {
            
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            if (PlayerPrefs.GetInt("level") < kacinci_level)
            {
                PlayerPrefs.SetInt("level", kacinci_level);
            }
        }

    }
    void LateUpdate()
    {
       
        
    }
    void Olme()
    {
        
        Destroy(gameObject);
        pnl_oyun_sonu.SetActive(true);
        oyun_sonu_altin_miktari.text = altin_miktari.ToString();
    }
    public void Oyuna_basla()
    {
        Oyuna_baslandi_mi = true;
        pnl_oyun_basi.SetActive(false);
    }

    public void Hareket(int miktar)
    {
        horizontal = miktar;
    }
    
    
}
