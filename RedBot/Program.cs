﻿using Discord;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBot
{
	class Program
	{
		static void Main(string[] args)
		{
			string token = ""; //insert your token here if you want to use this bot!

			if (args.Length == 2)
			{
				token = args[1];
			}

			RedBotClient bot = new RedBotClient(token);
		}
	}
}
