using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour {

    [SerializeField]
    [Tooltip("Canvas for the Main Menu.")]
    public Canvas MainMenuCanvas;
    [SerializeField]
    [Tooltip("Canvas for the Pause Menu.")]
    public Canvas PauseCanvas;
    [SerializeField]
    [Tooltip("Canvas for the Leave Menu.")]
    public Canvas LeaveCanvas;

    // Start
    void Start()
    {
        MainMenuCanvas.GetComponent<Canvas>();
        PauseCanvas.GetComponent<Canvas>();
        LeaveCanvas.GetComponent<Canvas>();
    }

    // Update
    void Update()
    {
       //if (pause canvas exists)
       // {
       //    pause game
       // }
    }

    // Main Menu button functions
    public void MainMenu_Start()
    {
        // Disable Main Menu canvas
        MainMenuCanvas.gameObject.SetActive(false);
        // Load up the Level01 scene
        SceneManager.LoadScene("Test_01", LoadSceneMode.Additive);
    }
    public void MainMenu_Quit()
    {
        // Quit the Application
        Application.Quit();
    }

    // Gameplay button functions
    public void Gameplay_Continue()
    {

    }
    public void Gameplay_LeaveArea_Yes()
    {

    }
    public void Gameplay_LeaveArea_No()
    {

    }
    public void Gameplay_Quit()
    {
        // Return to the Main Menu scene
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Additive);
    }

}
