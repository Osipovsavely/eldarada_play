using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TourchController : MonoBehaviour
{
    [SerializeField] GameObject tourch_object;
    public void OnMouseDown() 
    {
        if(Playerdata.tourch_controll == true)
        {
            tourch_object.SetActive(true);
            Playerdata.tourch_controll = false;
        }
        else 
        {
            Playerdata.tourch_controll = true;
            tourch_object.SetActive(false);
        }
    }
   
}
