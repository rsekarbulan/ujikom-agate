using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public GameObject clickAudio;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void ToMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void ClickButton()
    {
        GameObject clickInstance = Instantiate(clickAudio);
        AudioSource source = clickInstance.GetComponent<AudioSource>();
        source.Play();

        Destroy(clickInstance, 2f);
    }
}
