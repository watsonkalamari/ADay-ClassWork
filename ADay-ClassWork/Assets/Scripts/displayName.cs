/* Display name in Debug.Log
 * version 1.0
 * Author: Kimari Watson
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class displayName : MonoBehaviour
{
    public string name;
    public string nickname = "squid";


    // Start is called before the first frame update
    void Start()
    {
        name = "Kimari";   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void displayTextOnLog()
    {
        Debug.Log(name);
    }
}
