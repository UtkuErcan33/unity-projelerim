using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ring : MonoBehaviour
{
    public Animator animasyon;

    public float zaman;
   
    public float h�z;

    public GameObject anakarakter;
    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        zaman = Random.Range(0f, 10f);


        animasyon.SetFloat("zaman", zaman);
        hareketetme();
        
      
        
    }     
    public void hareketetme()
           {

        if (Input.GetKey(KeyCode.W))
        {
            animasyon.SetBool("y�r�me", true);
        }
        else
        {
            animasyon.SetBool("y�r�me", false);
        }
        if (Input.GetKey(KeyCode.A))
        {
            animasyon.SetBool("solad�nme", true);
        }
        else
        {
            animasyon.SetBool("solad�nme", false);
        }
        if (Input.GetKey(KeyCode.D))
        {
            animasyon.SetBool("sa�ad�nme", true);
        }
        else
        {
            animasyon.SetBool("sa�ad�nme", false);
        }
       if(Input.GetKey(KeyCode.Mouse0)) 
        {
            animasyon.SetBool("yumrukatma", true);
        }
        else
        {
            animasyon.SetBool("yumrukatma", false);
        }
        if (Input.GetKey(KeyCode.Mouse1))
        {
            animasyon.SetBool("tekme", true);
        }
        else
        {
            animasyon.SetBool("tekme", false);
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            animasyon.SetBool("ko�ma", true);
        }
        else
        {
            animasyon.SetBool("ko�ma", false);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            animasyon.SetBool("z�plama", true);
        }
        else
        {
            animasyon.SetBool("z�plama", false);
        }
        if (Input.GetKey(KeyCode.S))
        {
            animasyon.SetBool("geriy�r�me", true);
        }
        else
        {
            animasyon.SetBool("geriy�r�me", false);
        }



    }
    
    }




  