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
		throw new System.NotImplementedException();
	}

	public virtual double volume()
	{
		throw new System.NotImplementedException();
	}

	public virtual double aire()
	{
		throw new System.NotImplementedException();
	}

	public Cube(double cote)
	{
	}

}
