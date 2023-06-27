using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
   public static Gamemanager instance = null;
    public GameObject youWinText;
    public float resetDelay;
    void Awake() 
    {
        if (instance == null)
            instance = this;
        else if (instance != null)
            Destroy (gameObject);
    }

    public void Win()
    {
        youWinText.SetActive(true);
        Time.timeScale =.5f;
        Invoke ("Reset",resetDelay);
    }
   
   void Reset() {
    Time.timeScale = 1.0f;
    Application.LoadLevel(Application.loadedLevel);
   }
}
