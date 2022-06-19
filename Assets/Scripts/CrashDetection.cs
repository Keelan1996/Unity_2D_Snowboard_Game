using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


// loads scene when the character crashes on his head
public class CrashDetection : MonoBehaviour
{

   [SerializeField] float loadDelay = 0.5f;

   void OnTriggerEnter2D(Collider2D other)
   {
        if(other.tag == "Ground")
        {
           Invoke("ReloadScene", loadDelay);
        }
        
      
   }

   void ReloadScene()
   {
         SceneManager.LoadScene(0);
   }
}
