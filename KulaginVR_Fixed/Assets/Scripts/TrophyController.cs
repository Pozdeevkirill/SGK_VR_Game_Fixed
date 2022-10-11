using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class TrophyController : MonoBehaviour
{
    public GameObject Particle;
    public GameObject GameController;

    void OnAttachedToHand(Hand hand)
    {
        Instantiate(Particle, gameObject.transform.position, Quaternion.identity);
        GameController.GetComponent<LevelController>().AddTrophy();
        Destroy(gameObject);
    }

}
