using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    
    public void LoadRequest(string name)
    {
        Debug.Log("Load request called for: " +name);
        Brick.BreakableCount = 0;
        Application.LoadLevel(name);
    }
    public void QuitRequest()
    {
        Debug.Log("Exit from the game! ");
        Application.Quit();
    }
    public void BackRequest(string name1)
    {
        Debug.Log("Back to Start Page!" + name1);
        Application.LoadLevel(name1);
    }
    public void LoadNextRequest()
    {
        Brick.BreakableCount = 0;
        Application.LoadLevel(Application.loadedLevel + 1);
    }
    public void BrickDestroyed()
    {
        /*last brick is destroyed*/
        if (Brick.BreakableCount == 0)
        {
            LoadNextRequest();
        }
    }
}
