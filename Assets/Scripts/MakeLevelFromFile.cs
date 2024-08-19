using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEditor;
using Unity.VisualScripting;
using System;

public class MakeLevelFromFile : MonoBehaviour
{
    [SerializeField] private string levelName;

    //prefabs
    [SerializeField] private GameObject platform;
    [SerializeField] private GameObject goal;
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject spike;
    [SerializeField] private GameObject timeAdd;
    // Start is called before the first frame update
    void Start()
    {
        string path = "Assets/Levels/" + levelName + ".txt";
        AssetDatabase.ImportAsset(path);
        StreamReader reader = new StreamReader(path);
        string currentLine;
        /*
        p is platform
        g is goal
        c is player (character)
        s is spike
        t is time adder
        format is [identifier] [position] [rotation] [scale] [extra]
         */
        while ((currentLine = reader.ReadLine()) != null) 
        {
            char separator = ' ';
            string[] objectData = currentLine.Split(separator);
            GameObject temp = null;
            string[] positions = objectData[1].Split(',');
            string[] rotation = objectData[2].Split(',');
            string[] scale = objectData[3].Split(',');
            if (objectData[0] == "c")
            {
                temp = Instantiate(player);
                try
                {
                    if (temp == null)
                    {
                        throw new Exception("unrecognized object");
                    }
                    temp.transform.SetPositionAndRotation(new Vector3(float.Parse(positions[0]), float.Parse(positions[1]), 5), Quaternion.Euler(new Vector3(float.Parse(rotation[0]), float.Parse(rotation[1]), float.Parse(rotation[2]))));
                    temp.transform.localScale = new Vector3(float.Parse(scale[0]), float.Parse(scale[1]), float.Parse(scale[2]));
                }
                catch (Exception e)
                {
                    Debug.Log(e);
                }
            } else if (objectData[0] == "p")
            {
                temp = Instantiate(platform);
                try
                {
                    if (temp == null)
                    {
                        throw new Exception("unrecognized object");
                    }
                    temp.transform.SetPositionAndRotation(new Vector3(float.Parse(positions[0]), float.Parse(positions[1]), 0), Quaternion.Euler(new Vector3(float.Parse(rotation[0]), float.Parse(rotation[1]), float.Parse(rotation[2]))));
                    temp.transform.localScale = new Vector3(float.Parse(scale[0]), float.Parse(scale[1]), float.Parse(scale[2]));
                }
                catch (Exception e)
                {
                    Debug.Log(e);
                }
            } else if (objectData[0] == "g")
            {
                temp = Instantiate(goal);
                temp.GetComponent<VictoryTrigger>().sceneName = objectData[4];
                try
                {
                    if (temp == null)
                    {
                        throw new Exception("unrecognized object");
                    }
                    temp.transform.SetPositionAndRotation(new Vector3(float.Parse(positions[0]), float.Parse(positions[1]), 3), Quaternion.Euler(new Vector3(float.Parse(rotation[0]), float.Parse(rotation[1]), float.Parse(rotation[2]))));
                    temp.transform.localScale = new Vector3(float.Parse(scale[0]), float.Parse(scale[1]), float.Parse(scale[2]));
                }
                catch (Exception e)
                {
                    Debug.Log(e);
                }
            } else if (objectData[0] == "s")
            {
                temp = Instantiate(spike);
                try
                {
                    if (temp == null)
                    {
                        throw new Exception("unrecognized object");
                    }
                    temp.transform.SetPositionAndRotation(new Vector3(float.Parse(positions[0]), float.Parse(positions[1]), -1), Quaternion.Euler(new Vector3(float.Parse(rotation[0]), float.Parse(rotation[1]), float.Parse(rotation[2]))));
                    temp.transform.localScale = new Vector3(float.Parse(scale[0]), float.Parse(scale[1]), float.Parse(scale[2]));
                }
                catch (Exception e)
                {
                    Debug.Log(e);
                }
            } else if (objectData[0] == "t")
            {
                temp = Instantiate(timeAdd);
                try
                {
                    if (temp == null)
                    {
                        throw new Exception("unrecognized object");
                    }
                    temp.transform.SetPositionAndRotation(new Vector3(float.Parse(positions[0]), float.Parse(positions[1]), 2), Quaternion.Euler(new Vector3(float.Parse(rotation[0]), float.Parse(rotation[1]), float.Parse(rotation[2]))));
                    temp.transform.localScale = new Vector3(float.Parse(scale[0]), float.Parse(scale[1]), float.Parse(scale[2]));
                }
                catch (Exception e)
                {
                    Debug.Log(e);
                }
            }
            
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
