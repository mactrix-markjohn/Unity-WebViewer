using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UniWebController : MonoBehaviour
{

    public RectTransform webRect;
    UniWebView webView;
    public string pageToOpen = "https://augmentedislandstudios.discourse.group/";



    // Start is called before the first frame update
    void Start()
    {
        var webViewGameObject = new GameObject("UniWebView");
        webView = webViewGameObject.AddComponent<UniWebView>();

        webView.ReferenceRectTransform = webRect; // 1
        webView.Load(pageToOpen); // 2
        webView.Show();
    }

    // Update is called once per frame
    void Update()
    {
        // Update web view's frame to match the reference rect transform.
        webView.UpdateFrame();
    }

    public void OpenScene(string sceneName) {
        SceneManager.LoadScene(sceneName);
    }
}
