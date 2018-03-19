﻿using System;
using UnityEngine;
using Rocket.API;
using Rocket.Unturned.Player;
using Rocket.Unturned;
using Rocket.Unturned.Commands;
using Rocket.Unturned.Chat;
using System.Collections.Generic;

namespace TebexUnturned
{
    public class CommandTebexForcecheck : IRocketCommand
    {
        public AllowedCaller AllowedCaller => AllowedCaller.Console;

        public bool RunFromConsole => true;

        public string Name => "tebex:forcecheck";

        public string Help => "Force check packages currently waiting to be executed";
        
        public string Syntax => "";

        public List<string> Aliases => new List<string>();

        public List<string> Permissions => new List<string>() { "tebex.permission" };

        public void Execute(IRocketPlayer caller, string[] command)
        {
            
        }        
    }
}