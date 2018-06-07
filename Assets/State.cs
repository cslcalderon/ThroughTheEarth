using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "State")]
public class State : ScriptableObject
{
    //do this to you do stuff
    [TextArea (14,10)] [SerializeField] string storyText;

    public string GetStateStory()
    {
        return storyText;
    }
}
