using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Connect : MonoBehaviour
{
    public string ListURL;
    public Text CountText;

    void Start()
    {
        ListURL = "http://traincom.dothome.co.kr/sub/test.php";
        StartCoroutine(ListCo());
        CountText = gameObject.GetComponent<Text>();
    }
    IEnumerator ListCo()
    {
        WWW webRequest = new WWW(ListURL);
        yield return webRequest;
        string test_t = webRequest.text;
        CountText.text = test_t;
    }

}

