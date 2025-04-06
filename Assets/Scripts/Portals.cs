using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portals : MonoBehaviour
{
    public void portal_in_city()
    {
        SceneManager.LoadScene(0);
    }
    public void portal_in_neworld()
    {
        SceneManager.LoadScene(1);
    }
    // Start is called before the first frame update
}
