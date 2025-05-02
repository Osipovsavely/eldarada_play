using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plot : MonoBehaviour
{
    [SerializeField] GameObject event_object_1, event_object_2;

    public void event_1_say_tue()
    {
        event_object_1.SetActive(false);
    }
    public void event_1_say_false()
    {
        event_object_1.SetActive(false);
    }
    public void event_1_no_say()
    {
        event_object_1.SetActive(false);
    }


    public void event_2_no()
    {
        event_object_2.SetActive(false);
    }
    public void event_2_yes()
    {
        event_object_2.SetActive(false);
    }
    public void event_2_fiftififti()
    {
        event_object_2.SetActive(false);
    }
}
