using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
public class IronPatriot : MonoBehaviour
{
    public static Action Rayo;
    public GameObject rayo;
    public GameObject Aparicion;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void instanciarRayo()
    {
        Instantiate(rayo,Aparicion.transform.position,Aparicion.transform.rotation);
    }
    public void ChangeLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    private void OnEnable()
    {
          
    }
}
