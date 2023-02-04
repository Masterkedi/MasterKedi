using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class RotateScr : MonoBehaviour
{
    float[] rotations = { 0, 90, 180, 270 };
    public float [] correctRotation;
    
    [SerializeField]bool isPlaced=false;
    int possibleRot = 1;
    gameManager gameManager;
    
    private void Awake()
    {
        gameManager = GameObject.Find("gameManager").GetComponent<gameManager>();
    }
    private void Start()
    {
        possibleRot= correctRotation.Length;
        //int random=Random.Range(0, rotations.Length);
        //transform.eulerAngles = new Vector3(0, 0, rotations[random]);
        if (possibleRot>1)
        {
            if (transform.eulerAngles.z == correctRotation[0]|| transform.eulerAngles.z == correctRotation[1])
            {
                isPlaced = true;
                gameManager.correctMove();
                

            }
        }
        else
        {
            if (transform.eulerAngles.z == correctRotation[0])
            {
                isPlaced= true;
                gameManager.correctMove();

            }
        }
       
       
    }
    private void OnMouseDown()
    {
       
            transform.Rotate(new Vector3(0, 0, 90));
        if (possibleRot > 1)
        {
            if (transform.eulerAngles.z == correctRotation[0]|| transform.eulerAngles.z == correctRotation[1] && isPlaced==false) 
        {
            isPlaced=true;
                gameManager.correctMove();


            }
        else if (isPlaced==true)
        {
            isPlaced = false;
                gameManager.WrongMove(); 
                
        }

        }
        else
        {
            if (transform.eulerAngles.z == correctRotation[0]  && isPlaced == false)
            {
                isPlaced = true;
                gameManager.correctMove();


            }
            else if (isPlaced == true)
            {
                isPlaced = false;
                gameManager.WrongMove();

            }
        }
    }
}
