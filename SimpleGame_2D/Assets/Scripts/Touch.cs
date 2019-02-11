using UnityEngine;
using System.Collections;

public class Touch : MonoBehaviour
{
    private Controls player;


    void Start()
    {
        player = FindObjectOfType<Controls>();
    }

    public void LeftArrow()
    {
        player.moveright = false;
        player.moveleft = true;
        player.moveup = false;
    }
    public void RightArrow()
    {
        player.moveright = true;
        player.moveleft = false;
        player.moveup = false;
    }
    public void UpArrow()
    {
        player.moveright = false;
        player.moveleft = false;
        player.moveup = true;
    }
    public void ReleaseLeftArrow()
    {
        player.moveleft = false;
    }
    public void ReleaseRightArrow()
    {
        player.moveright = false;

    }
    public void ReleaseUpArrow()
    {
        player.moveup = false;

    }

}