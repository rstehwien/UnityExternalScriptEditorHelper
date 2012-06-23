UnityExternalScriptEditorHelper
===============================

Mono based application so unity can launch external app with line-number.  Links at the bottom discuss using the original C++ based application which wasn't portable.  This application was written to work on Windows and OSX (hopefully, OSX is currently untested).

Unity (as of version 3.5) unfortunately doesn't pass the line number to other script editors except whichever is designated as the built-in editor (which is MonoDevelop as of Unity version 3.5).

So, we have this program which fakes itself as MonoDevelop but in reality will pass the arguments from Unity into a script editor of your choosing, complete with the line number so that your script editor will jump to the proper line number.


TO USE:
-------

1. Edit the UnityExternalScriptEditorHelper.xml:
	1. Change <application> to whatever script editor you plan on using. The default is using Sublime Text 2 on a 64-bit Windows system
	2. Change <arguments> to however your script editor takes in a file and linenumber when opened. *file* will be replaced with the actual file string and *line* will be replaced with the actual line number. The default is configured for Sublime Text 2
2. CopyUnityExternalScriptEditorHelper.xml and UnityExternalScriptEditorHelper.exe to where your Unity MonoDevelop.exe resides. (C:\Program Files\Unity\MonoDevelop\bin for example)
	1. Create a backup of your current MonoDevelop.exe or rename it to another filename
	2. Rename UnityExternalScriptEditorHelper.exe into MonoDevelop.exe
3. Set Unity to use the built-in editor.
4. Try it, it should now open your specified scripting editor at the proper line number!

Reference
---------
http://www.jacobpennock.com/Blog/?p=568
http://unifycommunity.com/wiki/index.php?title=Using_Notepad_Plus_Plus_as_a_script_editor

License
-------
This app is using the zlib license

Copyright (c) 2012 Robert Stehwien

This software is provided 'as-is', without any express or implied warranty. In no event will the authors be held liable for any damages arising from the use of this software.

Permission is granted to anyone to use this software for any purpose, including commercial applications, and to alter it and redistribute it freely, subject to the following restrictions:

The origin of this software must not be misrepresented; you must not claim that you wrote the original software. If you use this software in a product, an acknowledgment in the product documentation would be appreciated but is not required.
Altered source versions must be plainly marked as such, and must not be misrepresented as being the original software.
This notice may not be removed or altered from any source distribution.