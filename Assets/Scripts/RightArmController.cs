using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightArmController : MonoBehaviour
{
    public bool isEuler;
    public Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isEuler)
        {
            //transform.eulerAngles = RightGamePadInput.RightHandTransform.eulerAngles;
            Vector3 filtred = RightGamePadInput.RightHandTransform.eulerAngles+ offset;
            
            transform.eulerAngles = filtred;
        }
        else transform.rotation = RightGamePadInput.RightHandTransform.rotation;
        /*
        
    */
    }
}
