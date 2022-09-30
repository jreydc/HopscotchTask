﻿using UnityEngine;

[RequireComponent(typeof(BoxCollider))]
public class Projectile : MonoBehaviour
{
    public ProjectileStats _projectileStats;
    public System.Action<Projectile> IsDestroyed;
    public Rigidbody _RB;
    public MeshFilter _meshFilter;    
    public virtual void Awake(){
        _RB = GetComponent<Rigidbody>();
        _meshFilter = GetComponent<MeshFilter>();
    }

    public virtual void OnDestroy() {
        if(IsDestroyed != null) IsDestroyed?.Invoke(this);
    }

    // Update is called once per frame
    /* void Update()
    {
        waitTime -= Time.deltaTime;
        if (waitTime <= 0)
        {
            _RB.velocity = new Vector3(0, 0, -speed);
        }
    } */


    public virtual void ProjectileMovement(){
        _RB.velocity = new Vector3(0, 0, -_projectileStats.speed);
    }

    public virtual void CheckCollision(Collider other){
        Debug.Log(other.name);
    }
}