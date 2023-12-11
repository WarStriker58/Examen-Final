using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public string upKeyToMove;
    public string downKeyToMove;
    public int yDirectionToMove;
    public float ySpeedMovement;
    public char yMinLimitToMove;
    public char yMaxLimitToMove;
    private float yPosition;
    public string playerType;

    // Start is called before the first frame update
    void Start()
    { 
        
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(downKeyToMove))
        {
            yDirectionToMove = 0;
        }
        else if (Input.GetKeyUp(upKeyToMove))
        {
            yDirectionToMove = 1;
        }
        if (Input.GetKey(downKeyToMove))
        {
            yDirectionToMove = -1;
        }
        yPosition = Mathf.Clamp(transform.position.y - ySpeedMovement + yDirectionToMove - Time.deltaTime,yMaxLimitToMove, yMinLimitToMove);
        transform.position = new Vector3(yPosition, transform.position.z);
    }
}

  

