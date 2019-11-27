﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttr : MonoBehaviour
{
    public int hp, expVal, scoreVal, damage;
    public int speed, jumpForce, fallSpeed, maxSpeed;
    public bool isStuck, isFalling, facingLeft, isGrounded, isDamaged, isDead;
    public int direction; // right = 1, left = -1;
    public float hitDist = 0.6f;
    public new string name;

    public AudioSource audioSource;
    public AudioClip hit, dead;
    // Start is called before the first frame update
    void Start()
    {
        hp = expVal = scoreVal = maxSpeed = speed = jumpForce = fallSpeed = damage = direction = 1;
        isStuck = isFalling = facingLeft = isGrounded = isDamaged = isDead = false;
        name = "enemy";
    }
    public void PlayHit()
    {
        audioSource.PlayOneShot(hit);
    }
    public void PlayDead()
    {
        audioSource.PlayOneShot(dead);
    }

    public string toString()
    {
        string s = "hp: " + hp
            + "\n expVal: " + expVal
            + "\n scoreVal: " + scoreVal
            + "\n speed: " + speed
            + "\n jumpForce: " + jumpForce;
        return s;
    }
}
