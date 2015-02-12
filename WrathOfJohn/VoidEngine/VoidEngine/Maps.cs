﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VoidEngine
{
	public static class Maps
	{
		public static uint[,] GetBrickArray(List<string> lines)
		{
			uint[,] brickArray = new uint[lines[0].Length, lines.Count];
			for (int i = 0; i < lines[0].Length; i++)
			{
				for (int j = 0; j < lines.Count; j++)
				{
					switch (lines[j][i])
					{
						case '.':
							brickArray[i, j] = 0;
							break;
						case '1':
							brickArray[i, j] = 1;
							break;
						case '2':
							brickArray[i, j] = 2;
							break;
						case '3':
							brickArray[i, j] = 3;
							break;
						default:
							break;
					}
				}
			}
			return brickArray;
		}

		public static List<string> HappyFace()
		{
			List<string> Lines = new List<string>();
			Lines.Add("..........1111...........");
			Lines.Add(".........12121...........");
			Lines.Add("........121121...........");
			Lines.Add(".......11111111..........");
			Lines.Add(".......222111121.........");
			Lines.Add(".......221112212.........");
			Lines.Add(".........................");
			Lines.Add(".........................");
			Lines.Add(".........................");
			Lines.Add(".........................");
			Lines.Add(".........................");
			Lines.Add(".........................");
			Lines.Add(".........................");
			Lines.Add(".........................");
			Lines.Add(".........................");
			Lines.Add(".........................");
			return Lines;
		}

	}
}
