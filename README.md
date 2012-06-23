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