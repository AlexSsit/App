using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomStaff : MonoBehaviour
{
    public GameObject TextBox;
    public int TheNumber;
    //public int TheNumberTwo;

    public void RandomGenerate () {
        TheNumber = Random.Range (1, 10);
        //TheNumberTwo = Random.Range (1, 10);
        TextBox.GetComponent<Text> ().text = "" + TheNumber; //+ " - " + TheNumberTwo;
    }

}
