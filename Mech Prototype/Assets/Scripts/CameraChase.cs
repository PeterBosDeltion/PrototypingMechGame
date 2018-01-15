using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class CameraChase : MonoBehaviour {
    public List<Transform> targets = new List<Transform>();
    public Vector3 offset;
    public float smoothTime;

    public float minZoom;
    public float maxZoom;
    public float zoomLimit;

    private Vector3 velocity;
    private Camera myCam;

    void Start()
    {
        myCam = GetComponent<Camera>();
    }

	void LateUpdate () {
        if(targets.Count > 0)
        {
            Move();
            Zoom();
        }
      

	}

    void Move()
    {
        Vector3 center = GetCenter();

        Vector3 newPos = center + offset;

        transform.position = Vector3.SmoothDamp(transform.position, newPos, ref velocity, smoothTime);
    }

    void Zoom()
    {
        float newZoom = Mathf.Lerp(maxZoom, minZoom, GetGreatestDistance() / zoomLimit);
        myCam.fieldOfView = Mathf.Lerp(myCam.fieldOfView, newZoom, Time.deltaTime);
    }

    float GetGreatestDistance()
    {
        var bounds = new Bounds(targets[0].position, Vector3.zero);
        for (int i = 0; i < targets.Count; i++)
        {
            bounds.Encapsulate(targets[i].position);
        }

        return bounds.size.x;
    }

    Vector3 GetCenter()
    {
        if(targets.Count == 1)
        {
            return targets[0].position;
        }

        var bounds = new Bounds(targets[0].position, Vector3.zero);
        for (int i = 0; i < targets.Count; i++)
        {
            bounds.Encapsulate(targets[i].position);
        }

        return bounds.center;
    }
}
