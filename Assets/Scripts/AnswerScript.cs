using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswerScript : MonoBehaviour
{
    public bool isCorrect = false;
    public QuizManager quizManager;
    public Soundsfx _soundfx;

    public Color startColor;

    private void Start()
    {
        startColor = GetComponent<Image>().color;
    }

    // Start is called before the first frame update
    public void Answer()
    {
        if (isCorrect)
        {
            GetComponent<Image>().color = Color.green;
            Debug.Log("Correct");
            quizManager.correct();
            _soundfx.PlayRightAnswer();
        }
        else
        {
            GetComponent<Image>().color = Color.red;
            Debug.Log("Wrong");
            quizManager.wrong();
            _soundfx.PlayWrongAnswer();
        }
    }
}
