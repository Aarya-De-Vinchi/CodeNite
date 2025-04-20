
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    public void Loadlevel()
    {
        SceneManager.LoadScene("D1_End_Story");

    }
    public void LoadCompilerScene()
    {
        SceneManager.LoadScene("Compiler"); // Make sure "compiler" is added to Build Settings
    }

    public void LoadQuizScene()
    {
        SceneManager.LoadScene("QuizScene"); // Make sure "QuizScene" is added too
    }

    public void LoadForestSwampScene()
    {
        SceneManager.LoadScene("D1_Swamp");  // Your next level after compiler
    }



}
