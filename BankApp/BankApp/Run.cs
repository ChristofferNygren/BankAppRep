﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    public class Run
    {
        Menus menus = new Menus();
        AccountHolder accountholder;
        public void RunTheApp()
        {
            
            menus.MainMenu();
            MainMenuChoice();
        }

    }
}
