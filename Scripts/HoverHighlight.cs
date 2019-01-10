using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HoverHighlight : MonoBehaviour {

    public GameObject hoveredObject;
    public float selectRange = 50f;
    public float hitForce = 100f;
    public Camera fpCamera;
    public Material hoveredMaterial;

    void Update()
    {
        // Take a position from the camera and convert it to a point in world space
        // In this case, right in front of the player
        Vector3 rayOrigin = fpCamera.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0));
        RaycastHit hit;

        if (Physics.Raycast(rayOrigin, fpCamera.transform.forward, out hit, selectRange))
        {
            // The item being hovered over needs to have a "Selectable" script
            Selectable selectable = hit.collider.GetComponent<Selectable>();

            if (selectable)
            {
                // Add outline material on hover
                hoverObject(selectable.gameObject);
            }

            if (Input.GetMouseButtonDown(0))
            {
                // If there is a selectable in the traced object, damage it
                if (selectable)
                {
                }

                // Add force to wiggle it a bit
                if (hit.rigidbody)
                {
                    hit.rigidbody.AddForce(-hit.normal * hitForce);
                }
            }
        }
        else
        {
            clearHover();
        }
    }

    void hoverObject(GameObject obj)
    {
        if (hoveredObject)
        {
            if (obj == hoveredObject)
                return;
            clearHover();
        }

        hoveredObject = obj;

        Renderer[] renderers = hoveredObject.GetComponentsInChildren<Renderer>();
        foreach (Renderer r in renderers)
        {
            // Make an array with 1 more element and place the outline material there
            Material[] mats = new Material[r.materials.Length + 1];

            for (int i = 0; i < r.materials.Length; i++)
            {
                mats[i] = r.materials[i];
            }

            mats[mats.Length - 1] = hoveredMaterial;
            r.materials = mats;
        }
    }

    void clearHover()
    {
        if (!hoveredObject)
        {
            return;
        }

        // Remove the outline material
        Renderer[] renderers = hoveredObject.GetComponentsInChildren<Renderer>();
        foreach (Renderer r in renderers)
        {
            Material[] mats = new Material[r.materials.Length - 1];
            for (int i = 0; i < mats.Length; i++)
            {
                mats[i] = r.materials[i];
            }
            r.materials = mats;

        }
        hoveredObject = null;
    }
}
