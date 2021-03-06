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

public class Rectangle
{
    private Point pt2;

    public Point Pt2
    {
        get { return pt2; }
        set { pt2 = value; }
    }

    private Point pt1;

    public Point Pt1
    {
        get { return pt1; }
        set { pt1 = value; }
    }

	public Rectangle(Point pt1, Point pt2)
	{
        this.pt1 = pt1;
        this.pt2 = pt2;
	}

	public Rectangle(Point pt1, double l1, double l2)
	{
        this.pt1 = pt1;
        pt2.X = pt1.X + l1;
        pt2.Y = pt1.Y + l2;
	}

	public Rectangle(double l1, double l2, double l3, double l4)
	{
        pt1.X = l1;
        pt1.Y = l3;
        pt2.X = pt1.X + l2;
        pt2.Y = pt1.Y + l4;
	}

	public double CalculeSurface()
	{
        return ((pt2.X - pt1.X) * (pt2.Y - pt1.Y));
	}

	public void SetPosition(Point pt1)
	{
		double l1 = pt2.X - this.pt1.X;
        double l2 = pt2.Y - this.pt1.Y;
        this.pt1 = pt1;
        pt2.X = pt1.X + l1;
        pt2.Y = pt1.Y + l2;
	}

	public bool EstEgal(Rectangle r)
	{
        return ((this.pt1.EstEgal(r.pt1)) && (this.pt2.EstEgal(r.pt2)));
	}

}

