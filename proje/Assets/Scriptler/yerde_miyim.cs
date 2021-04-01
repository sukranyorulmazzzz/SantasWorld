using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yerde_miyim : MonoBehaviour
{
    // Start is called before the first frame update
    public LayerMask layer;
    public bool yerdemiyiz;
    public Rigidbody2D rigidbo;
    public float ziplama_gucu;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(karakter_kontrolu.Oyuna_baslandi_mi==false)
        {
            return;
        }
       
        RaycastHit2D carpip = Physics2D.Raycast(transform.position, Vector2.down, 0.8f, layer);

        if(carpip.collider !=null)
        {
            yerdemiyiz = true;
        }
        else
        {
            yerdemiyiz = false;

        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Zipla();
        }
    }
    public void Zipla()
    {
        if(yerdemiyiz==true)
        {
            rigidbo.velocity += new Vector2(0, ziplama_gucu);
        }
    }
}
