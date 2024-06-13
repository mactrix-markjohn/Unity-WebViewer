using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrowserLauncher : MonoBehaviour
{
	public string pageToOpen = "https://www.google.com";
	public string pageTitle = "Robinson Helicopter Community";
	public int paddingTop = 0;
	public int paddinBottom = 0;
	public int paddingLeft = 20;
	public int paddingRight = 0;

	// check readme file to find out how to change title, colors etc.
	public void OnButtonClicked()
	{
		InAppBrowser.DisplayOptions options = new InAppBrowser.DisplayOptions();
		options.displayURLAsPageTitle = false;
		options.pageTitle = pageTitle;
		options.barBackgroundColor = "#FFFFFF";
		options.textColor = "#000000";
		options.hidesTopBar = false;

		InAppBrowser.EdgeInsets insets = new InAppBrowser.EdgeInsets(paddingTop,paddinBottom,paddingLeft,paddingRight);

		options.insets = insets;


		InAppBrowser.OpenURL(pageToOpen, options);
	}

	public void OnClearCacheClicked()
	{
		InAppBrowser.ClearCache();
	}
}
