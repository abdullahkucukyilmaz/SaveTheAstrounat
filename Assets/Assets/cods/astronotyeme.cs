using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class astronotyeme : MonoBehaviour
{

    public Text astrotext;
    int atropuan = 0;
    public Text oretext;
    int orepoint = 0;
    public ProgressBar Pb;
    public GameObject AtomRocket;
    public GameObject astroid1;
    int counter = 200;
    public AudioSource cellses, ore1, patlama, patlama2;
    public ParticleSystem karadelik;
   
    public Text lvltext;

    void Start()
    {
        


        Pb.BarValue = 100;
        InvokeRepeating("sayac", 1, 1);
        
    }
    public void Update()
    {
        if (Pb.BarValue == 0)
        {
            AtomRocket.SetActive(false);
            Invoke("bekle", 1);
           
            
        }

        if (lvltext.text == "Level 1")
        {
            if (atropuan >= 1 && orepoint >= 2)
            {
                SceneManager.LoadScene(3);

            }
        }
        if (lvltext.text == "Level 2")
        {
            if (atropuan >= 2 && orepoint >= 4)
            {
                SceneManager.LoadScene(4);

            }
        }
        if (lvltext.text == "Level 3")
        {
            if (atropuan >= 3 && orepoint >= 6)
            {
                SceneManager.LoadScene(5);

            }
        }


    }
    public void bekle()
    {
        SceneManager.LoadScene(2);
    }



    public void sayac()
    {
        Pb.BarValue--;
    }

    
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "astro")
        {

            Destroy(collision.gameObject);
            atropuan++;
            astrotext.text = "Astronaut :" + atropuan;
        }
        if (collision.gameObject.tag == "Asteroid")
        {
            patlama.Play();
            Invoke("bekle1", 1);
            
            {

            }
            Destroy(collision.gameObject);
            Pb.barValue -= 25;
        }
        if (collision.gameObject.tag == "ore")
        {
            ore1.Play();
            Destroy(collision.gameObject);
            orepoint++;
            oretext.text = "Materials:" + orepoint;
        }
        if (collision.gameObject.tag == "cell")
        {
            cellses.Play();
            Destroy(collision.gameObject);
            counter += 50;
            Pb.barValue = 100;
        }
        if (collision.gameObject.tag == "blackhole")
        {
            karadelik.Play();
            Pb.barValue = 0;
           
            
            
            
        }
        if (collision.gameObject.tag == "alien")
        {
            Destroy(collision.gameObject);
            Pb.barValue -= 50;
        }
    }
}