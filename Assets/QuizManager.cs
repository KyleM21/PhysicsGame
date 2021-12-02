using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizManager : MonoBehaviour
{
    public List<QuestionsAndAnswers> QnA;
    public  GameObject[] options;
    public int currentQestion;

    public Text QuestionTxt;


    private void Start()
    {
        generateQuestion()
    }

    public void correct()
    {
        QnA.RemoveAt(currentQestion);
        generateQuestion();
    }

    void SetAnswers()
    {
        for (int i=0 ; i < options.Length; i++)
        {
            options[i].getComponent<AnswerScript>()isCorrect = false;
            options[i].trasform.GetChild(0).getComponent<Text>().text = QnA[currentQestion].Answers[i];

            if (QnA[currentQestion].CorrectAnswer == i+1)
            {
                options[i].getComponent<AnswerScript>()isCorrect = true;

            }
        }
    }

    void generateQuestion()
    {
        currentQuestion = Random.Range(0, QnA.Count);

        QuestionTxt.text = QnA[currentQestion].Question;
        SetAnswers();


    }
}
