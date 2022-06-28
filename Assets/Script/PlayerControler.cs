using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    private Camera m_Camera;
    public GunControler gun;
    public bool isLooking;
    // Start is called before the first frame update
    void Start()
    {

        m_Camera = FindObjectOfType<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        Ray cameraRay = m_Camera.ScreenPointToRay(Input.mousePosition);
        Plane groundPlane = new Plane(Vector3.up, Vector3.zero);
        float rayLength;

        if(groundPlane.Raycast(cameraRay, out rayLength)){
            if(isLooking = true && Time.timeScale!=0f) {
                Vector3 pointToLook = cameraRay.GetPoint(rayLength);
                Debug.DrawLine(cameraRay.origin, pointToLook, Color.red);
                transform.LookAt(pointToLook);
            }
            else
            {
                Time.timeScale = 0;
            }
        }
    }
}
