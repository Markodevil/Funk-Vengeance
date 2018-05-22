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

    public bool isPaused = false;

    // Start
    void Start()
    {
        // Get the canvas component, then set it to active
        MainMenuCanvas.GetComponent<Canvas>();
        MainMenuCanvas.gameObject.SetActive(true);
        // Get the canvas component, then set it to inactive
        PauseCanvas.GetComponent<Canvas>();
        PauseCanvas.gameObject.SetActive(false);
        // Get the canvas component, then set it to inactive
        VictoryCanvas.GetComponent<Canvas>();
        VictoryCanvas.gameObject.SetActive(false);
        // Get the canvas component, then set it to inactive
        FailureCanvas.GetComponent<Canvas>();
        FailureCanvas.gameObject.SetActive(false);

        isPaused = false;
    }

    // Update
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.KeypadEnter) && (isPaused == false))
        {
            // Enable Pause canvas
            PauseCanvas.gameObject.SetActive(true);
            // Set timescale to 0 to pause the scene
            Debug.Log(isPaused);
            isPaused = true;
        }
        else if (Input.GetKeyDown(KeyCode.KeypadEnter) && (isPaused == true))
        {
            // Enable Pause canvas
            PauseCanvas.gameObject.SetActive(false);
            // Set timescale to 0 to pause the scene
            isPaused = false;
        }

        if (isPaused == true)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }

    // Main Menu button functions
    public void MainMenu_Start()
    {
        // Disable Main Menu canvas
        MainMenuCanvas.gameObject.SetActive(false);
        // Load up the Level01 scene
        SceneManager.LoadScene("Test_01", LoadSceneMode.Single);
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
        // Set isPaused to false to unpause the scene
        isPaused = false;
    }
    public void Gameplay_Pause_Quit()
    {
        // Disable Pause canvas
        PauseCanvas.gameObject.SetActive(false);
        // Set isPaused to false to unpause the scene
        isPaused = false;
        // Return to the Main Menu scene
        SceneManager.LoadScene("Josh_MainMenu", LoadSceneMode.Single);
    }

    public void Gameplay_Victory_LeaveArea_Yes()
    {
        // Disable Victory canvas
        VictoryCanvas.gameObject.SetActive(false);
        // Set isPaused to false to unpause the scene
        isPaused = false;
        // Return to the Main Menu scene
        SceneManager.LoadScene("Josh_MainMenu", LoadSceneMode.Single);
    }
    public void Gameplay_Victory_LeaveArea_No()
    {
        // Disable Victory canvas
        VictoryCanvas.gameObject.SetActive(false);
        // Set isPaused to false to unpause the scene
        isPaused = false;
    }
    public void Gameplay_Victory_Quit()
    {
        // Disable Victory canvas
        VictoryCanvas.gameObject.SetActive(false);
        // Set isPaused to false to unpause the scene
        isPaused = false;
        // Return to the Main Menu scene
        SceneManager.LoadScene("Josh_MainMenu", LoadSceneMode.Single);
    }

    public void Gameplay_Failure_Retry()
    {
        // Disable Failure canvas
        FailureCanvas.gameObject.SetActive(false);
        // Set isPaused to false to unpause the scene
        isPaused = false;
        // Reset the current level
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void Gameplay_Failure_Quit()
    {
        // Disable Failure canvas
        FailureCanvas.gameObject.SetActive(false);
        // Set isPaused to false to unpause the scene
        isPaused = false;
        // Return to the Main Menu scene
        SceneManager.LoadScene("Josh_MainMenu", LoadSceneMode.Single);
    }
}
