using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneBehaviour : MonoBehaviour
{

    public GameObject loading;
    public GameObject app;

    // Start is called before the first frame update
    void OnSceneLoaded()
    {
        loading.SetActive(true);
        //app.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
