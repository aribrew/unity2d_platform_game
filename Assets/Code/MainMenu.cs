using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField]
    private Button startButton = null;

    [SerializeField]
    private Button exitButton = null;

    [SerializeField]
    private Color onButtonSelect;

    [SerializeField]
    private Color onButtonClick;


    void Awake ()
    {
        if ((startButton != null) && (exitButton != null))
        {
            startButton.onClick.AddListener (StartGame);
            exitButton.onClick.AddListener (ExitGame);

            startButton.Select ();
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        
    }


    void ExitGame ()
    {
        if (Application.isEditor)
        {
            EditorApplication.ExitPlaymode ();
        }
        else
        {
            Application.Quit ();
        }
    }


    void StartGame ()
    {

    }
}
