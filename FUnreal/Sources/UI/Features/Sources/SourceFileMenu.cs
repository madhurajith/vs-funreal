﻿using Community.VisualStudio.Toolkit;
using Microsoft.VisualStudio.Shell;
using System.Threading.Tasks;
using System.Diagnostics;
using System;
using EnvDTE;
using EnvDTE80;

namespace FUnreal
{
    [Command(VSCTSymbols.SourceFileMenu)]
    public class SourceFileMenu : XMenuCmd<SourceFileMenu> 
    { 
    
    }
}
