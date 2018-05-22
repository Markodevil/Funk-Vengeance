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
    [Tooltip("Canvas for the Victory Menu.")]
    public Canvas VictoryCanvas;
    [SerializeField]
    [Tooltip("Canvas for the Failure Menu.")]
    public Canvas FailureCanvas;

    // Start
    void Start()
    {
        MainMenuCanvas.GetComponent<Canvas>();
        PauseCanvas.GetComponent<Canvas>();
        VictoryCanvas.GetComponent<Canvas>();
        FailureCanvas.GetComponent<Canvas>();
    }

    // Update
    void Update()
    {
        if (Input.GetKey(KeyCode.KeypadEnter))
        {
            // Enable Pause canvas
            PauseCanvas.gameObject.SetActive(true);
            // Set timescale to 0 to pause the scene
            Time.timeScale = 0;
        }
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
    public void Gameplay_Pause_Continue()
    {
        // Disable Pause canvas
        PauseCanvas.gameObject.SetActive(false);
        // Set timescale to 1 to unpause the scene
        Time.timeScale = 1;
    }
    public void Gameplay_Pause_Quit()
    {
        // Disable Pause canvas
        PauseCanvas.gameObject.SetActive(false);
        // Set timescale to 1 to unpause the scene
        Time.timeScale = 1;
        // Return to the Main Menu scene
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Additive);
    }

    public void Gameplay_Victory_LeaveArea_Yes()
    {
        // Disable Victory canvas
        VictoryCanvas.gameObject.SetActive(false);
        // Set timescale to 1 to unpause the scene
        Time.timeScale = 1;
        // Return to the Main Menu scene
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Additive);
    }
    public void Gameplay_Victory_LeaveArea_No()
    {
        // Disable Victory canvas
        VictoryCanvas.gameObject.SetActive(false);
        // Set timescale to 1 to unpause the scene
        Time.timeScale = 1;
    }
    public void Gameplay_Victory_Quit()
    {
        // Disable Victory canvas
        VictoryCanvas.gameObject.SetActive(false);
        // Set timescale to 1 to unpause the scene
        Time.timeScale = 1;
        // Return to the Main Menu scene
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Additive);
    }

    public void Gameplay_Failure_Retry()
    {
        // Disable Failure canvas
        FailureCanvas.gameObject.SetActive(false);
        // Set timescale to 1 to unpause the scene
        Time.timeScale = 1;
        // Reset the current level
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void Gameplay_Failure_Quit()
    {
        // Disable Failure canvas
        FailureCanvas.gameObject.SetActive(false);
        // Set timescale to 1 to unpause the scene
        Time.timeScale = 1;
        // Return to the Main Menu scene
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Additive);
    }
}
