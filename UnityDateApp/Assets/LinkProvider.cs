using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinkProvider : MonoBehaviour
{
    const string url = "https://bolkond.com/UOfk?sub1=sub1&sub2=sub2&sub3=sub3&sub4=sub4&sub5=sub5";

    public void OpenPartnerLink()
    {
        Application.OpenURL(url);
    }
}
