using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
 * FAKE LOADING SCREEN BEHAVIOUR
 * 
 * Alexander Gusarov - DragonGameStudios 2021
 * 
 */



public class LoadingScreenBehaviour : MonoBehaviour
{
    private float totalLoadingTime;
    [SerializeField] private float loadTimeMin;
    [SerializeField] private float loadTimeMax;
    [SerializeField] private Animator anim;
    //[SerializeField] private Animation anim;
    [SerializeField] private Image loaderImage;
    public GameObject AppScene; 
    private float stepTime;

    // Start is called before the first frame update
    void Start()
    {
        totalLoadingTime = Random.Range(loadTimeMin, loadTimeMax);
        Debug.Log("//LOADING TIME IS: "+totalLoadingTime+" SEC");
        StartCoroutine(MakeLoading());
        stepTime = 0.12f;
        StartCoroutine(AnimationStep(stepTime));
    }

    IEnumerator MakeLoading()
    {
        yield return new WaitForSeconds(totalLoadingTime);
        Debug.Log("//LOADING DONE");
        anim.enabled = true;
        StartCoroutine(ClosePanel());
    }

    IEnumerator ClosePanel()
    {
        yield return new WaitForSeconds(1.2f);
        Debug.Log("//CLOSING PANEL");
        gameObject.SetActive(false);
        AppScene.SetActive(true);
    }

    public void RotateCircle()
    {
        loaderImage.transform.Rotate(new Vector3(0, 0, -30));
        Debug.Log("// Rotating Loading circle...");
    }

    private IEnumerator AnimationStep(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        var r = Random.Range(0f, 1f);
        if (r <= 0.85f)
        {
            RotateCircle();
            StartCoroutine(AnimationStep(stepTime));
        }
        else
        {
            StartCoroutine(AnimationStep(stepTime));
            Debug.Log("// Rotating Loading circle evaded...");
        }
    }

}