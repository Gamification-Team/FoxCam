using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonControl : MonoBehaviour
{
	//Buttons in Unity work by calling specified methods on Click
	//To map a method to a specific button, go to the Inspector
	//There is a Component called Button, inside is a little area
	//called On Click; If its a new button this should say List is 
	//Empty inside; near the bottom is a plus sign: click this and
	//3 modules should appear. One of them says None. Click this and
	//add the button you want to click on, once this is selected go
	//and select the script you want to use (ButtonControl in this case)
	//and choose the method you want

	private bool isVisible;
	private GameObject startSpot;
	private GameObject button1;
    private GameObject button2;
    private GameObject button3;
    private GameObject menuSpot;
    private float xStart;
    private float xEnd;

    void Start()
    {
    	isVisible = false;
    	startSpot = GameObject.Find("startSpot");
    	button1 = GameObject.Find("B1");
    	button2 = GameObject.Find("B2");
   		button3 = GameObject.Find("B3");
    	menuSpot = GameObject.Find("MenuSpot");
    	xEnd = menuSpot.transform.position.x;
    	xStart = startSpot.transform.position.x;
    }

    public void MenuOpen()
    {
    	StartCoroutine("Slide");
    }

    IEnumerator Slide()
    {
    	if (isVisible == false)
    	{
    		button1.transform.position = new Vector3(xEnd, button1.transform.position.y, button1.transform.position.z);
    		button2.transform.position = new Vector3(xEnd, button2.transform.position.y, button2.transform.position.z);
    		button3.transform.position = new Vector3(xEnd, button3.transform.position.y, button3.transform.position.z);
    		isVisible = true;
    	}
    	else
    	{
    		button1.transform.position = new Vector3(xStart, button1.transform.position.y, button1.transform.position.z);
    		button2.transform.position = new Vector3(xStart, button2.transform.position.y, button2.transform.position.z);
    		button3.transform.position = new Vector3(xStart, button3.transform.position.y, button3.transform.position.z);
    		isVisible = false;
    	}
    	yield return null;
    }
}
