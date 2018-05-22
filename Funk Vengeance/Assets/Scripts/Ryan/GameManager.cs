using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject blade;
    private bool KillMode = false;
    private bool hasBlade = false;

    public GameObject player;
    private bool hasWon = false;

    private int target;
    public Canvas GameOverCanvas;

    private int TargetPicker()
    {
        //random //1 - 6
        switch(Random.Range(1,6))
        {
            case 1:
                Debug.Log("The target is MR Blue");
                return 1;
            case 2:
                Debug.Log("The target is MR Red");
                return 2;
            case 3:
                Debug.Log("The target is MR Yellow");
                return 3;
            case 4:
                Debug.Log("The target is MR Green");
                return 4;
            case 5:
                Debug.Log("The target is MR Black");
                return 5;
            case 6:
                Debug.Log("The target is MR White");
                return 6;
        }
        return 6;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) &&  hasBlade == true)
        {
            KillMode = true;
            Debug.Log("Ready to kill");
        }
        else if(Input.GetKeyUp(KeyCode.Space) && hasBlade == true)
        {
            KillMode = false;
            Debug.Log("*Sheaths blade*");
        }

        if (hasWon == true)
        {
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
        if (other.tag == "Weapon")
        {
            Debug.Log("You have the blade");
            //Kill mode is active 
            hasBlade = true;
            Destroy(other.gameObject);
            target = TargetPicker();
        }
        if (other.tag == "Door")
        {
            Debug.Log("You win, do you whant to retry?");

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
                        Debug.Log("You Got Him Now get to the Door");
                        other.gameObject.GetComponent<Sight>().viewRadius = 0;
                        other.gameObject.GetComponent<AI>().enabled = false;
                    }
                    else
                    {
                        Debug.Log("You killed the wrong guy!!!");
                        StopAllCoroutines();
                        Debug.Log("GameOver");
                        SceneManager.LoadScene("Game Over");
                    }
                    break;
                case "MR RED":
                    if (target == 2)
                    {
                        Debug.Log("You Got Him Now get to the Door");
                        other.gameObject.GetComponent<Sight>().viewRadius = 0;
                        other.gameObject.GetComponent<AI>().enabled = false;
                    }
                    else
                    {
                        Debug.Log("You killed the wrong guy!!!");
                        StopAllCoroutines();
                        Debug.Log("GameOver");
                        SceneManager.LoadScene("Game Over");
                    }
                    break;
                case "MR YELLOW":
                    if (target == 3)
                    {
                        Debug.Log("You Got Him Now get to the Door");
                        other.gameObject.GetComponent<Sight>().viewRadius = 0;
                        other.gameObject.GetComponent<AI>().enabled = false;
                    }
                    else
                    {
                        Debug.Log("You killed the wrong guy!!!");
                        StopAllCoroutines();
                        Debug.Log("GameOver");
                        SceneManager.LoadScene("Game Over");
                    }
                    break;
                case "MR GREEN":
                    if (target == 4)
                    {
                        Debug.Log("You Got Him Now get to the Door");
                        other.gameObject.GetComponent<Sight>().viewRadius = 0;
                        other.gameObject.GetComponent<AI>().enabled = false;
                    }
                    else
                    {
                        Debug.Log("You killed the wrong guy!!!");
                        StopAllCoroutines();
                        Debug.Log("GameOver");
                        SceneManager.LoadScene("Game Over");
                    }
                    break;
                case "MR BLACK":
                    if (target == 5)
                    {
                        Debug.Log("You Got Him Now get to the Door");
                        other.gameObject.GetComponent<Sight>().viewRadius = 0;
                        other.gameObject.GetComponent<AI>().enabled = false;
                    }
                    else
                    {
                        Debug.Log("You killed the wrong guy!!!");
                        StopAllCoroutines();
                        Debug.Log("GameOver");
                        SceneManager.LoadScene("Game Over");
                    }
                    break;
                case "MR WHITE":
                    if (target == 6)
                    {
                        Debug.Log("You Got Him Now get to the Door");
                        other.gameObject.GetComponent<Sight>().viewRadius = 0;
                        other.gameObject.GetComponent<AI>().enabled = false;
                    }
                    else
                    {
                        Debug.Log("You killed the wrong guy!!!");
                        StopAllCoroutines();
                        Debug.Log("GameOver");
                        SceneManager.LoadScene("Game Over");
                    }
                    break;
            }
        }
    }
}
