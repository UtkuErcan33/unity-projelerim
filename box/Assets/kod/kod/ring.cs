using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ring : MonoBehaviour
{
    public Animator animasyon;

    public float zaman;
   
    public float hýz;

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
            animasyon.SetBool("yürüme", true);
        }
        else
        {
            animasyon.SetBool("yürüme", false);
        }
        if (Input.GetKey(KeyCode.A))
        {
            animasyon.SetBool("soladönme", true);
        }
        else
        {
            animasyon.SetBool("soladönme", false);
        }
        if (Input.GetKey(KeyCode.D))
        {
            animasyon.SetBool("saðadönme", true);
        }
        else
        {
            animasyon.SetBool("saðadönme", false);
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
            animasyon.SetBool("koþma", true);
        }
        else
        {
            animasyon.SetBool("koþma", false);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            animasyon.SetBool("zýplama", true);
        }
        else
        {
            animasyon.SetBool("zýplama", false);
        }
        if (Input.GetKey(KeyCode.S))
        {
            animasyon.SetBool("geriyürüme", true);
        }
        else
        {
            animasyon.SetBool("geriyürüme", false);
        }



    }
    
    }




  