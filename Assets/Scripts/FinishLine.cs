using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


// scene reloads when it hits finish line, there is a slight delay
public class FinishLine : MonoBehaviour
{
    [SerializeField] float loadDelay = 1f;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
        
          Invoke("ReloadScene", loadDelay);
        
        }
        
    }

     void ReloadScene()
        {
          
          SceneManager.LoadScene(0);

        }
}
