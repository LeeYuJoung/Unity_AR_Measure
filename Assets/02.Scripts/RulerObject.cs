using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RulerObject : MonoBehaviour
{
    public List<Transform> objectList = new List<Transform>();
    public LineRenderer lineObject;
    public Transform textObject;
    public TextMesh textMesh;
    public Transform mainCam;

    public void SetInit(Vector3 pos)
    {
        objectList[0].transform.position = pos;
        lineObject.SetPosition(0, pos);
    }

    public void SetObject(Vector3 pos)
    {
        objectList[1].transform.position = pos;
        lineObject.SetPosition(1, pos);
    }

    void Update()
    {
        Vector3 tVector = objectList[1].position - objectList[0].position;
        textObject.position = objectList[0].position + tVector * 0.5f;

        float tDistance = tVector.magnitude * 100.0f;
        string tDisText = string.Format("{0}cm", tDistance.ToString("N2"));
        textMesh.text = tDisText;
        textObject.LookAt(mainCam);
    }
}
