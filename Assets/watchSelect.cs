using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class watchSelect : MonoBehaviour
{
    public GameObject watchModel1;
    public GameObject watchModel2;
    public GameObject watchModel3;

    public GameObject w1Window;
    public GameObject w2Window;
    public GameObject w3Window;

    Animation w1WindowsAnimation;
    Animation w2WindowsAnimation;
    Animation w3WindowsAnimation;


    // Start is called before the first frame update
    void Start()
    {
        w1WindowsAnimation = w1Window.GetComponent<Animation>();
        w2WindowsAnimation = w2Window.GetComponent<Animation>();
        w3WindowsAnimation = w3Window.GetComponent<Animation>();

        watchModel1.SetActive(false);
        watchModel2.SetActive(false);
        watchModel3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void watchOneButtonClicked()
    {
        watchModel1.SetActive(true);
        watchModel2.SetActive(false);
        watchModel3.SetActive(false);

        w1WindowsAnimation["w1animation"].speed = 1;
        w1WindowsAnimation.Play();
    }
    public void watchTwoButtonClicked()
    {
        watchModel1.SetActive(false);
        watchModel2.SetActive(true);
        watchModel3.SetActive(false);

        w2WindowsAnimation["w2animation"].speed = 1;
        w2WindowsAnimation.Play();
    }
    public void watchThreeButtonClicked()
    {
        watchModel1.SetActive(false);
        watchModel2.SetActive(false);
        watchModel3.SetActive(true);

        w3WindowsAnimation["w3animation"].speed = 1;
        w3WindowsAnimation.Play();
    }
    public void CloseButtonClicked()
    {
        string buttonName = EventSystem.current.currentSelectedGameObject.name;
        if (buttonName == "w1close") {
            w1WindowsAnimation["w1animation"].speed = -1;
            w1WindowsAnimation["w1animation"].time = w1WindowsAnimation["w1animation"].length;
            w1WindowsAnimation.Play();
        }
        else if (buttonName == "w2close") {
            w2WindowsAnimation["w2animation"].speed = -1;
            w2WindowsAnimation["w2animation"].time = w2WindowsAnimation["w2animation"].length;
            w2WindowsAnimation.Play();
        }
        else if (buttonName == "w3close")
        {
            w3WindowsAnimation["w3animation"].speed = -1;
            w3WindowsAnimation["w3animation"].time = w3WindowsAnimation["w3animation"].length;
            w3WindowsAnimation.Play();
        }
       
    }
}
