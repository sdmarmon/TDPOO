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

public class Cube : IZoomable
{
	private double cote
	{
		get;
		set;
	}

	public virtual void zoom(double z)
	{
		cote *= z;
	}

	public double volume()
	{
		return (cote*cote*cote) ;
	}

	public double aire()
	{
        return (cote*cote);
	}

	public Cube(double cote)
	{
        this.cote = cote;
	}

}

