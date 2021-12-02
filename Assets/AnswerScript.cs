using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerScript : MonoBehaviour
{
   
   public bool isCorrect = fale;
   public QuizManager quizManager;
   
   public void Answers()
   {
       if (isCorrect)
       {
           Debug.Log("Correct Answer");
           quizManager.correct();
       }
       else
       {
           Debug.Log("Wrong Answer");
           quizManager.correct();
       }
   }
}
