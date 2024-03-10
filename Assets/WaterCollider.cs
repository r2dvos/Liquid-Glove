using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider))]
public class WaterCollider : MonoBehaviour
{
    private List<string> fingers = new List<string>();
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("FingerTip"))
        {
            fingers.Add(other.name);
        }
    }

    void Update()
    {
        string result = "In water: ";
        foreach (string f in this.fingers)
        {
            result += f.ToString() + ", ";
        }
        Debug.Log(result);
        fingers.Clear();
    }
}
