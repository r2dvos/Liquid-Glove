using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider))]
public class WaterCollider : MonoBehaviour
{
    private List<string> fingers = new List<string>();
    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("FingerTip"))
        {
            fingers.Add(Rename(other.name));
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("FingerTip"))
        {
            fingers.Remove(Rename(other.name));
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
        //fingers.Clear();
    }

    string Rename(string name)
    {
        switch (name)
        {
            case "hands:b_r_middle3":
                return "1";
            case "hands:b_r_middle2":
                return "2";
            case "hands:Rhand":
                return "3";
            default:   // shouldnt happen
                return name;
        }
            

    }
}
