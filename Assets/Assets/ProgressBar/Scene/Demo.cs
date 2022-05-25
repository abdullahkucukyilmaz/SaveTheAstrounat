using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace fuelbar { 
public class Demo : MonoBehaviour {

    public ProgressBar Pb;
   


    public void Start()
    {
        Pb.BarValue = 100;
        InvokeRepeating("sayac", 1, 1);
        
    }
    public void sayac()
    {
        Pb.BarValue--;
    }
        

       
    }
}

