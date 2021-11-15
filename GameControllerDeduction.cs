using System.Text.RegularExpressions;
using System.Security.Cryptography;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControllerDeduction : MonoBehaviour
{
   public Text mathLText;
   public Text resultText;
   public Text randomNumberOneText;
   public Text randomNumberTwoText;
   public Text randomNumberThreeText;
   public Text randomNumberFourText;
   public Text mathRText;
   
  

   private int leftNumber;
   private int rightNumber;
   private int mathOperator;
   private int trueResult;
   private int falseResult;
   private int randomOneResult;
   private int randomTwoResult;
   private int randomThreeResult;
   private int randomFourResult;


   public void Start()
   {
      createMath();
   }
   
  

   public void createMath()
   {
        leftNumber = Random.Range(0, 10);
        rightNumber = Random.Range(0, 5);
        mathOperator = Random.Range(0, 1);

        switch (mathOperator)
        {
            case 0:
            trueResult = leftNumber - rightNumber;
            falseResult = trueResult + Random.Range(-2, 3);
            randomOneResult = trueResult + Random.Range(1, 6);
            randomTwoResult = trueResult + Random.Range(0, 4) ;
            randomThreeResult = trueResult + Random.Range(-2, 2);
            randomFourResult = trueResult + Random.Range(-1, 3);
            mathLText.GetComponent<Text>().text = leftNumber.ToString();
            mathRText.GetComponent<Text>().text = rightNumber.ToString();
            resultText.GetComponent<Text>().text = trueResult.ToString();
            randomNumberOneText.GetComponent<Text>().text = randomOneResult.ToString();
            randomNumberTwoText.GetComponent<Text>().text = randomTwoResult.ToString();
            randomNumberThreeText.GetComponent<Text>().text = randomThreeResult.ToString();
            randomNumberFourText.GetComponent<Text>().text = randomFourResult.ToString();
               break;
            //   case 1:
             //  trueResult = leftNumber - rightNumber;
          //  falseResult = trueResult + Random.Range(-2, 3);
          //  mathText.GetComponent<Text>().text = leftNumber.ToString() + " - " + rightNumber.ToString();
          //  resultText.GetComponent<Text>().text = falseResult.ToString();
           //      break;
           //        case 2:
           //        trueResult = leftNumber * rightNumber;
          //  falseResult = trueResult + Random.Range(-2, 3);
          //  mathText.GetComponent<Text>().text = leftNumber.ToString() + " * " + rightNumber.ToString();
          //  resultText.GetComponent<Text>().text = falseResult.ToString();
           //          break;
                     default:
                     break;
        }
   }

   

// mathText.GetComponent<Text>().text = leftNumber.ToString() + " + " + rightNumber.ToString();




//--------------------------------------------------------------------

         public void onTrueButtonClick()
   {
        if(trueResult == trueResult)
        {
            createMath();
        }
        else
        {
            
        }
   }

       public void onRandomOneButtonClick()

       {
          if(trueResult == randomOneResult)
          {
            createMath();
          }
          else
          {
              
          }
       }

       public void onRandomTwoButtonClick()

       {
          if(trueResult == randomTwoResult)
          {
            createMath();
          }
          else
          {
              
          }
       }

       public void onRandomThreeButtonClick()

       {
          if(trueResult == randomThreeResult)
          {
            createMath();
          }
          else
          {
              
          }
       }

       public void onRandomFourButtonClick()

       {
          if(trueResult == randomFourResult)
          {
            createMath();
          }
          else
          {
              
          }
       }



   //public void onTrueButtonClick()
  // {
   //     if(trueResult == falseResult)
   //     {
   //         createMath();
   //     }
   //     else
   //     {
            
    //    }
  // }

   public void onFalseButtonClick()
   {
     if(trueResult != falseResult)
     {
         createMath();
     }
     else
     {
         
     }
   }

}
