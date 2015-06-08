# SharpAPI #
## Introduction ##
SharpAPI is a plugin system created for the MMORPG ROSE Online (kROSE v736 - <a href='http://www.aruarose.com/'>AruaROSE</a>, <a href='http://www.titanrose.com/'>TitanROSE</a>, etc.). Written in a variety of programming languages targeting the .NET Framework (version 4), SharpAPI allows players to create and use plugins written in most CLI languages (<a href='http://en.wikipedia.org/wiki/List_of_CLI_languages'>see a list of the most popular</a>).

Plugins can either be compiled into DLL form or Python scripts (.py files). An example of a Python script can be seen below, the example draws the text "SharpAPI is running!" onto the screen.
```
import clr
clr.AddReference('System.Drawing')

from System.Drawing import Color
from SharpAPI import *
from SharpAPI.Engine import *

def Render():
    Sprite.Begin()
    Sprite.DrawText('SharpAPI is running!', Font.NormalOutline, 50, 50, Color.White)
    Sprite.End()
    
Scene.RenderOverlay += Render
```

The example below achieves the same results except is written in C# and compiled as a plugin.
```
using SharpAPI;
using SharpAPI.Engine;
using SharpAPI.Plugin;
using SharpAPI.Plugin.Attributes;
using Color = System.Drawing.Color;

namespace PluginExample {
    [PluginName("Plugin Example")]
    [PluginDescription("An example of a plugin")]
    [PluginAuthor("xadet")]
    [PluginVersion("1.00")]
    public class PluginClass : IPlugin {
        public void Render() {
            Sprite.Begin();
            Sprite.DrawText("SharpAPI is running!", Font.NormalOutline, 50, 50, Color.White);
            Sprite.End();
        }

        public void Initialize() {
            Scene.RenderOverlay += Render;
        }
    }
}
```

## Installation ##
First, download the prerequisites listed below.
After the prerequisites have been installed, download the latest build from the <a href='http://code.google.com/p/sharpapi/downloads/list'>Downloads</a> page, once downloaded extract the contents to your ROSE online folder.<br />
SharpAPI uses zlib1.dll to inject itself into the ROSE online process, therefore no extra steps need to be taken when starting ROSE to initialize the plugin system. To uninstall SharpAPI, restore the original zlib1.dll which can be downloaded pre-compiled from <a href='http://www.zlib.net/'>zlib.net</a>.

## Prerequisites ##
<a href='http://www.microsoft.com/downloads/en/details.aspx?FamilyID=9cfb2d51-5ff4-4491-b0e5-b386f32c0992&displaylang=en'><img src='http://img842.imageshack.us/img842/3465/dotnet4logo.png' /></a><br />
<a href='http://ironpython.codeplex.com/releases/view/42434'><img src='http://img831.imageshack.us/img831/4837/ironpythonlogo.png' /></a>

## Console Plugin ##
SharpAPI features a console plugin which allows developers to access the SharpAPI interface library through a <a href='http://www.python.org/'>Python</a> command-line system. The console can be accessed at any time in game by pressing F12.<br />
_Please note that the console is still in development and does not represent the finished product_

<a href='http://img839.imageshack.us/img839/5729/64268596.jpg'><img src='http://img207.imageshack.us/img207/7599/97842434.jpg' /></a>


---

![http://www.gnu.org/graphics/lgplv3-147x51.png](http://www.gnu.org/graphics/lgplv3-147x51.png)

This library is free software; you can redistribute it and/or modify it under the terms of the GNU Lesser General Public License as published by the Free Software Foundation; either version 3.0 of the License, or (at your option) any later version.

This library is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU Lesser General Public License for more details.