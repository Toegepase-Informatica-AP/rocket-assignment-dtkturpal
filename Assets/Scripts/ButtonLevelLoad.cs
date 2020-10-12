using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonLevelLoad : MonoBehaviour
{
    public string mLevelToLoad;
    //public Scene scene;
    
    // Start is called before the first frame update
    public void LoadLevel()
    {
        SceneManager.LoadScene(mLevelToLoad);
    }
}
