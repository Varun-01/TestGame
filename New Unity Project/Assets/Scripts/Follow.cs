using UnityEngine;

public class Follow : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;

    public float height = 5f;
    public float distance = 10f;
    public float angle = 180f;
    public bool topDown = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if(Input.GetKey("t")){
            topDown = !topDown;
        }   
        height = topDown? 20 : 5;
        distance = topDown? 5 : 10;

        //transform.position = player.position + offset;
        Vector3 worldPosition = (Vector3.forward * distance) + (Vector3.up * height);

        Vector3 rotatedVector = Quaternion.AngleAxis(angle,Vector3.up) * worldPosition;
        
        Vector3 flatTargetPosition = player.position;
        flatTargetPosition.y = 0f;
        Vector3 finalPosition = flatTargetPosition + rotatedVector;

        transform.position = finalPosition;
        transform.LookAt(flatTargetPosition);
    }
}

