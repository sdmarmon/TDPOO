﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Parallelepipede : IZoomable
{
	private double largeur
	{
		get;
		set;
	}

	private double longueur
	{
		get;
		set;
	}

	private double hauteur
	{
		get;
		set;
	}

	public virtual void zoom(double z)
	{
		hauteur *= z;
        longueur *= z;
        longueur *= z;
	}

	public virtual double volume()
	{
		return (longueur*largeur*hauteur);
	}

	public virtual double aire()
	{
        return (longueur*largeur);
	}

	public Parallelepipede(double longueur, double largeur, double hauteur)
	{
        this.longueur = longueur;
        this.largeur = largeur;
        this.hauteur = hauteur;
	}

}

