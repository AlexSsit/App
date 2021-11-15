using System.Text.RegularExpressions;
using System.Security.Cryptography;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrueOfFalseDeduction : MonoBehaviour
{
   public Text mathLText;
   public Text resultText;
   public Text mathRText;
   
  

   private int leftNumber;
   private int rightNumber;
   private int mathOperator;
   private int trueResult;
   private int falseResult;
   private int randomOneResult;
   private int randomTwoResult;
   private int randomThreeResult;


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
            mathLText.GetComponent<Text>().text = leftNumber.ToString();
            mathRText.GetComponent<Text>().text = rightNumber.ToString();
            resultText.GetComponent<Text>().text = falseResult.ToString();
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
        if(trueResult == falseResult)
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
