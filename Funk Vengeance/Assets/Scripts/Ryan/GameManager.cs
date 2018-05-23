using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using AUDIO;

public class GameManager : MonoBehaviour
{
    public GameObject blade;
    private bool KillMode = false;
    private bool hasBlade = false;

    public GameObject player;
    private bool hasWon = false;

    private int target;

    #region Target texts
    public Canvas GameOverCanvas;
    public Canvas BladeGetText;
    public GameObject TargetKilledText;
    public GameObject WrongGuyText;

    public GameObject MR_BLUETEXT;
    public GameObject MR_REDTEXT;
    public GameObject MR_YELLOWTEXT;
    public GameObject MR_GREENTEXT;
    public GameObject MR_WHITETEXT;
    #endregion

    private int TargetPicker()
    {
        //random //1 - 6
        switch (Random.Range(1, 6))
        {
            case 1:
                MR_BLUETEXT.gameObject.SetActive(true);
                return 1;
            case 2:
                MR_REDTEXT.gameObject.SetActive(true);
                return 2;
            case 3:
                MR_YELLOWTEXT.gameObject.SetActive(true);
                return 3;
            case 4:
                MR_GREENTEXT.gameObject.SetActive(true);
                return 4;
            case 5:
                MR_WHITETEXT.gameObject.SetActive(true);
                return 5;
        }
        return 5;
    }

    private void Awake()
    {
        AudioManager.PlaySound("BackGround");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && hasBlade == true)
        {
            KillMode = true;
            Debug.Log("Ready to kill");
        }
        else if (Input.GetKeyUp(KeyCode.Space) && hasBlade == true)
        {
            KillMode = false;
            Debug.Log("*Sheaths blade*");
        }

        if (hasWon == true)
        {
            AudioManager.PlaySound("Victory");
            GameOverCanvas.gameObject.SetActive(true);
        }

    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void RETRY()
    {
        SceneManager.LoadScene("Main");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Weapon" && hasBlade == false)
        {
            Debug.Log("You have the blade");
            BladeGetText.gameObject.SetActive(true);
            //Kill mode is active 
            hasBlade = true;
            Destroy(other.gameObject);
            target = TargetPicker();
        }
        if (other.tag == "Door")
        {
            hasWon = true;
            GameOverCanvas.gameObject.SetActive(true);
            StopAllCoroutines();
        }

        if (KillMode == true)
        {
            switch (other.name)
            {
                case "MR BLUE":
                    if (target == 1)
                    {
                        TargetKilledText.gameObject.SetActive(true);
                        if (Random.Range(1, 2) == 1)
                            AudioManager.PlaySound("Stab1");
                        else
                            AudioManager.PlaySound("Stab2");
                        AudioManager.PlaySound("TargetDown");

                        other.gameObject.GetComponent<Sight>().viewRadius = 0;
                        other.gameObject.GetComponent<AI>().enabled = false;
                    }
                    else
                    {
                        AudioManager.PlaySound("Failure");
                        WrongGuyText.gameObject.SetActive(true);
                        StopAllCoroutines();
                        SceneManager.LoadScene("Game Over");
                    }
                    break;
                case "MR RED":
                    if (target == 2)
                    {
                        if (Random.Range(1, 2) == 1)
                            AudioManager.PlaySound("Stab1");
                        else
                            AudioManager.PlaySound("Stab2");
                        AudioManager.PlaySound("TargetDown");

                        TargetKilledText.gameObject.SetActive(true);
                        other.gameObject.GetComponent<Sight>().viewRadius = 0;
                        other.gameObject.GetComponent<AI>().enabled = false;
                    }
                    else
                    {
                        AudioManager.PlaySound("Failure");
                        WrongGuyText.gameObject.SetActive(true);
                        StopAllCoroutines();
                        SceneManager.LoadScene("Game Over");
                    }
                    break;
                case "MR YELLOW":
                    if (target == 3)
                    {
                        if (Random.Range(1, 2) == 1)
                            AudioManager.PlaySound("Stab1");
                        else
                            AudioManager.PlaySound("Stab2");
                        AudioManager.PlaySound("TargetDown");

                        TargetKilledText.gameObject.SetActive(true);
                        other.gameObject.GetComponent<Sight>().viewRadius = 0;
                        other.gameObject.GetComponent<AI>().enabled = false;
                    }
                    else
                    {
                        AudioManager.PlaySound("Failure");
                        WrongGuyText.gameObject.SetActive(true);
                        StopAllCoroutines();
                        SceneManager.LoadScene("Game Over");
                    }
                    break;
                case "MR GREEN":
                    if (target == 4)
                    {
                        if (Random.Range(1, 2) == 1)
                            AudioManager.PlaySound("Stab1");
                        else
                            AudioManager.PlaySound("Stab2");
                        AudioManager.PlaySound("TargetDown");

                        TargetKilledText.gameObject.SetActive(true);
                        other.gameObject.GetComponent<Sight>().viewRadius = 0;
                        other.gameObject.GetComponent<AI>().enabled = false;
                    }
                    else
                    {
                        AudioManager.PlaySound("Failure");
                        WrongGuyText.gameObject.SetActive(true);
                        StopAllCoroutines();
                        SceneManager.LoadScene("Game Over");
                    }
                    break;
                case "MR WHITE":
                    if (target == 5)
                    {
                        if (Random.Range(1, 2) == 1)
                            AudioManager.PlaySound("Stab1");
                        else
                            AudioManager.PlaySound("Stab2");
                        AudioManager.PlaySound("TargetDown");

                        TargetKilledText.gameObject.SetActive(true);
                        other.gameObject.GetComponent<Sight>().viewRadius = 0;
                        other.gameObject.GetComponent<AI>().enabled = false;
                    }
                    else
                    {
                        AudioManager.PlaySound("Failure");
                        WrongGuyText.gameObject.SetActive(true);
                        StopAllCoroutines();
                        SceneManager.LoadScene("Game Over");
                    }
                    break;
                case "MR BLACK":
                    AudioManager.PlaySound("Failure");
                    WrongGuyText.gameObject.SetActive(true);
                    StopAllCoroutines();
                    SceneManager.LoadScene("Game Over");
                    break;
            }
        }
    }
}
