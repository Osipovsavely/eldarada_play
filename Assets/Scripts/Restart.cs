using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{

    public void Restart_()
    {
        SceneManager.LoadScene(0);
        Playerdata.step = 0;
    }
}
