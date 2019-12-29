using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Classes;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoader : MonoBehaviour
{
    private static SceneLoader sceneLoader;

    public Canvas loadingCanvas;
    public Slider loadingBar;
    public GameObject loadingScreen;
    public TextMeshProUGUI loadPercent;
    
    
    private void Awake()
    {
        if (sceneLoader == null)
        {
            sceneLoader = this;
            DontDestroyOnLoad(this);    //The master lives while the game runs
        }
        else
        {
            DestroyImmediate(this);
        }

        loadingCanvas.sortingOrder = 1;
    }


    
    public void LoadLevel (int sceneIndex)
    {
        StartCoroutine(LoadAsync(sceneIndex));
    }
    
    
    IEnumerator LoadAsync(int sceneIndex)
    {
        loadingScreen.SetActive(true);
        AsyncOperation loadOp = SceneManager.LoadSceneAsync(sceneIndex);

        while (!loadOp.isDone)
        {
            float progress = Mathf.Clamp01(loadOp.progress / 0.9f);
        
            loadingBar.value = progress;
            loadPercent.text = $"{progress * 100}%";
            
            yield return null;
        }

        if (loadOp.isDone)
        {
            loadingScreen.SetActive(false);
        }
    }
}
